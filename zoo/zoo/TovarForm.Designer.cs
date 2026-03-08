namespace zoo
{
    partial class TovarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TovarForm));
            this.saveBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.articleTextBox = new System.Windows.Forms.TextBox();
            this.descryptionTextBox = new System.Windows.Forms.TextBox();
            this.countN = new System.Windows.Forms.NumericUpDown();
            this.saleN = new System.Windows.Forms.NumericUpDown();
            this.costN = new System.Windows.Forms.NumericUpDown();
            this.unitComboBox = new System.Windows.Forms.ComboBox();
            this.cathegoryComboBox = new System.Windows.Forms.ComboBox();
            this.manufacturerComboBox = new System.Windows.Forms.ComboBox();
            this.supplierComboBox = new System.Windows.Forms.ComboBox();
            this.imageTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.imagePB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.countN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePB)).BeginInit();
            this.SuspendLayout();
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveBtn.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.saveBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.saveBtn.Location = new System.Drawing.Point(602, 353);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(129, 29);
            this.saveBtn.TabIndex = 46;
            this.saveBtn.Text = "Создать";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 18F);
            this.label2.Location = new System.Drawing.Point(15, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 29);
            this.label2.TabIndex = 25;
            this.label2.Text = "Цена:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri Light", 18F);
            this.label3.Location = new System.Drawing.Point(15, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 29);
            this.label3.TabIndex = 26;
            this.label3.Text = "Категория:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri Light", 18F);
            this.label4.Location = new System.Drawing.Point(15, 184);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 29);
            this.label4.TabIndex = 27;
            this.label4.Text = "Производитель:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri Light", 18F);
            this.label5.Location = new System.Drawing.Point(14, 244);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 29);
            this.label5.TabIndex = 28;
            this.label5.Text = "Поставщик:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri Light", 18F);
            this.label6.Location = new System.Drawing.Point(328, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(223, 29);
            this.label6.TabIndex = 29;
            this.label6.Text = "Еденица измерения:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri Light", 18F);
            this.label7.Location = new System.Drawing.Point(328, 66);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(238, 29);
            this.label7.TabIndex = 30;
            this.label7.Text = "Количество на складе:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri Light", 18F);
            this.label8.Location = new System.Drawing.Point(328, 126);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(230, 29);
            this.label8.TabIndex = 31;
            this.label8.Text = "Действующая скидка:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri Light", 18F);
            this.label9.Location = new System.Drawing.Point(328, 184);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 29);
            this.label9.TabIndex = 32;
            this.label9.Text = "Описание:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 18F);
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 29);
            this.label1.TabIndex = 24;
            this.label1.Text = "Наименование:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri Light", 14F);
            this.label11.Location = new System.Drawing.Point(16, 323);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 23);
            this.label11.TabIndex = 42;
            this.label11.Text = "Артикль:";
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitBtn.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.exitBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.exitBtn.Location = new System.Drawing.Point(333, 351);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(74, 32);
            this.exitBtn.TabIndex = 45;
            this.exitBtn.Text = "Назад";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Font = new System.Drawing.Font("Calibri Light", 14F);
            this.nameTxtBox.Location = new System.Drawing.Point(19, 34);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(167, 30);
            this.nameTxtBox.TabIndex = 47;
            // 
            // articleTextBox
            // 
            this.articleTextBox.Font = new System.Drawing.Font("Calibri Light", 14F);
            this.articleTextBox.Location = new System.Drawing.Point(20, 349);
            this.articleTextBox.Name = "articleTextBox";
            this.articleTextBox.Size = new System.Drawing.Size(167, 30);
            this.articleTextBox.TabIndex = 50;
            // 
            // descryptionTextBox
            // 
            this.descryptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descryptionTextBox.Font = new System.Drawing.Font("Calibri Light", 14F);
            this.descryptionTextBox.Location = new System.Drawing.Point(333, 216);
            this.descryptionTextBox.Multiline = true;
            this.descryptionTextBox.Name = "descryptionTextBox";
            this.descryptionTextBox.Size = new System.Drawing.Size(398, 130);
            this.descryptionTextBox.TabIndex = 51;
            // 
            // countN
            // 
            this.countN.Font = new System.Drawing.Font("Calibri Light", 14F);
            this.countN.Location = new System.Drawing.Point(333, 98);
            this.countN.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.countN.Name = "countN";
            this.countN.Size = new System.Drawing.Size(218, 30);
            this.countN.TabIndex = 52;
            // 
            // saleN
            // 
            this.saleN.Font = new System.Drawing.Font("Calibri Light", 14F);
            this.saleN.Location = new System.Drawing.Point(333, 158);
            this.saleN.Name = "saleN";
            this.saleN.Size = new System.Drawing.Size(218, 30);
            this.saleN.TabIndex = 53;
            // 
            // costN
            // 
            this.costN.Font = new System.Drawing.Font("Calibri Light", 14F);
            this.costN.Location = new System.Drawing.Point(20, 98);
            this.costN.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.costN.Name = "costN";
            this.costN.Size = new System.Drawing.Size(171, 30);
            this.costN.TabIndex = 54;
            // 
            // unitComboBox
            // 
            this.unitComboBox.Font = new System.Drawing.Font("Calibri Light", 14F);
            this.unitComboBox.FormattingEnabled = true;
            this.unitComboBox.Items.AddRange(new object[] {
            "кг",
            "упак",
            "шт",
            "флакон",
            "банка"});
            this.unitComboBox.Location = new System.Drawing.Point(333, 34);
            this.unitComboBox.Name = "unitComboBox";
            this.unitComboBox.Size = new System.Drawing.Size(218, 31);
            this.unitComboBox.TabIndex = 55;
            // 
            // cathegoryComboBox
            // 
            this.cathegoryComboBox.Font = new System.Drawing.Font("Calibri Light", 14F);
            this.cathegoryComboBox.FormattingEnabled = true;
            this.cathegoryComboBox.Items.AddRange(new object[] {
            "Корма для кошек",
            "Корма для собак",
            "Наполнители",
            "Игрушки",
            "Клетки и переноски",
            "Амуниция",
            "Гигиена",
            "Аксессуары",
            "Лакомства",
            "Домики и лежанки",
            "Миски и поилки",
            "Корма для птиц",
            "Корма для грызунов",
            "Средства защиты",
            "Корма для рыб",
            "Корма для рептилий",
            "Витамины"});
            this.cathegoryComboBox.Location = new System.Drawing.Point(19, 150);
            this.cathegoryComboBox.Name = "cathegoryComboBox";
            this.cathegoryComboBox.Size = new System.Drawing.Size(218, 31);
            this.cathegoryComboBox.TabIndex = 56;
            // 
            // manufacturerComboBox
            // 
            this.manufacturerComboBox.Font = new System.Drawing.Font("Calibri Light", 14F);
            this.manufacturerComboBox.FormattingEnabled = true;
            this.manufacturerComboBox.Items.AddRange(new object[] {
            "Royal Canin",
            "Purina",
            "CatsBest",
            "Фабрика игрушек",
            "Ferplast",
            "Hunter",
            "Hill\'s",
            "Beaphar",
            "GimCat",
            "Acana",
            "Orijen",
            "ЗооМаркет",
            "Trixie",
            "Vitakraft",
            "Savic",
            "Versele-Laga",
            "Pedigree",
            "Tetra",
            "Iv San Bernard",
            "Умный хвост",
            "Flexi"});
            this.manufacturerComboBox.Location = new System.Drawing.Point(20, 210);
            this.manufacturerComboBox.Name = "manufacturerComboBox";
            this.manufacturerComboBox.Size = new System.Drawing.Size(218, 31);
            this.manufacturerComboBox.TabIndex = 57;
            // 
            // supplierComboBox
            // 
            this.supplierComboBox.Font = new System.Drawing.Font("Calibri Light", 14F);
            this.supplierComboBox.FormattingEnabled = true;
            this.supplierComboBox.Items.AddRange(new object[] {
            "ЗооПром",
            "КормЦентр",
            "ИП Иванов",
            "ЗооТрейд",
            "ЗооЛюкс",
            "ВетСнаб"});
            this.supplierComboBox.Location = new System.Drawing.Point(20, 276);
            this.supplierComboBox.Name = "supplierComboBox";
            this.supplierComboBox.Size = new System.Drawing.Size(218, 31);
            this.supplierComboBox.TabIndex = 58;
            // 
            // imageTextBox
            // 
            this.imageTextBox.Font = new System.Drawing.Font("Calibri Light", 14F);
            this.imageTextBox.Location = new System.Drawing.Point(578, 158);
            this.imageTextBox.Name = "imageTextBox";
            this.imageTextBox.Size = new System.Drawing.Size(153, 30);
            this.imageTextBox.TabIndex = 61;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.label10.Location = new System.Drawing.Point(582, 137);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 17);
            this.label10.TabIndex = 62;
            this.label10.Text = "Название изображения:";
            // 
            // imagePB
            // 
            this.imagePB.Location = new System.Drawing.Point(578, 17);
            this.imagePB.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.imagePB.Name = "imagePB";
            this.imagePB.Size = new System.Drawing.Size(153, 112);
            this.imagePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagePB.TabIndex = 59;
            this.imagePB.TabStop = false;
            this.imagePB.Click += new System.EventHandler(this.imagePB_Click);
            // 
            // TovarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(746, 399);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.imageTextBox);
            this.Controls.Add(this.imagePB);
            this.Controls.Add(this.supplierComboBox);
            this.Controls.Add(this.manufacturerComboBox);
            this.Controls.Add(this.cathegoryComboBox);
            this.Controls.Add(this.unitComboBox);
            this.Controls.Add(this.costN);
            this.Controls.Add(this.saleN);
            this.Controls.Add(this.countN);
            this.Controls.Add(this.descryptionTextBox);
            this.Controls.Add(this.articleTextBox);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TovarForm";
            this.Text = "Товар";
            ((System.ComponentModel.ISupportInitialize)(this.countN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button saveBtn;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.TextBox articleTextBox;
        private System.Windows.Forms.TextBox descryptionTextBox;
        private System.Windows.Forms.NumericUpDown countN;
        private System.Windows.Forms.NumericUpDown saleN;
        private System.Windows.Forms.NumericUpDown costN;
        private System.Windows.Forms.ComboBox unitComboBox;
        private System.Windows.Forms.ComboBox cathegoryComboBox;
        private System.Windows.Forms.ComboBox manufacturerComboBox;
        private System.Windows.Forms.ComboBox supplierComboBox;
        private System.Windows.Forms.TextBox imageTextBox;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.PictureBox imagePB;
    }
}