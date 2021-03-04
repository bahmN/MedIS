using MySql.Data.MySqlClient;

namespace MedIS.logic
{
    class Patient
    {
        public MySqlCommand addPatient(string Polis, string FN, string DateBirth, string Adress, string Phone, string Passport)
        {
            Connection con = new Connection();
            MySqlCommand cAdd = new MySqlCommand("INSERT INTO пациенты(`Номер полиса`, `ФИО Пациента`, `Дата рождения`, Адрес, Телефон, `Паспортные данные`)" +
                " VALUES ('" + Polis + "', '" + FN + "', '" + DateBirth + "', '" + Adress + "', '" + Phone + "', '" + Passport + "')", con.connect());
            cAdd.ExecuteNonQuery();

            return cAdd;
        }

        public MySqlCommand changePatient(string Polis, string FN, string DateBirth, string Adress, string Phone, string Passport, string PK)
        {
            Connection con = new Connection();
            MySqlCommand cChng = new MySqlCommand("UPDATE пациенты SET `Номер полиса`= '" + Polis + "', `ФИО пациента`= '" + FN + "', `Дата рождения`= '" + DateBirth + "', Адрес= '" + Adress + "'" +
                ", Телефон= '" + Phone + "', `Паспортные данные`= '" + Passport + "' WHERE `Номер полиса`= '" + PK + "'", con.connect());
            cChng.ExecuteNonQuery();

            return cChng;
        }

        public MySqlCommand deletePatient(string headerText, string selectRow)
        {
            Connection con = new Connection();
            MySqlCommand cDel = new MySqlCommand("DELETE FROM пациенты WHERE `" + headerText + "` = '" + selectRow + "'", con.connect());
            cDel.ExecuteNonQuery();
            return cDel;
        }
        public MySqlCommand deletePatient2(string NumPatient)
        {
            Connection con = new Connection();
            MySqlCommand cDel = new MySqlCommand("DELETE FROM `записи к врачу` WHERE `Номер пациента` = '" + NumPatient + "'", con.connect());
            cDel.ExecuteNonQuery();
            return cDel;
        }
        public MySqlCommand deletePatient3(string NumPatient)
        {
            Connection con = new Connection();
            MySqlCommand cDel = new MySqlCommand("DELETE FROM Диагнозы WHERE `Номер пациента` = '" + NumPatient + "'", con.connect());
            cDel.ExecuteNonQuery();
            return cDel;
        }



        public MySqlDataAdapter searchPatient(string tbSearch)
        {
            Connection connection = new Connection();
            MySqlDataAdapter daSearch = new MySqlDataAdapter("SELECT `Номер полиса`, `ФИО Пациента`, `Дата рождения`, Адрес, Телефон, `Паспортные данные` FROM пациенты " +
                      "WHERE `Номер полиса` LIKE '%" + tbSearch + "%' " +
                      "OR `ФИО Пациента` LIKE '%" + tbSearch + "%' " +
                      "OR `Дата рождения` LIKE '%" + tbSearch + "%' " +
                      "OR Адрес LIKE '%" + tbSearch + "%' " +
                      "OR Телефон LIKE '%" + tbSearch + "%' " +
                      "OR `Паспортные данные` LIKE '%" + tbSearch + "%'", connection.connect());
            return daSearch;
        }
    }
}
