using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    class DrivesFinder
    {
        //список всех логических носителей
        DriveInfo[] Drives = DriveInfo.GetDrives();

        //массив доступных носителй
        DriveInfo[] ReadyDrives = new DriveInfo[0];

        //функция, которая возвращает массив из доступных носителей
        public DriveInfo[] GetReadyDrives(DataGridView DtGrdVw)
        {
            for (int i = 0; i < Drives.Length; i++)
            {
                if (Drives[i].IsReady == true)
                {
                    //записываем логический диск в массив, если он доступен
                    Array.Resize(ref ReadyDrives, ReadyDrives.Length + 1);
                    ReadyDrives[ReadyDrives.Length - 1] = Drives[i];

                    //записываем лог. диск в колонки, если он доступен
                    DtGrdVw.Rows.Add();
                    DtGrdVw.Rows[i].Cells[1].Value = Drives[i];
                    if (Drives[i].VolumeLabel == "")
                    {
                        DtGrdVw.Rows[i].Cells[1].Value += " (Локальный диск)";
                        continue;
                    }
                    DtGrdVw.Rows[i].Cells[1].Value += " (" + Drives[i].VolumeLabel + ")";
                }
            }
            return ReadyDrives;
        }

        //функция, которая среди доступных носителей находит выбранные
        public string[] GetCheckedDrives(DataGridView DtGrdVw)
        {
            string[] CheckedDrives = new string[0];
            string tmp = "";
            int i = 0;
            foreach (DataGridViewRow row in DtGrdVw.Rows)
            {                
                DataGridViewCheckBoxCell cell = row.Cells[0] as DataGridViewCheckBoxCell;

                if (cell.Value != null)
                {
                    //если лог.диск доступен и выбран, то записываем его
                    if ((Boolean)cell.Value)
                    {
                        Array.Resize(ref CheckedDrives, CheckedDrives.Length + 1);
                        tmp = (string)DtGrdVw.Rows[i].Cells[1].Value;
                        tmp = tmp.Substring(0,3);
                        CheckedDrives[CheckedDrives.Length - 1] = tmp;                        
                    }
                }
                i++;
            }
            return CheckedDrives;            
        }
    }
}