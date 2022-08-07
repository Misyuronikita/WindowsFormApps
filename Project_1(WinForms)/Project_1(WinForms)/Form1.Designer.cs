namespace Project_1_WinForms_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNote = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiData = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTime = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeleteAll = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            this.labelDo = new System.Windows.Forms.Label();
            this.buttonGeneration = new System.Windows.Forms.Button();
            this.labelOt = new System.Windows.Forms.Label();
            this.numericUpDownDo = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownOt = new System.Windows.Forms.NumericUpDown();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.rtbNotepad = new System.Windows.Forms.RichTextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelCount = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.bCreatePassword = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nudPassLEngth = new System.Windows.Forms.NumericUpDown();
            this.clbPassword = new System.Windows.Forms.CheckedListBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.bSwap = new System.Windows.Forms.Button();
            this.tbTo = new System.Windows.Forms.TextBox();
            this.tbFrom = new System.Windows.Forms.TextBox();
            this.bConvert = new System.Windows.Forms.Button();
            this.cbTo = new System.Windows.Forms.ComboBox();
            this.cbFrom = new System.Windows.Forms.ComboBox();
            this.menuStrip2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOt)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPassLEngth)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.tsmiNote,
            this.помощьToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(411, 30);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExit});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 26);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(136, 26);
            this.tsmiExit.Text = "Выход";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // tsmiNote
            // 
            this.tsmiNote.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiData,
            this.tsmiTime,
            this.toolStripMenuItem1,
            this.tsmiSave,
            this.tsmiSetup,
            this.tsmiDeleteAll});
            this.tsmiNote.Name = "tsmiNote";
            this.tsmiNote.Size = new System.Drawing.Size(80, 26);
            this.tsmiNote.Text = "Блокнот";
            // 
            // tsmiData
            // 
            this.tsmiData.Name = "tsmiData";
            this.tsmiData.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D)));
            this.tsmiData.Size = new System.Drawing.Size(291, 26);
            this.tsmiData.Text = "Вставить дату";
            this.tsmiData.Click += new System.EventHandler(this.tsmiData_Click);
            // 
            // tsmiTime
            // 
            this.tsmiTime.Name = "tsmiTime";
            this.tsmiTime.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.T)));
            this.tsmiTime.Size = new System.Drawing.Size(291, 26);
            this.tsmiTime.Text = "Вставить время";
            this.tsmiTime.Click += new System.EventHandler(this.tsmiTime_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(288, 6);
            // 
            // tsmiSave
            // 
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.tsmiSave.Size = new System.Drawing.Size(291, 26);
            this.tsmiSave.Text = "Сохранить";
            this.tsmiSave.Click += new System.EventHandler(this.tsmiSave_Click);
            // 
            // tsmiSetup
            // 
            this.tsmiSetup.Name = "tsmiSetup";
            this.tsmiSetup.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.tsmiSetup.Size = new System.Drawing.Size(291, 26);
            this.tsmiSetup.Text = "Загрузить";
            this.tsmiSetup.Click += new System.EventHandler(this.tsmiSetup_Click);
            // 
            // tsmiDeleteAll
            // 
            this.tsmiDeleteAll.Name = "tsmiDeleteAll";
            this.tsmiDeleteAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.tsmiDeleteAll.Size = new System.Drawing.Size(291, 26);
            this.tsmiDeleteAll.Text = "Стререть всё";
            this.tsmiDeleteAll.Click += new System.EventHandler(this.tsmiDeleteAll_Click);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout});
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(83, 26);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(187, 26);
            this.tsmiAbout.Text = "О программе";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 30);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(411, 365);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkOrchid;
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.labelOutput);
            this.tabPage2.Controls.Add(this.labelDo);
            this.tabPage2.Controls.Add(this.buttonGeneration);
            this.tabPage2.Controls.Add(this.labelOt);
            this.tabPage2.Controls.Add(this.numericUpDownDo);
            this.tabPage2.Controls.Add(this.numericUpDownOt);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(403, 336);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Генерация";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Случайное число:";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOutput.Location = new System.Drawing.Point(230, 253);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(24, 25);
            this.labelOutput.TabIndex = 4;
            this.labelOutput.Text = "0";
            this.labelOutput.Click += new System.EventHandler(this.labelOutput_Click);
            // 
            // labelDo
            // 
            this.labelDo.AutoSize = true;
            this.labelDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDo.Location = new System.Drawing.Point(265, 33);
            this.labelDo.Name = "labelDo";
            this.labelDo.Size = new System.Drawing.Size(34, 20);
            this.labelDo.TabIndex = 3;
            this.labelDo.Text = "До";
            // 
            // buttonGeneration
            // 
            this.buttonGeneration.BackColor = System.Drawing.Color.Chartreuse;
            this.buttonGeneration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGeneration.Location = new System.Drawing.Point(100, 131);
            this.buttonGeneration.Name = "buttonGeneration";
            this.buttonGeneration.Size = new System.Drawing.Size(212, 62);
            this.buttonGeneration.TabIndex = 2;
            this.buttonGeneration.Text = "Задать";
            this.buttonGeneration.UseVisualStyleBackColor = false;
            this.buttonGeneration.Click += new System.EventHandler(this.buttonGeneration_Click);
            // 
            // labelOt
            // 
            this.labelOt.AutoSize = true;
            this.labelOt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOt.Location = new System.Drawing.Point(46, 29);
            this.labelOt.Name = "labelOt";
            this.labelOt.Size = new System.Drawing.Size(34, 20);
            this.labelOt.TabIndex = 1;
            this.labelOt.Text = "От";
            this.labelOt.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // numericUpDownDo
            // 
            this.numericUpDownDo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.numericUpDownDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownDo.Location = new System.Drawing.Point(305, 31);
            this.numericUpDownDo.Name = "numericUpDownDo";
            this.numericUpDownDo.Size = new System.Drawing.Size(54, 26);
            this.numericUpDownDo.TabIndex = 0;
            this.numericUpDownDo.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownDo.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // numericUpDownOt
            // 
            this.numericUpDownOt.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.numericUpDownOt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownOt.Location = new System.Drawing.Point(86, 27);
            this.numericUpDownOt.Name = "numericUpDownOt";
            this.numericUpDownOt.Size = new System.Drawing.Size(54, 26);
            this.numericUpDownOt.TabIndex = 0;
            this.numericUpDownOt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.rtbNotepad);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(403, 336);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Блокнот";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // rtbNotepad
            // 
            this.rtbNotepad.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.rtbNotepad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbNotepad.Location = new System.Drawing.Point(0, 0);
            this.rtbNotepad.Name = "rtbNotepad";
            this.rtbNotepad.Size = new System.Drawing.Size(403, 336);
            this.rtbNotepad.TabIndex = 0;
            this.rtbNotepad.Text = "";
            this.rtbNotepad.TextChanged += new System.EventHandler(this.rtbNotepad_TextChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::Project_1_WinForms_.Properties.Resources._1636920753_5_bogatyr_club_p_fon_dlya_prilozheniya_5;
            this.tabPage1.Controls.Add(this.labelCount);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.buttonPlus);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(403, 336);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Кликер";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCount.Location = new System.Drawing.Point(286, 111);
            this.labelCount.Margin = new System.Windows.Forms.Padding(0);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(25, 29);
            this.labelCount.TabIndex = 3;
            this.labelCount.Text = "0";
            this.labelCount.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Coral;
            this.button1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(186, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 64);
            this.button1.TabIndex = 2;
            this.button1.Text = "Сброс";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.BackColor = System.Drawing.Color.Chartreuse;
            this.buttonPlus.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlus.Location = new System.Drawing.Point(36, 90);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(179, 70);
            this.buttonPlus.TabIndex = 1;
            this.buttonPlus.Text = "КЛИКАЙ!";
            this.buttonPlus.UseVisualStyleBackColor = false;
            this.buttonPlus.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BackgroundImage = global::Project_1_WinForms_.Properties.Resources.backgroundSky;
            this.tabPage4.Controls.Add(this.tbOutput);
            this.tabPage4.Controls.Add(this.bCreatePassword);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.nudPassLEngth);
            this.tabPage4.Controls.Add(this.clbPassword);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(403, 336);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Пароли";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tbOutput
            // 
            this.tbOutput.BackColor = System.Drawing.Color.HotPink;
            this.tbOutput.Location = new System.Drawing.Point(60, 288);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(286, 22);
            this.tbOutput.TabIndex = 4;
            this.tbOutput.TextChanged += new System.EventHandler(this.tbOutput_TextChanged);
            // 
            // bCreatePassword
            // 
            this.bCreatePassword.BackColor = System.Drawing.Color.DarkOrchid;
            this.bCreatePassword.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCreatePassword.Location = new System.Drawing.Point(108, 197);
            this.bCreatePassword.Name = "bCreatePassword";
            this.bCreatePassword.Size = new System.Drawing.Size(191, 71);
            this.bCreatePassword.TabIndex = 3;
            this.bCreatePassword.Text = "Создать пароль";
            this.bCreatePassword.UseVisualStyleBackColor = false;
            this.bCreatePassword.Click += new System.EventHandler(this.bCreatePassword_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.HotPink;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(56, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Длина пароля";
            // 
            // nudPassLEngth
            // 
            this.nudPassLEngth.BackColor = System.Drawing.Color.HotPink;
            this.nudPassLEngth.Location = new System.Drawing.Point(240, 150);
            this.nudPassLEngth.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.nudPassLEngth.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudPassLEngth.Name = "nudPassLEngth";
            this.nudPassLEngth.Size = new System.Drawing.Size(106, 22);
            this.nudPassLEngth.TabIndex = 1;
            this.nudPassLEngth.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudPassLEngth.ValueChanged += new System.EventHandler(this.nudPassLEngth_ValueChanged);
            // 
            // clbPassword
            // 
            this.clbPassword.BackColor = System.Drawing.Color.HotPink;
            this.clbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbPassword.CheckOnClick = true;
            this.clbPassword.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clbPassword.FormattingEnabled = true;
            this.clbPassword.Items.AddRange(new object[] {
            "Цифры",
            "Прописные буквы",
            "Строчные буквы",
            "Спец. символы %, *, (, ?, #, $, ^, &"});
            this.clbPassword.Location = new System.Drawing.Point(60, 21);
            this.clbPassword.Name = "clbPassword";
            this.clbPassword.Size = new System.Drawing.Size(286, 110);
            this.clbPassword.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.BackgroundImage = global::Project_1_WinForms_.Properties.Resources._32;
            this.tabPage5.Controls.Add(this.bSwap);
            this.tabPage5.Controls.Add(this.tbTo);
            this.tabPage5.Controls.Add(this.tbFrom);
            this.tabPage5.Controls.Add(this.bConvert);
            this.tabPage5.Controls.Add(this.cbTo);
            this.tabPage5.Controls.Add(this.cbFrom);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(403, 336);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Конвертация";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // bSwap
            // 
            this.bSwap.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bSwap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bSwap.Location = new System.Drawing.Point(147, 105);
            this.bSwap.Name = "bSwap";
            this.bSwap.Size = new System.Drawing.Size(109, 36);
            this.bSwap.TabIndex = 5;
            this.bSwap.Text = "⇄";
            this.bSwap.UseVisualStyleBackColor = false;
            this.bSwap.Click += new System.EventHandler(this.bSwap_Click_1);
            // 
            // tbTo
            // 
            this.tbTo.BackColor = System.Drawing.Color.PaleGreen;
            this.tbTo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbTo.Location = new System.Drawing.Point(286, 134);
            this.tbTo.Name = "tbTo";
            this.tbTo.ReadOnly = true;
            this.tbTo.Size = new System.Drawing.Size(100, 22);
            this.tbTo.TabIndex = 4;
            // 
            // tbFrom
            // 
            this.tbFrom.BackColor = System.Drawing.Color.PaleGreen;
            this.tbFrom.Location = new System.Drawing.Point(18, 134);
            this.tbFrom.Name = "tbFrom";
            this.tbFrom.Size = new System.Drawing.Size(100, 22);
            this.tbFrom.TabIndex = 3;
            this.tbFrom.Text = "1";
            // 
            // bConvert
            // 
            this.bConvert.BackColor = System.Drawing.Color.PaleGreen;
            this.bConvert.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bConvert.Location = new System.Drawing.Point(120, 221);
            this.bConvert.Name = "bConvert";
            this.bConvert.Size = new System.Drawing.Size(169, 61);
            this.bConvert.TabIndex = 2;
            this.bConvert.Text = "Конвертировать";
            this.bConvert.UseVisualStyleBackColor = false;
            this.bConvert.Click += new System.EventHandler(this.bConvert_Click);
            // 
            // cbTo
            // 
            this.cbTo.BackColor = System.Drawing.Color.PaleGreen;
            this.cbTo.FormattingEnabled = true;
            this.cbTo.Items.AddRange(new object[] {
            "mm",
            "cm",
            "dm",
            "m",
            "km"});
            this.cbTo.Location = new System.Drawing.Point(286, 80);
            this.cbTo.Name = "cbTo";
            this.cbTo.Size = new System.Drawing.Size(100, 24);
            this.cbTo.TabIndex = 1;
            this.cbTo.SelectedIndexChanged += new System.EventHandler(this.cbTo_SelectedIndexChanged);
            // 
            // cbFrom
            // 
            this.cbFrom.BackColor = System.Drawing.Color.PaleGreen;
            this.cbFrom.FormattingEnabled = true;
            this.cbFrom.Items.AddRange(new object[] {
            "mm",
            "cm",
            "dm",
            "m",
            "km"});
            this.cbFrom.Location = new System.Drawing.Point(18, 80);
            this.cbFrom.Name = "cbFrom";
            this.cbFrom.Size = new System.Drawing.Size(100, 24);
            this.cbFrom.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 395);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Мини-приложения";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOt)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPassLEngth)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Label labelDo;
        private System.Windows.Forms.Button buttonGeneration;
        private System.Windows.Forms.Label labelOt;
        private System.Windows.Forms.NumericUpDown numericUpDownDo;
        private System.Windows.Forms.NumericUpDown numericUpDownOt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ToolStripMenuItem tsmiNote;
        private System.Windows.Forms.ToolStripMenuItem tsmiData;
        private System.Windows.Forms.ToolStripMenuItem tsmiTime;
        private System.Windows.Forms.RichTextBox rtbNotepad;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiSave;
        private System.Windows.Forms.ToolStripMenuItem tsmiSetup;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteAll;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.CheckedListBox clbPassword;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Button bCreatePassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudPassLEngth;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox tbTo;
        private System.Windows.Forms.TextBox tbFrom;
        private System.Windows.Forms.Button bConvert;
        private System.Windows.Forms.ComboBox cbTo;
        private System.Windows.Forms.ComboBox cbFrom;
        private System.Windows.Forms.Button bSwap;
    }
}

