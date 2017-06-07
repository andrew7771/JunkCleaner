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
    public partial class Form2 : Form
    {
        FileHandler FileHandler = new FileHandler();
        string[][] files;

        public Form2(string[][] files)
        {
            InitializeComponent();
            this.files = files;
            FileHandler.OutFiles(dataGridView1, files);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] pathes = new string[0];
            double size = 0;
            int count = 0;

            int i = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewCheckBoxCell cell = row.Cells[0] as DataGridViewCheckBoxCell;

                if (cell.Value != null)
                {
                    if ((Boolean)cell.Value)
                    {
                        count++;
                        Array.Resize(ref pathes, pathes.Length + 1);
                        pathes[pathes.Length - 1] = dataGridView1.Rows[i].Cells[2].Value.ToString();
                        string tmp = dataGridView1.Rows[i].Cells[3].Value.ToString();
                        tmp = tmp.Substring(0, tmp.IndexOf(' '));
                        size += double.Parse(tmp);
                        dataGridView1.Rows[i].Visible = false;
                    }
                }
                i++;
            }

            //for (int i = 0; i < pathes.Length; i++)
            //    File.Delete(pathes[i]);

            MessageBox.Show("Файлы удалены успешно!\r\n Размер: " + size + " Количество: " + count);
        }
    }
}
