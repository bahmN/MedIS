using System.Diagnostics;
using System.Windows.Forms;

namespace MedIS.logic
{
    class Backup
    {

        public void import(OpenFileDialog fileDialog)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "cmd.exe";

            startInfo.Arguments = "/c \"\"C:\\Program Files\\MySQL\\MySQL Server 8.0\\bin\\MySQL.exe\" -uroot -h127.0.0.1 -P3306 -pVfhnvfhn23@ mis < \"" + fileDialog.FileName + "\"\"";
            process.StartInfo = startInfo;
            process.Start();

        }

        public void export(SaveFileDialog saveFile)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "cmd.exe";
            saveFile.Filter = "MySQL Text File|*.sql";
            saveFile.FileName = "Backup LIS";
            if (saveFile.ShowDialog() == DialogResult.OK) {
                startInfo.Arguments = "/c \"\"C:\\Program Files\\MySQL\\MySQL Server 8.0\\bin\\MySQLdump.exe\" -uroot -h127.0.0.1 -P3306 -pVfhnvfhn23@ mis > \"" + saveFile.FileName + "\"\"";
                process.StartInfo = startInfo;
                process.Start();
            }

        }
    }
}
