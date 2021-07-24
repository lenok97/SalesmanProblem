namespace Salesman
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.matrix = new System.Windows.Forms.DataGridView();
            this.altForm = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.saveAltForm = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.writeButton = new System.Windows.Forms.Button();
            this.altType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolTipAltForm = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTipReadFile = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipWriteFile = new System.Windows.Forms.ToolTip(this.components);
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.topsNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.salesmanCost = new System.Windows.Forms.TextBox();
            this.totalTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.salesmanPath = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.startSalesman = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.maxWeight = new System.Windows.Forms.TextBox();
            this.rendomCreate = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.grafSource = new System.Windows.Forms.TextBox();
            this.readButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.fileSource = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.weight = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.startPoint = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.endPoint = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.CreatButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.oriented = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.matrix)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // matrix
            // 
            this.matrix.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.matrix.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.matrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrix.Location = new System.Drawing.Point(23, 351);
            this.matrix.Margin = new System.Windows.Forms.Padding(4);
            this.matrix.Name = "matrix";
            this.matrix.ReadOnly = true;
            this.matrix.RowHeadersWidth = 42;
            this.matrix.Size = new System.Drawing.Size(859, 358);
            this.matrix.TabIndex = 3;
            // 
            // altForm
            // 
            this.altForm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.altForm.Location = new System.Drawing.Point(15, 318);
            this.altForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.altForm.Name = "altForm";
            this.altForm.ReadOnly = true;
            this.altForm.Size = new System.Drawing.Size(421, 353);
            this.altForm.TabIndex = 15;
            this.altForm.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.saveAltForm);
            this.groupBox2.Controls.Add(this.altForm);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Location = new System.Drawing.Point(888, 33);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(443, 676);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Альтернативный вид";
            // 
            // saveAltForm
            // 
            this.saveAltForm.Image = ((System.Drawing.Image)(resources.GetObject("saveAltForm.Image")));
            this.saveAltForm.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveAltForm.Location = new System.Drawing.Point(12, 268);
            this.saveAltForm.Margin = new System.Windows.Forms.Padding(4);
            this.saveAltForm.Name = "saveAltForm";
            this.saveAltForm.Size = new System.Drawing.Size(187, 41);
            this.saveAltForm.TabIndex = 17;
            this.saveAltForm.Text = "Сохранить граф";
            this.saveAltForm.UseVisualStyleBackColor = true;
            this.saveAltForm.Click += new System.EventHandler(this.saveAltForm_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.writeButton);
            this.panel1.Controls.Add(this.altType);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(12, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 236);
            this.panel1.TabIndex = 18;
            // 
            // writeButton
            // 
            this.writeButton.Image = ((System.Drawing.Image)(resources.GetObject("writeButton.Image")));
            this.writeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.writeButton.Location = new System.Drawing.Point(168, 82);
            this.writeButton.Margin = new System.Windows.Forms.Padding(4);
            this.writeButton.Name = "writeButton";
            this.writeButton.Size = new System.Drawing.Size(145, 41);
            this.writeButton.TabIndex = 15;
            this.writeButton.Text = "Пуск";
            this.writeButton.UseVisualStyleBackColor = true;
            this.writeButton.Click += new System.EventHandler(this.writeButton_Click);
            // 
            // altType
            // 
            this.altType.FormattingEnabled = true;
            this.altType.Items.AddRange(new object[] {
            "Пары вершин",
            "Список"});
            this.altType.Location = new System.Drawing.Point(153, 39);
            this.altType.Margin = new System.Windows.Forms.Padding(4);
            this.altType.Name = "altType";
            this.altType.Size = new System.Drawing.Size(160, 24);
            this.altType.TabIndex = 16;
            this.altType.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 42);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Вид представления";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = ".txt";
            this.saveFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            this.saveFileDialog1.Title = "Сохранить";
            // 
            // toolTipAltForm
            // 
            this.toolTipAltForm.Tag = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1331, 28);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("справкаToolStripMenuItem.Image")));
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click_1);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.topsNumber);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.salesmanCost);
            this.tabPage4.Controls.Add(this.totalTime);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.salesmanPath);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.startSalesman);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage4.Size = new System.Drawing.Size(855, 280);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Найти маршрут";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(211, 246);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "Посещено вершин:";
            // 
            // topsNumber
            // 
            this.topsNumber.Location = new System.Drawing.Point(352, 243);
            this.topsNumber.Margin = new System.Windows.Forms.Padding(4);
            this.topsNumber.Name = "topsNumber";
            this.topsNumber.ReadOnly = true;
            this.topsNumber.Size = new System.Drawing.Size(130, 22);
            this.topsNumber.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Вес цикла:";
            // 
            // salesmanCost
            // 
            this.salesmanCost.Location = new System.Drawing.Point(24, 243);
            this.salesmanCost.Margin = new System.Windows.Forms.Padding(4);
            this.salesmanCost.Name = "salesmanCost";
            this.salesmanCost.ReadOnly = true;
            this.salesmanCost.Size = new System.Drawing.Size(130, 22);
            this.salesmanCost.TabIndex = 11;
            // 
            // totalTime
            // 
            this.totalTime.Enabled = false;
            this.totalTime.Location = new System.Drawing.Point(382, 39);
            this.totalTime.Margin = new System.Windows.Forms.Padding(4);
            this.totalTime.Name = "totalTime";
            this.totalTime.ReadOnly = true;
            this.totalTime.Size = new System.Drawing.Size(125, 22);
            this.totalTime.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Время работы алгоритма";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 144);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 17);
            this.label11.TabIndex = 8;
            this.label11.Text = "Гамильтонов цикл:";
            // 
            // salesmanPath
            // 
            this.salesmanPath.Location = new System.Drawing.Point(24, 165);
            this.salesmanPath.Margin = new System.Windows.Forms.Padding(4);
            this.salesmanPath.Multiline = true;
            this.salesmanPath.Name = "salesmanPath";
            this.salesmanPath.ReadOnly = true;
            this.salesmanPath.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.salesmanPath.Size = new System.Drawing.Size(723, 50);
            this.salesmanPath.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(369, 51);
            this.label9.TabIndex = 5;
            this.label9.Text = "Маршрут минимальной длины, \r\nкоторый проходит через все вершины графа \r\nровно оди" +
    "н раз и возвращается в стартовую вершину.";
            // 
            // startSalesman
            // 
            this.startSalesman.Image = ((System.Drawing.Image)(resources.GetObject("startSalesman.Image")));
            this.startSalesman.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.startSalesman.Location = new System.Drawing.Point(29, 27);
            this.startSalesman.Margin = new System.Windows.Forms.Padding(4);
            this.startSalesman.Name = "startSalesman";
            this.startSalesman.Size = new System.Drawing.Size(145, 41);
            this.startSalesman.TabIndex = 3;
            this.startSalesman.Text = "Старт";
            this.startSalesman.UseVisualStyleBackColor = true;
            this.startSalesman.Click += new System.EventHandler(this.startTSP_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.fileSource);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(855, 280);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Задать граф";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.maxWeight);
            this.groupBox5.Controls.Add(this.rendomCreate);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Location = new System.Drawing.Point(618, 19);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(231, 217);
            this.groupBox5.TabIndex = 26;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Рендомно создать рёбра";
            // 
            // maxWeight
            // 
            this.maxWeight.Location = new System.Drawing.Point(20, 72);
            this.maxWeight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maxWeight.Name = "maxWeight";
            this.maxWeight.Size = new System.Drawing.Size(144, 22);
            this.maxWeight.TabIndex = 19;
            this.maxWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maxWeight_KeyPress);
            // 
            // rendomCreate
            // 
            this.rendomCreate.Image = global::Graf.Properties.Resources.rand;
            this.rendomCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rendomCreate.Location = new System.Drawing.Point(20, 112);
            this.rendomCreate.Margin = new System.Windows.Forms.Padding(4);
            this.rendomCreate.Name = "rendomCreate";
            this.rendomCreate.Size = new System.Drawing.Size(144, 41);
            this.rendomCreate.TabIndex = 21;
            this.rendomCreate.Text = "Создать";
            this.rendomCreate.UseVisualStyleBackColor = true;
            this.rendomCreate.Click += new System.EventHandler(this.button1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 17);
            this.label12.TabIndex = 22;
            this.label12.Text = "Максимальный вес ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.grafSource);
            this.groupBox3.Controls.Add(this.readButton);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(396, 19);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(216, 217);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Из файла";
            // 
            // grafSource
            // 
            this.grafSource.Location = new System.Drawing.Point(20, 75);
            this.grafSource.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grafSource.Name = "grafSource";
            this.grafSource.ReadOnly = true;
            this.grafSource.Size = new System.Drawing.Size(144, 22);
            this.grafSource.TabIndex = 19;
            // 
            // readButton
            // 
            this.readButton.Image = ((System.Drawing.Image)(resources.GetObject("readButton.Image")));
            this.readButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.readButton.Location = new System.Drawing.Point(20, 112);
            this.readButton.Margin = new System.Windows.Forms.Padding(4);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(189, 41);
            this.readButton.TabIndex = 21;
            this.readButton.Text = "Выбрать файл";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new System.EventHandler(this.readButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Источник";
            // 
            // fileSource
            // 
            this.fileSource.AutoSize = true;
            this.fileSource.Location = new System.Drawing.Point(115, 238);
            this.fileSource.Name = "fileSource";
            this.fileSource.Size = new System.Drawing.Size(0, 17);
            this.fileSource.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.weight);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.addButton);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.startPoint);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.endPoint);
            this.groupBox1.Location = new System.Drawing.Point(4, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(385, 215);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Задать граф";
            // 
            // weight
            // 
            this.weight.Location = new System.Drawing.Point(117, 187);
            this.weight.Margin = new System.Windows.Forms.Padding(4);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(92, 22);
            this.weight.TabIndex = 14;
            this.weight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.weight_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 190);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Вес";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Начало";
            // 
            // addButton
            // 
            this.addButton.Image = ((System.Drawing.Image)(resources.GetObject("addButton.Image")));
            this.addButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addButton.Location = new System.Drawing.Point(227, 144);
            this.addButton.Margin = new System.Windows.Forms.Padding(4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(145, 41);
            this.addButton.TabIndex = 12;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // startPoint
            // 
            this.startPoint.Location = new System.Drawing.Point(117, 121);
            this.startPoint.Margin = new System.Windows.Forms.Padding(4);
            this.startPoint.Name = "startPoint";
            this.startPoint.Size = new System.Drawing.Size(92, 22);
            this.startPoint.TabIndex = 7;
            this.startPoint.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.startPoint_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 156);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Конец";
            // 
            // endPoint
            // 
            this.endPoint.Location = new System.Drawing.Point(117, 153);
            this.endPoint.Margin = new System.Windows.Forms.Padding(4);
            this.endPoint.Name = "endPoint";
            this.endPoint.Size = new System.Drawing.Size(92, 22);
            this.endPoint.TabIndex = 9;
            this.endPoint.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.endPoint_KeyPress);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.CreatButton);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.oriented);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(0, 15);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(406, 82);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            // 
            // CreatButton
            // 
            this.CreatButton.Image = ((System.Drawing.Image)(resources.GetObject("CreatButton.Image")));
            this.CreatButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CreatButton.Location = new System.Drawing.Point(227, 21);
            this.CreatButton.Margin = new System.Windows.Forms.Padding(4);
            this.CreatButton.Name = "CreatButton";
            this.CreatButton.Size = new System.Drawing.Size(145, 41);
            this.CreatButton.TabIndex = 14;
            this.CreatButton.Text = "  Создать";
            this.CreatButton.UseVisualStyleBackColor = true;
            this.CreatButton.Click += new System.EventHandler(this.CreatButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 14);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(92, 22);
            this.textBox1.TabIndex = 5;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // oriented
            // 
            this.oriented.AutoSize = true;
            this.oriented.Location = new System.Drawing.Point(7, 42);
            this.oriented.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.oriented.Name = "oriented";
            this.oriented.Size = new System.Drawing.Size(153, 21);
            this.oriented.TabIndex = 15;
            this.oriented.Text = "Ориентированный";
            this.oriented.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Число вершин";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(19, 33);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(863, 309);
            this.tabControl1.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 99);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(169, 17);
            this.label13.TabIndex = 17;
            this.label13.Text = "В ручную создать ребро";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1331, 713);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.matrix);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1349, 760);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Задача коммивояжёра";
            ((System.ComponentModel.ISupportInitialize)(this.matrix)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView matrix;
        private System.Windows.Forms.RichTextBox altForm;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox altType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button saveAltForm;
        private System.Windows.Forms.Button writeButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolTip toolTipAltForm;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTipReadFile;
        private System.Windows.Forms.ToolTip toolTipWriteFile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox salesmanPath;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button startSalesman;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox weight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox startPoint;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox endPoint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button CreatButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.CheckBox oriented;
        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.Label fileSource;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox grafSource;
        private System.Windows.Forms.TextBox totalTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox salesmanCost;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox topsNumber;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox maxWeight;
        private System.Windows.Forms.Button rendomCreate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}

