namespace Weatherapp
{
    partial class frmSignIn
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
            this.label1 = new System.Windows.Forms.Label();
            this.tEName = new System.Windows.Forms.TextBox();
            this.tESurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tEEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tEPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tERepassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.tEUsername = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbYes = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // tEName
            // 
            this.tEName.Location = new System.Drawing.Point(194, 137);
            this.tEName.Name = "tEName";
            this.tEName.Size = new System.Drawing.Size(100, 20);
            this.tEName.TabIndex = 1;
            // 
            // tESurname
            // 
            this.tESurname.Location = new System.Drawing.Point(194, 185);
            this.tESurname.Name = "tESurname";
            this.tESurname.Size = new System.Drawing.Size(100, 20);
            this.tESurname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Surname:";
            // 
            // tEEmail
            // 
            this.tEEmail.Location = new System.Drawing.Point(194, 281);
            this.tEEmail.Name = "tEEmail";
            this.tEEmail.Size = new System.Drawing.Size(100, 20);
            this.tEEmail.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Username:";
            // 
            // tEPassword
            // 
            this.tEPassword.Location = new System.Drawing.Point(194, 329);
            this.tEPassword.Name = "tEPassword";
            this.tEPassword.Size = new System.Drawing.Size(100, 20);
            this.tEPassword.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password:";
            // 
            // tERepassword
            // 
            this.tERepassword.Location = new System.Drawing.Point(194, 377);
            this.tERepassword.Name = "tERepassword";
            this.tERepassword.Size = new System.Drawing.Size(100, 20);
            this.tERepassword.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Repeat Password:";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(113, 432);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 10;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // tEUsername
            // 
            this.tEUsername.Location = new System.Drawing.Point(194, 230);
            this.tEUsername.Name = "tEUsername";
            this.tEUsername.Size = new System.Drawing.Size(100, 20);
            this.tEUsername.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(155, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Emai:";
            // 
            // cbYes
            // 
            this.cbYes.AutoSize = true;
            this.cbYes.Location = new System.Drawing.Point(252, 93);
            this.cbYes.Name = "cbYes";
            this.cbYes.Size = new System.Drawing.Size(42, 17);
            this.cbYes.TabIndex = 13;
            this.cbYes.Text = "yes";
            this.cbYes.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(130, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "is it Normal user??";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(239, 432);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(188, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 31);
            this.label8.TabIndex = 16;
            this.label8.Text = "Sign In";
            // 
            // frmSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 495);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbYes);
            this.Controls.Add(this.tEUsername);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.tERepassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tEPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tEEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tESurname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tEName);
            this.Controls.Add(this.label1);
            this.Name = "frmSignIn";
            this.Text = "frmSignIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tEName;
        private System.Windows.Forms.TextBox tESurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tEEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tEPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tERepassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox tEUsername;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbYes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label8;
    }
}