using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HomeWork
{
    class Loading
    {
        public void LoadingFile(MainWindow form)
        {
            for (int i = 0; i < 10; i++)
            {
                List<double> list = new List<double>();
                string link = "";
                switch (i)
                {
                    case 0: link = "D:/q/LOC.txt"; break;
                    case 1: link = "D:/q/NOM.txt"; break;
                    case 2: link = "D:/q/NOP.txt"; break;
                    case 3: link = "D:/q/NDD.txt"; break;
                    case 4: link = "D:/q/HIT.txt"; break;
                    case 5: link = "D:/q/CM.txt"; break;
                    case 6: link = "D:/q/WOC.txt"; break;
                    case 7: link = "D:/q/FDP.txt"; break;
                    case 8: link = "D:/q/AMW.txt"; break;
                    case 9: link = "D:/q/ATFD.txt"; break;
                }
                //Записуємо дані з потоrу даних в тимчасовий список
                StreamReader sr = new StreamReader(link);
                while (!sr.EndOfStream)
                {
                    string str = sr.ReadLine();
                    list.Add(Convert.ToDouble(str));
                }
                sr.Close();
                switch (i)
                {
                    case 0: form.LOC = list; break;
                    case 1: form.NOM = list; break;
                    case 2: form.NOP = list; break;
                    case 3: form.NDD = list; break;
                    case 4: form.HIT = list; break;
                    case 5: form.CM = list; break;
                    case 6: form.WOC = list; break;
                    case 7: form.FDP = list; break;
                    case 8: form.AMW = list; break;
                    case 9: form.ATFD = list; break;
                }
            }
        }

    }
}