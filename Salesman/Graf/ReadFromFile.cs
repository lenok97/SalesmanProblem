using System;
using System.Windows.Forms;
using System.IO;

namespace Salesman
{
    public class ReadfromFile
    {
        static bool oriented = true;

        /// <summary>
        /// считывает граф из файла
        /// </summary>
        public static bool ReadText(string filename, RichTextBox textBox, DataGridView matrix)
        {
            string temp;
            StreamReader reader = null;
            try
            {
                reader = new StreamReader(filename);
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Ошибка:\n" + ex.Message));
                return oriented;
            };
            textBox.Text = "";
            int size=0;
            

            try
            {
                size = Convert.ToInt32(reader.ReadLine());
            }
            catch
            {
                MessageBox.Show(String.Format("Ошибка:\n" + "Первая строка файла неверно задаёт размер матрицы"));
                return oriented;
            }

            Form1.GrowMatrix(matrix, size);
            textBox.Text = size.ToString() + "\n";
            try
            {
                if (reader.ReadLine()=="false")
                {
                    oriented = false;
                    textBox.Text += "false" + "\n";
                }
                else
                {
                    oriented = true;
                    textBox.Text +="true" + "\n";
                }
            }
            catch
            {
                MessageBox.Show(String.Format("Ошибка:\n" + "Вторая строка файла неверно указывает, ориентирован ли граф"));
                return oriented;
            }



            if ((temp = reader.ReadLine()) != null && temp != "")
            {
                //если файл хранит список вершин
                if (temp.Contains(":"))
                {
                    textBox.Text += temp + "\n";
                    ReadList(temp, matrix);
                    while ((temp = reader.ReadLine()) != null && temp != "")
                    {
                        textBox.Text += temp + "\n";
                        ReadList(temp, matrix);
                    }
                }

                //если файл хранит пары вершин
                else
                {
                    textBox.Text += temp + "\n";
                    ReadPairs(temp, matrix);
                    while ((temp = reader.ReadLine()) != null && temp != "")
                    {
                        textBox.Text += temp + "\n";
                        ReadPairs(temp, matrix);
                    }
                }
            }

            return oriented;
        }

        /// <summary>
        /// разбивает строку на пары вершин
        /// </summary>
        static void ReadPairs(string pairs, DataGridView matrix)
        {
            pairs = pairs.Replace("(", string.Empty).Replace(")", string.Empty).Replace(",", string.Empty);
            string[] parameters = pairs.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            if (parameters.Length == 3)
            {
                try
                {
                    matrix.Rows[Convert.ToInt32(parameters[0]) - 1].
                        Cells[Convert.ToInt32(parameters[1]) - 1].Value = parameters[2];
                    if (!oriented)
                        matrix.Rows[Convert.ToInt32(parameters[1]) - 1].
                            Cells[Convert.ToInt32(parameters[0]) - 1].Value = parameters[2];
                }

                catch
                {
                    MessageBox.Show(String.Format("Недопустимый параметр '{0}'", pairs), "Ошибка чтения");
                    return;
                }
            }
            else
            {
                MessageBox.Show(String.Format("Недостаточно параметров: '{0}'", pairs), "Ошибка чтения");
                return;
            }
        }

        /// <summary>
        /// разбивает строку на список вершин
        /// </summary>
        static void ReadList(string list, DataGridView matrix)
        {
            list = list.Replace("(", string.Empty).Replace(")", string.Empty).Replace(",", string.Empty).Replace(":", string.Empty);
            string[] parameters = list.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            if (parameters.Length >= 3 && parameters.Length%2!=0)
            {
                try
                {
                    for (int i = 1; i < parameters.Length - 1; i += 2)
                    {
                        matrix.Rows[Convert.ToInt32(parameters[0]) - 1].
                            Cells[Convert.ToInt32(parameters[i]) - 1].Value = parameters[i+1];
                        if (!oriented)
                        {
                         matrix.Rows[Convert.ToInt32(parameters[i]) - 1].
                            Cells[Convert.ToInt32(parameters[0]) - 1].Value = parameters[i+1];
                        }
                    }
                }

                catch
                {
                    MessageBox.Show(String.Format("Недопустимый параметр '{0}'", list), "Ошибка чтения");
                    return;
                }
            }
            else
            {
                MessageBox.Show(String.Format("Недостаточно параметров: '{0}'", list), "Ошибка чтения");
                return;
            }
        }
    }
}
