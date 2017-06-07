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
    class FileHandler
    {
        // получить пути к файлам из дисков напрямую
        public string[][] GetFiles(string[] ArrayWithCheckedTypes, string[] DrivesForCleaning)
        {
            //массив путей к файлам файлов
            string[][] files = new string[ArrayWithCheckedTypes.Length][];
            
            for (int i = 0; i < DrivesForCleaning.Length; i++)
            {
                string[] directiories = Directory.GetDirectories(DrivesForCleaning[i]);
                
                for (int j = 0; j < directiories.Length; j++)
                {
                    for (int k = 0; k < ArrayWithCheckedTypes.Length; k++)
                    {
                        try
                        {
                            files[k] = Directory.GetFiles(directiories[j], ArrayWithCheckedTypes[k], SearchOption.AllDirectories);
                        }
                        catch (UnauthorizedAccessException exc) { break; }
                        catch (PathTooLongException exc) { break; }
                    }
                }
            }
            return files;
        }

        // получить путь к файлам с указанной директории
        public string[][] GetFiles(string[] ArrayWithCheckedTypes, string path)
        {
            string[][] files = new string[ArrayWithCheckedTypes.Length][];
            for (int i = 0; i < ArrayWithCheckedTypes.Length; i++)
            {
                try
                {
                    files[i] = Directory.GetFiles(path, ArrayWithCheckedTypes[i], SearchOption.AllDirectories);
                }
                catch (UnauthorizedAccessException exc) { }
                catch (PathTooLongException exc) { }
            }
            return files;
        }

        //получить размеры файлов
        public double[][] GetFilesSize(string[][] files)
        {
            double[][] filesizes = new double[files.Length][];
            FileInfo FileInfo;
            for (int i = 0; i < files.Length; i++)
            {
                filesizes[i] = new double[files[i].Length];
                for (int j = 0; j < files[i].Length; j++)
                {
                    FileInfo = new FileInfo(files[i][j]);
                    filesizes[i][j] = FileInfo.Length;
                }
            }
            return filesizes;
        }

        //удалить файлы БЕЗ ПРЕДОСМОТРА (ВСЕ НАЙДЕННЫЕ)
        public void DeleteFiles(string[][] files)
        {
            double[][] sizes = GetFilesSize(files);
            double size=0, count=0;
             for (int i = 0; i < files.Length; i++)
                 for (int j = 0; j < files[i].Length; j++)
                 {
                     size += sizes[i][j];
                     count++;
                     //        if (files[i][j] != "")
                     //            File.Delete(files[i][j]);                     
                 }
             ReleaseArray(files);
             MessageBox.Show("Файлы удалены успешно!\r\n Размер: " + size+ " Количество: " + count);
        }

        // очистить массив путей
        public void ReleaseArray(string[][] files)
        {
            for (int i = 0; i < files.Length; i++)
                for (int j = 0; j < files[i].Length; j++)
                    Array.Resize(ref files[i], 0);
        }

        // вывод полученных данных на форму
        public void OutFiles(DataGridView Dt, string[][] files)
        {
            double[][] sizes = GetFilesSize(files);

            ResetDtgrdVw(Dt);
            int counter = 0;
            for (int i = 0; i < files.Length; i++)
            {
                int j = 0, pr = files[i].Length; 

                while (pr-- > 0)
                {
                    Dt.Rows.Add();
                    Dt.Rows[counter].Cells[1].Value = (counter + 1).ToString();
                    Dt.Rows[counter].Cells[2].Value = files[i][j];
                    Dt.Rows[counter].Cells[3].Value = sizes[i][j] + " bytes";
                    counter++;
                    j++;
                }                
            }
        }
        
        //очитска формы от данных
        public void ResetDtgrdVw(DataGridView D)
        {
            D.Rows.Clear();
            D.Refresh();
            while (D.Rows.Count != 0)
                D.Rows.Remove(D.Rows[D.Rows.Count - 1]);
        }

        //обработка выборщика расширений
        public void checkcheck(ref string[] CheckedTemp, CheckBox CBDefault, CheckBox CurrentCB, string pattern)
        {
            CBDefault.Checked = false;
            if (stringcontrol(CheckedTemp,pattern) == true)
            {
                Array.Resize(ref CheckedTemp, CheckedTemp.Length + 1);
                CheckedTemp[CheckedTemp.Length - 1] = pattern;
            }
        }


        // проверка: есть ли УЖЕ данное расширение в массиве расширений
        public bool stringcontrol(string[] mas, string pattern)
        {
            for (int i = 0; i < mas.Length; i++)
                if (mas[i] == pattern) return false;
            return true;
        }
    }
}
