namespace KnightageCMS
{
    partial class LoginPanel
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.TXT_USERNAME = new MetroFramework.Controls.MetroTextBox();
            this.TXT_PASWWORD = new MetroFramework.Controls.MetroTextBox();
            this.btn_login = new MetroFramework.Controls.MetroButton();
            this.btn_Cancel = new MetroFramework.Controls.MetroButton();
            this.Link_Forget_Pass = new MetroFramework.Controls.MetroLink();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(79, 140);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(84, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "USERNAME";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(81, 186);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(88, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "PASSWORD";
            // 
            // TXT_USERNAME
            // 
            this.TXT_USERNAME.Lines = new string[0];
            this.TXT_USERNAME.Location = new System.Drawing.Point(189, 140);
            this.TXT_USERNAME.MaxLength = 32767;
            this.TXT_USERNAME.Name = "TXT_USERNAME";
            this.TXT_USERNAME.PasswordChar = '\0';
            this.TXT_USERNAME.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TXT_USERNAME.SelectedText = "";
            this.TXT_USERNAME.Size = new System.Drawing.Size(157, 23);
            this.TXT_USERNAME.TabIndex = 0;
            this.TXT_USERNAME.UseSelectable = true;
            // 
            // TXT_PASWWORD
            // 
            this.TXT_PASWWORD.Lines = new string[0];
            this.TXT_PASWWORD.Location = new System.Drawing.Point(189, 186);
            this.TXT_PASWWORD.MaxLength = 32767;
            this.TXT_PASWWORD.Name = "TXT_PASWWORD";
            this.TXT_PASWWORD.PasswordChar = '*';
            this.TXT_PASWWORD.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TXT_PASWWORD.SelectedText = "";
            this.TXT_PASWWORD.Size = new System.Drawing.Size(157, 23);
            this.TXT_PASWWORD.TabIndex = 3;
            this.TXT_PASWWORD.UseSelectable = true;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(131, 240);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "LOGIN";
            this.btn_login.UseSelectable = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(227, 240);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.Text = "CANCEL";
            this.btn_Cancel.UseSelectable = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // Link_Forget_Pass
            // 
            this.Link_Forget_Pass.ForeColor = System.Drawing.Color.Red;
            this.Link_Forget_Pass.Location = new System.Drawing.Point(176, 286);
            this.Link_Forget_Pass.Name = "Link_Forget_Pass";
            this.Link_Forget_Pass.Size = new System.Drawing.Size(126, 23);
            this.Link_Forget_Pass.TabIndex = 6;
            this.Link_Forget_Pass.Text = "Forgot Password";
            this.Link_Forget_Pass.UseSelectable = true;
            this.Link_Forget_Pass.Click += new System.EventHandler(this.Link_Forget_Pass_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(176, 75);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(68, 25);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "LOGIN";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(111, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Developed and Maintained By Knightage";
            // 
            // LoginPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 397);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.Link_Forget_Pass);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.TXT_PASWWORD);
            this.Controls.Add(this.TXT_USERNAME);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "LoginPanel";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox TXT_USERNAME;
        private MetroFramework.Controls.MetroTextBox TXT_PASWWORD;
        private MetroFramework.Controls.MetroButton btn_login;
        private MetroFramework.Controls.MetroButton btn_Cancel;
        private MetroFramework.Controls.MetroLink Link_Forget_Pass;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.Label label3;

        
    }
}