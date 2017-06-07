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
    public partial class Form1 : Form
    {
        FileHandler FileHandler = new FileHandler();
        DrivesFinder DrFind = new DrivesFinder();
        string[][] files;
        string[] DrivesForCleaning = new string[0];
        string[] CheckedTemp = new string[0];
        string[] AllTemp = new string[] { "*.tmp", "*.temp", "*.iff", "*.asx", 
                                          "*.xps", "*.inf" , "*.dat", "~*"    };
        public Form1()
        {
            InitializeComponent();
            DrFind.GetReadyDrives(dataGridView1);            
        }
        private void checkBoxtmp_MouseClick(object sender, MouseEventArgs e)
        {
            checkBoxDefault.Checked = false;
            Array.Resize(ref CheckedTemp, CheckedTemp.Length + 1);
            CheckedTemp[CheckedTemp.Length - 1] = "*.tmp";
        }

        private void CleaningButton_Click(object sender, EventArgs e)
        {
            try
            {
                // диски, в которых следует провести поиск и очистку
                DrivesForCleaning = DrFind.GetCheckedDrives(dataGridView1);

                //массив путей к файлам 
                files = FileHandler.GetFiles(selectTypes(), DrivesForCleaning);

                if (checkBoxShowInfo.Checked)
                {
                    Form2 form2 = new Form2(files);
                    form2.Show();
                }
                else
                {
                    FileHandler.DeleteFiles(files);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    //массив путей к файлам
                    files = FileHandler.GetFiles(selectTypes(), folderBrowserDialog1.SelectedPath);

                    if (checkBoxShowInfo.Checked)
                    {
                        Form2 form2 = new Form2(files);
                        form2.Show();
                    }
                    else
                    {
                        FileHandler.DeleteFiles(files);
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            
        }

        // проверка выбранных расширений
        string[] selectTypes()
        {
            if (checkBoxDefault.Checked)
                return AllTemp;
            return CheckedTemp;
        }

        ///////////////////////////////////////////////////////////////////
        //// ОБРАБОТКА РАСШИРЕНИЙ В ЧЕКБОКСАХ   ///////////////////////////
        ///////////////////////////////////////////////////////////////////
        private void checkBoxtmp_MouseClick_1(object sender, MouseEventArgs e)
        {
            FileHandler.checkcheck(ref CheckedTemp, checkBoxDefault, checkBoxtmp, "*.tmp");
        }

        private void checkBoxtemp_MouseClick(object sender, MouseEventArgs e)
        {
            FileHandler.checkcheck(ref CheckedTemp, checkBoxDefault, checkBoxtemp, "*.temp");
        }

        private void checkBoxiff_MouseClick(object sender, MouseEventArgs e)
        {
            FileHandler.checkcheck(ref CheckedTemp, checkBoxDefault, checkBoxiff, "*.iff");
        }

        private void checkBoxasx_MouseClick(object sender, MouseEventArgs e)
        {
            FileHandler.checkcheck(ref CheckedTemp, checkBoxDefault, checkBoxasx, "*.asx");
        }

        private void checkBoxxps_MouseClick(object sender, MouseEventArgs e)
        {
            FileHandler.checkcheck(ref CheckedTemp, checkBoxDefault, checkBoxxps, "*.xps");
        }

        private void checkBoxinf_MouseClick(object sender, MouseEventArgs e)
        {
            FileHandler.checkcheck(ref CheckedTemp, checkBoxDefault, checkBoxinf, "*.inf");
        }

        private void checkBoxdat_MouseClick(object sender, MouseEventArgs e)
        {
            FileHandler.checkcheck(ref CheckedTemp, checkBoxDefault, checkBoxdat, "*.dat");
        }

        private void checkBoxt_MouseClick(object sender, MouseEventArgs e)
        {
            FileHandler.checkcheck(ref CheckedTemp, checkBoxDefault, checkBoxt, "~*");
        }

        int clickcounter = 0;
        private void checkBoxDefault_MouseClick(object sender, MouseEventArgs e)
        {
            clickcounter++;
            if (clickcounter % 2 != 0)
            {
                checkBoxtemp.Enabled = false;
                checkBoxasx.Enabled = false;
                checkBoxdat.Enabled = false;
                checkBoxinf.Enabled = false;
                checkBoxiff.Enabled = false;
                checkBoxtmp.Enabled = false;
                checkBoxxps.Enabled = false;
                checkBoxt.Enabled = false;
            }
            else
            {
                checkBoxtemp.Enabled = true;
                checkBoxasx.Enabled = true;
                checkBoxdat.Enabled = true;
                checkBoxinf.Enabled = true;
                checkBoxiff.Enabled = true;
                checkBoxtmp.Enabled = true;
                checkBoxxps.Enabled = true;
                checkBoxt.Enabled = true;
            }
        }

        private void оРазработчикеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Приложение разработал студент группы 632п Турянский А.О", "О разработчике", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. На главной форме во вкладке 'Где чистить' отметьте\r\nлогические диски, в которых нужно провести очистку.\r\n2. Во вкладке 'Что чистить' укажите необходимые расширения.\r\n3. Нажмите кнопку 'Выполнить очистку!'\r\nЕсли нужно получить список файлов или провести очистку в указанной директории, обратитесь к вкладке 'Спец. функции'\r\n", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}