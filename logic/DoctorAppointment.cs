using MySql.Data.MySqlClient;

namespace MedIS.logic
{
    class DoctorAppointment
    {
        public MySqlCommand addAppoinment(string numbPatient, object numbDoctor, string Date, string Ambul, string Dispanser, string Note)
        {
            Connection con = new Connection();
            MySqlCommand cAdd = new MySqlCommand("INSERT INTO `записи к врачу`(`Номер пациента`, `Номер врача`, `Дата обращения`, `Амбулаторное лечение`, `Диспансер`, Примечание)" +
                " VALUES ('" + numbPatient + "', '" + numbDoctor + "', '" + Date + "', '" + Ambul + "', '" + Dispanser + "', '" + Note + "')", con.connect());
            cAdd.ExecuteNonQuery();

            return cAdd;
        }

        public MySqlCommand changeAppoinment(string PK, string FN, string Pos, string Spec, string Note)
        {
            Connection con = new Connection();
            MySqlCommand cChng = new MySqlCommand("UPDATE персонал SET `ФИО Врача`= '" + FN + "', Должность= '" + Pos + "', Примечание= '" + Note + "'" +
                ", Специализация= '" + Spec + "' WHERE `Номер врача`= '" + PK + "'", con.connect());
            cChng.ExecuteNonQuery();

            return cChng;
        }
    }
}
