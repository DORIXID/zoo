namespace zoo
{
    partial class loginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.guestBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // guestBtn
            // 
            this.guestBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.guestBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.guestBtn.Font = new System.Drawing.Font("Calibri Light", 20F);
            this.guestBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.guestBtn.Location = new System.Drawing.Point(15, 279);
            this.guestBtn.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.guestBtn.Name = "guestBtn";
            this.guestBtn.Size = new System.Drawing.Size(239, 53);
            this.guestBtn.TabIndex = 0;
            this.guestBtn.Text = "Войти как гость";
            this.guestBtn.UseVisualStyleBackColor = false;
            this.guestBtn.Click += new System.EventHandler(this.guestBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 20F);
            this.label1.Location = new System.Drawing.Point(101, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Вход";
            // 
            // usernameTxt
            // 
            this.usernameTxt.Location = new System.Drawing.Point(15, 81);
            this.usernameTxt.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(239, 37);
            this.usernameTxt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 16F);
            this.label2.Location = new System.Drawing.Point(15, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri Light", 16F);
            this.label3.Location = new System.Drawing.Point(15, 125);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Пароль";
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(15, 159);
            this.passwordTxt.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(239, 37);
            this.passwordTxt.TabIndex = 4;
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginBtn.Font = new System.Drawing.Font("Calibri Light", 20F);
            this.loginBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.loginBtn.Location = new System.Drawing.Point(15, 210);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(239, 53);
            this.loginBtn.TabIndex = 6;
            this.loginBtn.Text = "Войти";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(269, 338);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guestBtn);
            this.Font = new System.Drawing.Font("Calibri Light", 18F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "loginForm";
            this.Text = "Логин";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button guestBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Button loginBtn;
    }
}

