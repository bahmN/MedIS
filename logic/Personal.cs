
using MySql.Data.MySqlClient;

namespace MedIS.logic
{
    class Personal
    {

        public MySqlCommand addPersonal(string FN, string Pos, string Spec, string NotePos, string NoteSpec)
        {
            Connection con = new Connection();
            MySqlCommand cAdd = new MySqlCommand("INSERT INTO персонал(`ФИО врача`, Должность,`Примечание о должности`, Специализация, `Примечание о специализации`)" +
                " VALUES ('" + FN + "', '" + Pos + "', '" + NotePos + "', '" + Spec + "', '" + NoteSpec + "')", con.connect());
            cAdd.ExecuteNonQuery();

            return cAdd;
        }

        public MySqlCommand changePersonal(string PK, string FN, string Pos, string Spec, string NotePos, string NoteSpec)
        {
            Connection con = new Connection();
            MySqlCommand cChng = new MySqlCommand("UPDATE персонал SET `ФИО Врача`= '" + FN + "', Должность= '" + Pos + "', `Примечание о должности`= '" + NotePos + "'" +
                ", Специализация= '" + Spec + "', `Примечание о специализации`= '" + NoteSpec + "' WHERE `Номер врача`= '" + PK + "'", con.connect());
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
    }
}
