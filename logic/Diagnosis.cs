using MySql.Data.MySqlClient;

namespace MedIS.logic
{
    class Diagnosis
    {
        public MySqlCommand addDiagnosis(string Name, string NumbAppointment, string Result, string Note)
        {
            Connection con = new Connection();
            MySqlCommand cAdd = new MySqlCommand("INSERT INTO диагнозы(Название, `Номер записи`, Результат, Примечание)" +
                " VALUES ('" + Name + "', '" + NumbAppointment + "', '" + Result + "', '" + Note + "')", con.connect());
            cAdd.ExecuteNonQuery();

            return cAdd;
        }

        public MySqlCommand changeDiagnosis(string Name, string NumbAppointment, string Result, string Note, string PK)
        {
            Connection con = new Connection();
            MySqlCommand cChng = new MySqlCommand("UPDATE диагнозы SET `Название`= '" + Name + "', `Номер записи`= '" + NumbAppointment + "'" +
                ", `Результат`= '" + Result + "', Примечание= '" + Note + "' WHERE Название = '" + PK + "'", con.connect());
            cChng.ExecuteNonQuery();

            return cChng;
        }
    }
}
