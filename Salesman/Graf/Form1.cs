using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;

namespace Salesman
{
    public partial class Form1 : Form
    {
        static int columnWidth = 35;
        static int rowHeight = 20;
        string altformTip1 = "(номер_исх, номер_кон, вес)";
        string altformTip2 = "номер_исх: (номер_кон1, вес), (номер_кон2, вес), ...";
        string info1 = "Сохранение в виде: \nкол-во_вершин_графа \ntrue/false - ориентированный ли";
        string info2 = "Файл должен содержать: \nкол-во_вершин_графа \ntrue/false - ориентированный ли";
        int size;
        bool ifOriented=true;
        Tops tops;
        Salesman tsp;
        Path path;
        int populationSize = 100;
        int maxGenerations = 100;
        int groupSize = 10;
        int mutationChance = 10;
        int seed = 456;
        int chanceToUseCloseTop = 50;

        public Form1()
        {
            InitializeComponent();
            altType.SelectedIndex = 0;
            matrix.TopLeftHeaderCell.Value = "Вершина";
            matrix.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            oriented.Checked = true;
        }

        /// <summary>
        /// создание пустой матрицы под размеры графа
        /// </summary>
        public static void GrowMatrix(DataGridView matrix, int number)
        {
            matrix.Columns.Clear();
            matrix.ColumnCount = number;
            matrix.RowCount = number;
            for (int i = 0; i < number; i++)
            {
                matrix.Columns[i].HeaderText = (i + 1).ToString();
                matrix.Rows[i].HeaderCell.Value = string.Format((i + 1).ToString());
                matrix.Rows[i].Height = rowHeight;
                matrix.Columns[i].Width = columnWidth;
            }
        }

        void StartTsp()
        {
            tops.CalculateTopsEdges(size/3);
            path = tsp.Begin(populationSize, maxGenerations, groupSize, mutationChance, seed, chanceToUseCloseTop, tops);
        }

        private void startTSP_Click(object sender, EventArgs e)
        {
            salesmanPath.Text = " ";
            salesmanCost.Text = " ";
            topsNumber.Text = " ";

            if (matrix.ColumnCount == 0)
            {
                MessageBox.Show(String.Format("Граф не задан"), "Ошибка");
                return;
            }

            if (matrix.ColumnCount <= 1)
            {
                MessageBox.Show(String.Format("Вы на месте"), "Путь не нужен");
                return;
            }

            tsp = new Salesman();
            tops = new Tops();

            CopyToGraph();
            populationSize = 100;
            maxGenerations = 10;
            groupSize = 10;
            mutationChance = 10;
            seed = 256;
            chanceToUseCloseTop = 70;

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            StartTsp();
            stopWatch.Stop();
            ShowResults();
            totalTime.Text = stopWatch.Elapsed.TotalMilliseconds.ToString() + " млс.";
        }

