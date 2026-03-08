namespace zoo
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.SearchLbl = new System.Windows.Forms.Label();
            this.lbl123 = new System.Windows.Forms.Label();
            this.roleLbl = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.fioLbl = new System.Windows.Forms.Label();
            this.searchCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.descRBtn = new System.Windows.Forms.RadioButton();
            this.ascRBtn = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.filterCB = new System.Windows.Forms.ComboBox();
            this.createTovarBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Каталог";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(219)))), ((int)(((byte)(226)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(18, 88);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(970, 507);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(18, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // searchTB
            // 
            this.searchTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(219)))), ((int)(((byte)(226)))));
            this.searchTB.Font = new System.Drawing.Font("Calibri Light", 16F);
            this.searchTB.Location = new System.Drawing.Point(993, 45);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(181, 34);
            this.searchTB.TabIndex = 3;
            this.searchTB.Visible = false;
            this.searchTB.TextChanged += new System.EventHandler(this.serchTextChanged);
            // 
            // SearchLbl
            // 
            this.SearchLbl.AutoSize = true;
            this.SearchLbl.Location = new System.Drawing.Point(991, 9);
            this.SearchLbl.Name = "SearchLbl";
            this.SearchLbl.Size = new System.Drawing.Size(83, 33);
            this.SearchLbl.TabIndex = 4;
            this.SearchLbl.Text = "Поиск";
            this.SearchLbl.Visible = false;
            // 
            // lbl123
            // 
            this.lbl123.AutoSize = true;
            this.lbl123.Location = new System.Drawing.Point(130, 42);
            this.lbl123.Name = "lbl123";
            this.lbl123.Size = new System.Drawing.Size(74, 33);
            this.lbl123.TabIndex = 5;
            this.lbl123.Text = "Роль:";
            // 
            // roleLbl
            // 
            this.roleLbl.AutoSize = true;
            this.roleLbl.Location = new System.Drawing.Point(210, 42);
            this.roleLbl.Name = "roleLbl";
            this.roleLbl.Size = new System.Drawing.Size(0, 33);
            this.roleLbl.TabIndex = 6;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitBtn.Font = new System.Drawing.Font("Calibri Light", 20F);
            this.exitBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.exitBtn.Location = new System.Drawing.Point(992, 542);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(181, 53);
            this.exitBtn.TabIndex = 7;
            this.exitBtn.Text = "Выйти";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(437, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 33);
            this.label2.TabIndex = 8;
            this.label2.Text = "ФИО:";
            // 
            // fioLbl
            // 
            this.fioLbl.AutoSize = true;
            this.fioLbl.Location = new System.Drawing.Point(504, 42);
            this.fioLbl.Name = "fioLbl";
            this.fioLbl.Size = new System.Drawing.Size(0, 33);
            this.fioLbl.TabIndex = 9;
            // 
            // searchCB
            // 
            this.searchCB.AutoCompleteCustomSource.AddRange(new string[] {
            "Наименованию",
            "Описанию",
            "Производителю",
            "Поставщику"});
            this.searchCB.FormattingEnabled = true;
            this.searchCB.Items.AddRange(new object[] {
            "Наименованию",
            "Описанию",
            "Производителю",
            "Поставщику"});
            this.searchCB.Location = new System.Drawing.Point(994, 118);
            this.searchCB.Name = "searchCB";
            this.searchCB.Size = new System.Drawing.Size(180, 41);
            this.searchCB.TabIndex = 10;
            this.searchCB.Visible = false;
            this.searchCB.SelectedIndexChanged += new System.EventHandler(this.serchTextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(988, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 33);
            this.label3.TabIndex = 11;
            this.label3.Text = "Искать по:";
            this.label3.Visible = false;
            // 
            // descRBtn
            // 
            this.descRBtn.AutoSize = true;
            this.descRBtn.Font = new System.Drawing.Font("Calibri Light", 16F);
            this.descRBtn.Location = new System.Drawing.Point(997, 234);
            this.descRBtn.Name = "descRBtn";
            this.descRBtn.Size = new System.Drawing.Size(126, 31);
            this.descRBtn.TabIndex = 12;
            this.descRBtn.Text = "убыванию";
            this.descRBtn.UseVisualStyleBackColor = true;
            this.descRBtn.Visible = false;
            this.descRBtn.TabIndexChanged += new System.EventHandler(this.serchTextChanged);
            this.descRBtn.Click += new System.EventHandler(this.serchTextChanged);
            // 
            // ascRBtn
            // 
            this.ascRBtn.AutoSize = true;
            this.ascRBtn.Checked = true;
            this.ascRBtn.Font = new System.Drawing.Font("Calibri Light", 16F);
            this.ascRBtn.Location = new System.Drawing.Point(997, 197);
            this.ascRBtn.Name = "ascRBtn";
            this.ascRBtn.Size = new System.Drawing.Size(149, 31);
            this.ascRBtn.TabIndex = 13;
            this.ascRBtn.TabStop = true;
            this.ascRBtn.Text = "возрастанию";
            this.ascRBtn.UseVisualStyleBackColor = true;
            this.ascRBtn.Visible = false;
            this.ascRBtn.TabIndexChanged += new System.EventHandler(this.serchTextChanged);
            this.ascRBtn.Click += new System.EventHandler(this.serchTextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(991, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 33);
            this.label4.TabIndex = 14;
            this.label4.Text = "Сортировать по:";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(991, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 33);
            this.label5.TabIndex = 15;
            this.label5.Text = "Поставщики:";
            this.label5.Visible = false;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // filterCB
            // 
            this.filterCB.FormattingEnabled = true;
            this.filterCB.Items.AddRange(new object[] {
            "Все",
            "ЗооПром",
            "КормЦентр",
            "ИП Иванов",
            "ЗооТрейд",
            "ЗооЛюкс",
            "ВетСнаб"});
            this.filterCB.Location = new System.Drawing.Point(993, 304);
            this.filterCB.Name = "filterCB";
            this.filterCB.Size = new System.Drawing.Size(180, 41);
            this.filterCB.TabIndex = 16;
            this.filterCB.Visible = false;
            this.filterCB.SelectedIndexChanged += new System.EventHandler(this.serchTextChanged);
            this.filterCB.TabIndexChanged += new System.EventHandler(this.serchTextChanged);
            // 
            // createTovarBtn
            // 
            this.createTovarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.createTovarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.createTovarBtn.Font = new System.Drawing.Font("Calibri Light", 16F);
            this.createTovarBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.createTovarBtn.Location = new System.Drawing.Point(992, 355);
            this.createTovarBtn.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.createTovarBtn.Name = "createTovarBtn";
            this.createTovarBtn.Size = new System.Drawing.Size(181, 53);
            this.createTovarBtn.TabIndex = 17;
            this.createTovarBtn.Text = "Создать товар";
            this.createTovarBtn.UseVisualStyleBackColor = false;
            this.createTovarBtn.Visible = false;
            this.createTovarBtn.Click += new System.EventHandler(this.createTovarBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1180, 607);
            this.Controls.Add(this.createTovarBtn);
            this.Controls.Add(this.descRBtn);
            this.Controls.Add(this.filterCB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ascRBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.searchCB);
            this.Controls.Add(this.fioLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.roleLbl);
            this.Controls.Add(this.lbl123);
            this.Controls.Add(this.SearchLbl);
            this.Controls.Add(this.searchTB);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Calibri Light", 20F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "MainForm";
            this.Text = "Каталог";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.Label SearchLbl;
        private System.Windows.Forms.Label lbl123;
        private System.Windows.Forms.Label roleLbl;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label fioLbl;
        private System.Windows.Forms.ComboBox searchCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton descRBtn;
        private System.Windows.Forms.RadioButton ascRBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox filterCB;
        private System.Windows.Forms.Button createTovarBtn;
    }
}