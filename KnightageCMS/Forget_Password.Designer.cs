namespace KnightageCMS
{
    partial class Forget_Password
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ans = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_confirm = new MetroFramework.Controls.MetroTextBox();
            this.txt_password = new MetroFramework.Controls.MetroTextBox();
            this.btn_Ch_pass = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.btn_Check = new MetroFramework.Controls.MetroButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "RESET PASSWORD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Q.";
            // 
            // txt_ans
            // 
            this.txt_ans.Location = new System.Drawing.Point(77, 163);
            this.txt_ans.Name = "txt_ans";
            this.txt_ans.Size = new System.Drawing.Size(490, 20);
            this.txt_ans.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ans .";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_confirm);
            this.panel1.Controls.Add(this.txt_password);
            this.panel1.Controls.Add(this.btn_Ch_pass);
            this.panel1.Controls.Add(this.metroLabel1);
            this.panel1.Controls.Add(this.metroLabel4);
            this.panel1.Location = new System.Drawing.Point(84, 264);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 152);
            this.panel1.TabIndex = 4;
            // 
            // txt_confirm
            // 
            this.txt_confirm.Lines = new string[0];
            this.txt_confirm.Location = new System.Drawing.Point(192, 74);
            this.txt_confirm.MaxLength = 32767;
            this.txt_confirm.Name = "txt_confirm";
            this.txt_confirm.PasswordChar = '*';
            this.txt_confirm.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_confirm.SelectedText = "";
            this.txt_confirm.Size = new System.Drawing.Size(121, 23);
            this.txt_confirm.TabIndex = 20;
            this.txt_confirm.UseSelectable = true;
            // 
            // txt_password
            // 
            this.txt_password.Lines = new string[0];
            this.txt_password.Location = new System.Drawing.Point(192, 35);
            this.txt_password.MaxLength = 32767;
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_password.SelectedText = "";
            this.txt_password.Size = new System.Drawing.Size(121, 23);
            this.txt_password.TabIndex = 19;
            this.txt_password.UseSelectable = true;
            // 
            // btn_Ch_pass
            // 
            this.btn_Ch_pass.Location = new System.Drawing.Point(130, 117);
            this.btn_Ch_pass.Name = "btn_Ch_pass";
            this.btn_Ch_pass.Size = new System.Drawing.Size(107, 23);
            this.btn_Ch_pass.TabIndex = 18;
            this.btn_Ch_pass.Text = "Change Password";
            this.btn_Ch_pass.UseSelectable = true;
            this.btn_Ch_pass.Click += new System.EventHandler(this.btn_Ch_pass_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 74);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(146, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Confirm New Password";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(76, 39);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(94, 19);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "New Password";
            // 
            // btn_Check
            // 
            this.btn_Check.Location = new System.Drawing.Point(224, 211);
            this.btn_Check.Name = "btn_Check";
            this.btn_Check.Size = new System.Drawing.Size(75, 23);
            this.btn_Check.TabIndex = 17;
            this.btn_Check.Text = "Check";
            this.btn_Check.UseSelectable = true;
            this.btn_Check.Click += new System.EventHandler(this.btn_Check_Click);
            // 
            // Forget_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 448);
            this.Controls.Add(this.btn_Check);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_ans);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Forget_Password";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            //this.Text = "i";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ans;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroButton btn_Check;
        private MetroFramework.Controls.MetroButton btn_Ch_pass;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txt_confirm;
        private MetroFramework.Controls.MetroTextBox txt_password;
    }
}