        void CopyToGraph()
        {
            size = matrix.ColumnCount;
            for (int i = 0; i < size; i++)
                tops.Add(new Top());
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (Convert.ToInt32(matrix[i, j].Value) != 0)
                        tops[i].Edges.Add(Convert.ToInt32(matrix[i, j].Value));
                      
                    else
                    {
                        tops[i].Edges.Add(Int32.MaxValue);
                    }
                }
            }
        }

        void ShowResults()
        {
            salesmanPath.Text = " ";

            if (path.Fitness >= Int32.MaxValue)
            {
                salesmanPath.Text = "Пути нет";
                return;
            }

            int lasttop = 0;
            int nexttop = path[0].Connection1;

            for (int i = 0; i < path.Count; i++)
            {
                if (salesmanPath.Text.Contains(" " + (nexttop + 1).ToString() + " "))
                {
                    salesmanPath.Text += "Невероятная ошибка ";
                    return;
                }

                salesmanPath.Text += nexttop+1 + " ";
                
                if (lasttop != path[nexttop].Connection1)
                {
                    lasttop = nexttop;
                    nexttop = path[nexttop].Connection1;
                }
                else
                {
                    lasttop = nexttop;
                    nexttop = path[nexttop].Connection2;
                }

                matrix[nexttop, lasttop].Style.BackColor = Color.Silver;
            }

            salesmanPath.Text = salesmanPath.Text[salesmanPath.Text.Count() - 2] + salesmanPath.Text;
            salesmanCost.Text = Convert.ToString(tsp.population.BestPath.Fitness);
            topsNumber.Text = tsp.population.BestPath.Count.ToString();
        }

        /// <summary>
        /// Создать - создаёт таблицу указанного размера
        /// </summary>
        private void CreatButton_Click(object sender, EventArgs e)
        {
            try
            {
                size = Convert.ToInt32(textBox1.Text);
                GrowMatrix(matrix, Convert.ToInt32(textBox1.Text));
            }
            catch
            {
                MessageBox.Show("Задайте число вершин");
            }
        }

        /// <summary>
        /// Добавить - добавляет дугу с указанным весом
        /// </summary>
        private void addButton_Click(object sender, EventArgs e)
        {
            if (matrix.ColumnCount == 0)
            {
                CreatButton_Click(sender, e);
            }

            if (endPoint.Text == "" || startPoint.Text == "" || weight.Text == "")
            {
                MessageBox.Show("Заполните все поля");
                return;
            }

            if (Convert.ToInt32(startPoint.Text) < 1
                || Convert.ToInt32(startPoint.Text) > matrix.ColumnCount)
            {
                MessageBox.Show("Начальная вершина не принадлежит графу");
                return;
            }

            if (Convert.ToInt32(endPoint.Text) < 1
                || Convert.ToInt32(endPoint.Text) > matrix.ColumnCount)
            {
                MessageBox.Show("Конечная вершина не принадлежит графу");
                return;
            }

            //определение связи
            if (ifOriented)
            {
                matrix.Rows[Convert.ToInt32(startPoint.Text) - 1].
                    Cells[Convert.ToInt32(endPoint.Text) - 1].Value = weight.Text;
            }

            else
            {
                matrix.Rows[Convert.ToInt32(startPoint.Text) - 1].
                    Cells[Convert.ToInt32(endPoint.Text) - 1].Value = weight.Text;
                matrix.Rows[Convert.ToInt32(endPoint.Text) - 1].
                    Cells[Convert.ToInt32(startPoint.Text) - 1].Value = weight.Text;
            }
        }

        /// <summary>
        /// Пуск Альтернативный вид - выводит граф в альтернативном виде
        /// </summary>
        private void writeButton_Click(object sender, EventArgs e)
        {
            altForm.Text = matrix.Columns.Count + "\n";
            if (ifOriented)
                altForm.Text +="true"+ "\n";
            else altForm.Text += "false" + "\n";
            if (altType.SelectedIndex == 0)
            {
                for (int i = 0; i < matrix.ColumnCount; i++)
                    for (int j = 0; j < matrix.ColumnCount; j++)
                        if (matrix.Rows[i].Cells[j].Value != null)
                            altForm.Text += "(" + (i + 1).ToString() + ", " + (j + 1).ToString() + ", "
                            + matrix.Rows[i].Cells[j].Value + ")" + "\n";
            }

            if (altType.SelectedIndex == 1)
            {
                string temp;

                for (int i = 0; i < matrix.ColumnCount; i++)
                {
                    temp = "";
                    for (int j = 0; j < matrix.ColumnCount; j++)
                        if (matrix.Rows[i].Cells[j].Value != null)
                            temp +=
                            "(" + (j + 1).ToString() + ", " + matrix.Rows[i].Cells[j].Value + "), ";
                    if (temp != "")
                        altForm.Text += (i + 1).ToString() + ": " + temp + "\n";
                }
            }
        }

        /// <summary>
        /// В файл - сохраняет граф в выыбранном виде в файл
        /// </summary>
        private void saveAltForm_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                writeButton_Click(sender, e);
                SaveToFile.SaveText(saveFileDialog1.FileName, altForm);
            }
        }

        /// <summary>
        /// Выбрать файл - открывает диалоговое окно для выбора файла
        /// </summary>
        private void readButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            grafSource.Text = openFileDialog1.FileName;
            matrix.Columns.Clear();
            ifOriented=ReadfromFile.ReadText(openFileDialog1.FileName, altForm, matrix);
            oriented.Checked = ifOriented;
        }

        /// <summary>
        /// Читать - запускает чтение графа из файла
        /// </summary>
        private void startReadButton_Click(object sender, EventArgs e)
        {
            if (grafSource.Text == "")
            {
                readButton_Click(sender, e);
            }
        }

        private void справкаToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("\tЧтение из файла\n" + info2 + "\n" + altformTip1 + "...\nили\n" + altformTip2 + "...\n\n"
                + "\tЗапись в файл\n" + info1 + "\n" + altformTip1 + "...\nили\n" + altformTip2 + "..."), "Справка");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (altType.SelectedIndex == 0)
            {
                toolTipWriteFile.SetToolTip(saveAltForm, info1 + "\n" + altformTip1 + "...");
                toolTipAltForm.SetToolTip(altForm, altformTip1);
            }
            else
            {
                toolTipWriteFile.SetToolTip(saveAltForm, info1 + "\n" + altformTip2 + "...");
                toolTipAltForm.SetToolTip(altForm, altformTip2);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //проверка, что введены допустимые символы
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
            //// действие при нажатие Enter
            if (e.KeyChar == 13)
            {
                CreatButton_Click(sender, e);
                startPoint.Focus();
            }
        }

        private void startPoint_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
            //действие при нажатие Enter
            if (e.KeyChar == 13)
                endPoint.Focus();
        }

        private void weight_KeyPress(object sender, KeyPressEventArgs e)
        {
            //проверка, что введены допустимые символы
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
            // действие при нажатие Enter
            if (e.KeyChar == 13)
            {
                startPoint.Focus();
                addButton_Click(sender, e);
            }
        }

        private void endPoint_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
            // действие при нажатие Enter
            if (e.KeyChar == 13)
                weight.Focus();
        }

        private void from_KeyPress(object sender, KeyPressEventArgs e)
        {
            //проверка, что введены допустимые символы
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }


        private void maxWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            //проверка, что введены допустимые символы
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreatButton_Click(sender, e);
            Random rand = new Random();

            try
            {
                int maxW = Convert.ToInt32(maxWeight.Text);
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        matrix[i, j].Value = rand.Next(1, maxW);
                        if (!ifOriented)
                            matrix[j, i].Value = matrix[i, j].Value;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Введите параметр рендома правильно");
                return;
            }

        }
    }
}
