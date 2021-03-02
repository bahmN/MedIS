
using MySql.Data.MySqlClient;

namespace MedIS.logic
{
    class Personal
    {

        public MySqlCommand addPersonal(string FN, string Pos, string Spec, string Note, string Login, string Password)
        {
            Connection con = new Connection();
            MySqlCommand cAdd = new MySqlCommand("INSERT INTO персонал(`ФИО врача`, Должность, Специализация, Примечание, Логин, Пароль)" +
                " VALUES ('" + FN + "', '" + Pos + "', '" + Spec + "', '" + Note + "', '" + Login + "', '" + Password + "')", con.connect());
            cAdd.ExecuteNonQuery();

            return cAdd;
        }

        public MySqlCommand changePersonal(string PK, string FN, string Pos, string Spec, string Note)
        {
            Connection con = new Connection();
            MySqlCommand cChng = new MySqlCommand("UPDATE персонал SET `ФИО Врача`= '" + FN + "', Должность= '" + Pos + "', Примечание= '" + Note + "'" +
                ", Специализация= '" + Spec + "' WHERE `Номер врача`= '" + PK + "'", con.connect());
            cChng.ExecuteNonQuery();

            return cChng;
        }

        public MySqlCommand deletePersonal(string headerText, string selectRow)
        {
            Connection con = new Connection();
            MySqlCommand cDel = new MySqlCommand("DELETE FROM персонал WHERE `" + headerText + "` = '" + selectRow + "'", con.connect());
            cDel.ExecuteNonQuery();
            return cDel;
        }

        public MySqlDataAdapter searchPersonal(string tbSearch)
        {
            Connection connection = new Connection();
            MySqlDataAdapter daSearch = new MySqlDataAdapter("SELECT `ФИО врача`, Должность, Специализация, Логин FROM персонал " +
                      "WHERE `ФИО врача` LIKE '%" + tbSearch + "%' " +
                      "OR Должность LIKE '%" + tbSearch + "%' " +
                      "OR Специализация LIKE '%" + tbSearch + "%' " +
                      "OR Логин LIKE '%" + tbSearch + "%'", connection.connect());
            return daSearch;
        }
    }
}
