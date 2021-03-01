
using MySql.Data.MySqlClient;

namespace MedIS.logic
{
    class AddPersonal
    {

        public MySqlCommand addPersonal(string FN, string Pos, string Spec)
        {
            Connection con = new Connection();
            MySqlCommand cAdd = new MySqlCommand("INSERT INTO персонал(`ФИО врача`, Должность, Специализация) VALUES ('" + FN + "', '" + Pos + "', '" + Spec + "')", con.connect());
            cAdd.ExecuteNonQuery();

            return cAdd;
        }
    }
}
