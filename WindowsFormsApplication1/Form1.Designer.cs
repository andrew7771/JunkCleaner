namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CheckedDrives = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ReadyDrives = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxDefault = new System.Windows.Forms.CheckBox();
            this.checkBoxt = new System.Windows.Forms.CheckBox();
            this.checkBoxasx = new System.Windows.Forms.CheckBox();
            this.checkBoxdat = new System.Windows.Forms.CheckBox();
            this.checkBoxiff = new System.Windows.Forms.CheckBox();
            this.checkBoxtmp = new System.Windows.Forms.CheckBox();
            this.checkBoxxps = new System.Windows.Forms.CheckBox();
            this.checkBoxinf = new System.Windows.Forms.CheckBox();
            this.checkBoxtemp = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.checkBoxShowInfo = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.оРазработчикеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.CleaningButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(20, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(340, 155);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(332, 129);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Где чистить?";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckedDrives,
            this.ReadyDrives});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(326, 123);
            this.dataGridView1.TabIndex = 0;
            // 
            // CheckedDrives
            // 
            this.CheckedDrives.FillWeight = 39.59391F;
            this.CheckedDrives.HeaderText = "Отметка";
            this.CheckedDrives.Name = "CheckedDrives";
            this.CheckedDrives.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CheckedDrives.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ReadyDrives
            // 
            this.ReadyDrives.FillWeight = 160.4061F;
            this.ReadyDrives.HeaderText = "Логические диски";
            this.ReadyDrives.Name = "ReadyDrives";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(332, 129);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Что чистить?";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxDefault);
            this.groupBox1.Controls.Add(this.checkBoxt);
            this.groupBox1.Controls.Add(this.checkBoxasx);
            this.groupBox1.Controls.Add(this.checkBoxdat);
            this.groupBox1.Controls.Add(this.checkBoxiff);
            this.groupBox1.Controls.Add(this.checkBoxtmp);
            this.groupBox1.Controls.Add(this.checkBoxxps);
            this.groupBox1.Controls.Add(this.checkBoxinf);
            this.groupBox1.Controls.Add(this.checkBoxtemp);
            this.groupBox1.Location = new System.Drawing.Point(16, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 224);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите расширения файлов для очистки:";
            // 
            // checkBoxDefault
            // 
            this.checkBoxDefault.AutoSize = true;
            this.checkBoxDefault.Checked = true;
            this.checkBoxDefault.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDefault.Location = new System.Drawing.Point(205, 19);
            this.checkBoxDefault.Name = "checkBoxDefault";
            this.checkBoxDefault.Size = new System.Drawing.Size(99, 30);
            this.checkBoxDefault.TabIndex = 8;
            this.checkBoxDefault.Text = "По умолчанию\r\n(всё)";
            this.checkBoxDefault.UseVisualStyleBackColor = true;
            this.checkBoxDefault.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkBoxDefault_MouseClick);
            // 
            // checkBoxt
            // 
            this.checkBoxt.AutoSize = true;
            this.checkBoxt.Location = new System.Drawing.Point(117, 88);
            this.checkBoxt.Name = "checkBoxt";
            this.checkBoxt.Size = new System.Drawing.Size(37, 17);
            this.checkBoxt.TabIndex = 7;
            this.checkBoxt.Text = "~*";
            this.checkBoxt.UseVisualStyleBackColor = true;
            this.checkBoxt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkBoxt_MouseClick);
            // 
            // checkBoxasx
            // 
            this.checkBoxasx.AutoSize = true;
            this.checkBoxasx.Location = new System.Drawing.Point(6, 88);
            this.checkBoxasx.Name = "checkBoxasx";
            this.checkBoxasx.Size = new System.Drawing.Size(45, 17);
            this.checkBoxasx.TabIndex = 6;
            this.checkBoxasx.Text = ".asx";
            this.checkBoxasx.UseVisualStyleBackColor = true;
            this.checkBoxasx.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkBoxasx_MouseClick);
            // 
            // checkBoxdat
            // 
            this.checkBoxdat.AutoSize = true;
            this.checkBoxdat.Location = new System.Drawing.Point(117, 65);
            this.checkBoxdat.Name = "checkBoxdat";
            this.checkBoxdat.Size = new System.Drawing.Size(44, 17);
            this.checkBoxdat.TabIndex = 5;
            this.checkBoxdat.Text = ".dat";
            this.checkBoxdat.UseVisualStyleBackColor = true;
            this.checkBoxdat.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkBoxdat_MouseClick);
            // 
            // checkBoxiff
            // 
            this.checkBoxiff.AutoSize = true;
            this.checkBoxiff.Location = new System.Drawing.Point(7, 65);
            this.checkBoxiff.Name = "checkBoxiff";
            this.checkBoxiff.Size = new System.Drawing.Size(37, 17);
            this.checkBoxiff.TabIndex = 4;
            this.checkBoxiff.Text = ".iff";
            this.checkBoxiff.UseVisualStyleBackColor = true;
            this.checkBoxiff.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkBoxiff_MouseClick);
            // 
            // checkBoxtmp
            // 
            this.checkBoxtmp.AutoSize = true;
            this.checkBoxtmp.Location = new System.Drawing.Point(6, 19);
            this.checkBoxtmp.Name = "checkBoxtmp";
            this.checkBoxtmp.Size = new System.Drawing.Size(46, 17);
            this.checkBoxtmp.TabIndex = 0;
            this.checkBoxtmp.Text = ".tmp";
            this.checkBoxtmp.UseVisualStyleBackColor = true;
            this.checkBoxtmp.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkBoxtmp_MouseClick_1);
            // 
            // checkBoxxps
            // 
            this.checkBoxxps.AutoSize = true;
            this.checkBoxxps.Location = new System.Drawing.Point(116, 19);
            this.checkBoxxps.Name = "checkBoxxps";
            this.checkBoxxps.Size = new System.Drawing.Size(45, 17);
            this.checkBoxxps.TabIndex = 1;
            this.checkBoxxps.Text = ".xps";
            this.checkBoxxps.UseVisualStyleBackColor = true;
            this.checkBoxxps.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkBoxxps_MouseClick);
            // 
            // checkBoxinf
            // 
            this.checkBoxinf.AutoSize = true;
            this.checkBoxinf.Location = new System.Drawing.Point(116, 42);
            this.checkBoxinf.Name = "checkBoxinf";
            this.checkBoxinf.Size = new System.Drawing.Size(40, 17);
            this.checkBoxinf.TabIndex = 3;
            this.checkBoxinf.Text = ".inf";
            this.checkBoxinf.UseVisualStyleBackColor = true;
            this.checkBoxinf.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkBoxinf_MouseClick);
            // 
            // checkBoxtemp
            // 
            this.checkBoxtemp.AutoSize = true;
            this.checkBoxtemp.Location = new System.Drawing.Point(7, 42);
            this.checkBoxtemp.Name = "checkBoxtemp";
            this.checkBoxtemp.Size = new System.Drawing.Size(52, 17);
            this.checkBoxtemp.TabIndex = 2;
            this.checkBoxtemp.Text = ".temp";
            this.checkBoxtemp.UseVisualStyleBackColor = true;
            this.checkBoxtemp.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkBoxtemp_MouseClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.checkBoxShowInfo);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(332, 129);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Спец. функции";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 29);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(215, 41);
            this.button3.TabIndex = 1;
            this.button3.Text = "Выбрать отдельные директории для чистки";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkBoxShowInfo
            // 
            this.checkBoxShowInfo.AutoSize = true;
            this.checkBoxShowInfo.Location = new System.Drawing.Point(6, 6);
            this.checkBoxShowInfo.Name = "checkBoxShowInfo";
            this.checkBoxShowInfo.Size = new System.Drawing.Size(215, 17);
            this.checkBoxShowInfo.TabIndex = 0;
            this.checkBoxShowInfo.Text = "Отображать информацию о файлах?:";
            this.checkBoxShowInfo.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оРазработчикеToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(362, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // оРазработчикеToolStripMenuItem
            // 
            this.оРазработчикеToolStripMenuItem.Name = "оРазработчикеToolStripMenuItem";
            this.оРазработчикеToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.оРазработчикеToolStripMenuItem.Text = "О разработчике";
            this.оРазработчикеToolStripMenuItem.Click += new System.EventHandler(this.оРазработчикеToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // CleaningButton
            // 
            this.CleaningButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CleaningButton.Location = new System.Drawing.Point(27, 191);
            this.CleaningButton.Name = "CleaningButton";
            this.CleaningButton.Size = new System.Drawing.Size(326, 40);
            this.CleaningButton.TabIndex = 7;
            this.CleaningButton.Text = "Выполнить Очистку!";
            this.CleaningButton.UseVisualStyleBackColor = true;
            this.CleaningButton.Click += new System.EventHandler(this.CleaningButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 245);
            this.Controls.Add(this.CleaningButton);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(378, 284);
            this.MinimumSize = new System.Drawing.Size(378, 284);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SystemCleaner";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem оРазработчикеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxDefault;
        private System.Windows.Forms.CheckBox checkBoxt;
        private System.Windows.Forms.CheckBox checkBoxasx;
        private System.Windows.Forms.CheckBox checkBoxdat;
        private System.Windows.Forms.CheckBox checkBoxiff;
        private System.Windows.Forms.CheckBox checkBoxtmp;
        private System.Windows.Forms.CheckBox checkBoxxps;
        private System.Windows.Forms.CheckBox checkBoxinf;
        private System.Windows.Forms.CheckBox checkBoxtemp;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox checkBoxShowInfo;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button CleaningButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckedDrives;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReadyDrives;
    }
}

