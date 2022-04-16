namespace kafeyonetimi
{
    partial class frmLogin
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUserPassword = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btnGirisYap = new Bunifu.Framework.UI.BunifuThinButton2();
            this.beniHatirla = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(238)))), ((int)(((byte)(229)))));
            this.label1.Font = new System.Drawing.Font("Poppins", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.label1.Location = new System.Drawing.Point(69, 369);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "kafe yönetimi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.label2.Font = new System.Drawing.Font("Poppins", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(238)))), ((int)(((byte)(229)))));
            this.label2.Location = new System.Drawing.Point(375, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hoşgeldin,";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.label3.Font = new System.Drawing.Font("Poppins Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(238)))), ((int)(((byte)(229)))));
            this.label3.Location = new System.Drawing.Point(378, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "devam etmek için giriş yap";
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.txtUserName.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(238)))), ((int)(((byte)(229)))));
            this.txtUserName.BorderColorIdle = System.Drawing.Color.Gray;
            this.txtUserName.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(238)))), ((int)(((byte)(229)))));
            this.txtUserName.BorderThickness = 5;
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.Font = new System.Drawing.Font("Poppins", 11F);
            this.txtUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(238)))), ((int)(((byte)(229)))));
            this.txtUserName.isPassword = false;
            this.txtUserName.Location = new System.Drawing.Point(378, 174);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(288, 52);
            this.txtUserName.TabIndex = 4;
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.label4.Font = new System.Drawing.Font("Poppins Light", 10F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(238)))), ((int)(((byte)(229)))));
            this.label4.Location = new System.Drawing.Point(377, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "kullanıcı adı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.label5.Font = new System.Drawing.Font("Poppins Light", 10F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(238)))), ((int)(((byte)(229)))));
            this.label5.Location = new System.Drawing.Point(377, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "şifre";
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.txtUserPassword.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(238)))), ((int)(((byte)(229)))));
            this.txtUserPassword.BorderColorIdle = System.Drawing.Color.Gray;
            this.txtUserPassword.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(238)))), ((int)(((byte)(229)))));
            this.txtUserPassword.BorderThickness = 5;
            this.txtUserPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserPassword.Font = new System.Drawing.Font("Poppins", 11F);
            this.txtUserPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(238)))), ((int)(((byte)(229)))));
            this.txtUserPassword.isPassword = true;
            this.txtUserPassword.Location = new System.Drawing.Point(378, 267);
            this.txtUserPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.Size = new System.Drawing.Size(288, 52);
            this.txtUserPassword.TabIndex = 6;
            this.txtUserPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.ActiveBorderThickness = 3;
            this.btnGirisYap.ActiveCornerRadius = 1;
            this.btnGirisYap.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(238)))), ((int)(((byte)(229)))));
            this.btnGirisYap.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnGirisYap.ActiveLineColor = System.Drawing.Color.Gray;
            this.btnGirisYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnGirisYap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGirisYap.BackgroundImage")));
            this.btnGirisYap.ButtonText = "giriş yap";
            this.btnGirisYap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGirisYap.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGirisYap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnGirisYap.IdleBorderThickness = 3;
            this.btnGirisYap.IdleCornerRadius = 1;
            this.btnGirisYap.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnGirisYap.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(238)))), ((int)(((byte)(229)))));
            this.btnGirisYap.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(238)))), ((int)(((byte)(229)))));
            this.btnGirisYap.Location = new System.Drawing.Point(382, 363);
            this.btnGirisYap.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(145, 57);
            this.btnGirisYap.TabIndex = 10;
            this.btnGirisYap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // beniHatirla
            // 
            this.beniHatirla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(238)))), ((int)(((byte)(229)))));
            this.beniHatirla.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.beniHatirla.Checked = true;
            this.beniHatirla.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(238)))), ((int)(((byte)(229)))));
            this.beniHatirla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.beniHatirla.Location = new System.Drawing.Point(382, 330);
            this.beniHatirla.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.beniHatirla.Name = "beniHatirla";
            this.beniHatirla.Size = new System.Drawing.Size(20, 20);
            this.beniHatirla.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.label6.Font = new System.Drawing.Font("Poppins Light", 10F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(238)))), ((int)(((byte)(229)))));
            this.label6.Location = new System.Drawing.Point(405, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "beni hatırla";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BackgroundImage = global::kafeyonetimi.Properties.Resources.main;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(704, 488);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.beniHatirla);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUserPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kafe Yönetimi - Giriş Yap";
            this.Shown += new System.EventHandler(this.frmLogin_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuMetroTextbox txtUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtUserPassword;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnGirisYap;
        private Bunifu.Framework.UI.BunifuCheckbox beniHatirla;
        private System.Windows.Forms.Label label6;
    }
}

