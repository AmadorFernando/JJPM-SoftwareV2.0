namespace Proyecto_JJPM_Software.Forms
{
    partial class frmLogin
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblTituloCentral = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.P_Left = new System.Windows.Forms.Panel();
            this.P_Login = new System.Windows.Forms.Panel();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.txtBoxUsername = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.pboxPassVisual = new System.Windows.Forms.PictureBox();
            this.pboxLogo = new System.Windows.Forms.PictureBox();
            this.pboxMin = new System.Windows.Forms.PictureBox();
            this.pboxMax = new System.Windows.Forms.PictureBox();
            this.pboxClose = new System.Windows.Forms.PictureBox();
            this.panelTop.SuspendLayout();
            this.P_Left.SuspendLayout();
            this.P_Login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPassVisual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelTop.Controls.Add(this.button3);
            this.panelTop.Controls.Add(this.button2);
            this.panelTop.Controls.Add(this.lblTituloCentral);
            this.panelTop.Controls.Add(this.pboxMin);
            this.panelTop.Controls.Add(this.button1);
            this.panelTop.Controls.Add(this.pboxMax);
            this.panelTop.Controls.Add(this.pboxClose);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(965, 58);
            this.panelTop.TabIndex = 0;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(349, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 31);
            this.button3.TabIndex = 13;
            this.button3.Text = "Boton del Caller";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(190, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 31);
            this.button2.TabIndex = 12;
            this.button2.Text = "Boton del Leads";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblTituloCentral
            // 
            this.lblTituloCentral.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTituloCentral.AutoSize = true;
            this.lblTituloCentral.Font = new System.Drawing.Font("Century Gothic", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCentral.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTituloCentral.Location = new System.Drawing.Point(567, 9);
            this.lblTituloCentral.Name = "lblTituloCentral";
            this.lblTituloCentral.Size = new System.Drawing.Size(253, 37);
            this.lblTituloCentral.TabIndex = 8;
            this.lblTituloCentral.Text = "Inicio de Sesion";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 31);
            this.button1.TabIndex = 11;
            this.button1.Text = "Boton del Admin";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // P_Left
            // 
            this.P_Left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.P_Left.Controls.Add(this.pboxLogo);
            this.P_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.P_Left.Location = new System.Drawing.Point(0, 58);
            this.P_Left.Name = "P_Left";
            this.P_Left.Size = new System.Drawing.Size(400, 662);
            this.P_Left.TabIndex = 15;
            // 
            // P_Login
            // 
            this.P_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.P_Login.Controls.Add(this.txtBoxPassword);
            this.P_Login.Controls.Add(this.txtBoxUsername);
            this.P_Login.Controls.Add(this.pboxPassVisual);
            this.P_Login.Controls.Add(this.btnLogin);
            this.P_Login.Controls.Add(this.lblPass);
            this.P_Login.Controls.Add(this.lblUser);
            this.P_Login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.P_Login.Location = new System.Drawing.Point(400, 58);
            this.P_Login.Name = "P_Login";
            this.P_Login.Size = new System.Drawing.Size(565, 662);
            this.P_Login.TabIndex = 16;
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxPassword.Location = new System.Drawing.Point(158, 320);
            this.txtBoxPassword.MaxLength = 20;
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.PasswordChar = '·';
            this.txtBoxPassword.Size = new System.Drawing.Size(228, 26);
            this.txtBoxPassword.TabIndex = 15;
            // 
            // txtBoxUsername
            // 
            this.txtBoxUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxUsername.Location = new System.Drawing.Point(158, 261);
            this.txtBoxUsername.MaxLength = 20;
            this.txtBoxUsername.Name = "txtBoxUsername";
            this.txtBoxUsername.Size = new System.Drawing.Size(228, 26);
            this.txtBoxUsername.TabIndex = 14;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.BackColor = System.Drawing.Color.Green;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(158, 368);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(228, 40);
            this.btnLogin.TabIndex = 13;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblPass
            // 
            this.lblPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPass.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.ForeColor = System.Drawing.Color.White;
            this.lblPass.Location = new System.Drawing.Point(154, 290);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(232, 24);
            this.lblPass.TabIndex = 12;
            this.lblPass.Text = "Password";
            // 
            // lblUser
            // 
            this.lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUser.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(154, 234);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(232, 24);
            this.lblUser.TabIndex = 11;
            this.lblUser.Text = "Username";
            // 
            // pboxPassVisual
            // 
            this.pboxPassVisual.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pboxPassVisual.Image = global::Proyecto_JJPM_Software.Properties.Resources.visibility;
            this.pboxPassVisual.Location = new System.Drawing.Point(392, 320);
            this.pboxPassVisual.Name = "pboxPassVisual";
            this.pboxPassVisual.Size = new System.Drawing.Size(28, 26);
            this.pboxPassVisual.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxPassVisual.TabIndex = 14;
            this.pboxPassVisual.TabStop = false;
            this.pboxPassVisual.Click += new System.EventHandler(this.pboxPassVisual_Click);
            this.pboxPassVisual.DoubleClick += new System.EventHandler(this.pboxPassVisual_DoubleClick);
            // 
            // pboxLogo
            // 
            this.pboxLogo.Image = global::Proyecto_JJPM_Software.Properties.Resources.JJP1;
            this.pboxLogo.Location = new System.Drawing.Point(-3, 117);
            this.pboxLogo.Name = "pboxLogo";
            this.pboxLogo.Size = new System.Drawing.Size(400, 400);
            this.pboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxLogo.TabIndex = 12;
            this.pboxLogo.TabStop = false;
            // 
            // pboxMin
            // 
            this.pboxMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pboxMin.Image = global::Proyecto_JJPM_Software.Properties.Resources.Minimize_Window_2_48px;
            this.pboxMin.Location = new System.Drawing.Point(872, 20);
            this.pboxMin.Name = "pboxMin";
            this.pboxMin.Size = new System.Drawing.Size(23, 23);
            this.pboxMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxMin.TabIndex = 7;
            this.pboxMin.TabStop = false;
            this.pboxMin.Click += new System.EventHandler(this.pboxMin_Click);
            // 
            // pboxMax
            // 
            this.pboxMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pboxMax.Image = global::Proyecto_JJPM_Software.Properties.Resources.Maximize_Window_2_48px;
            this.pboxMax.Location = new System.Drawing.Point(901, 20);
            this.pboxMax.Name = "pboxMax";
            this.pboxMax.Size = new System.Drawing.Size(23, 23);
            this.pboxMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxMax.TabIndex = 6;
            this.pboxMax.TabStop = false;
            this.pboxMax.Click += new System.EventHandler(this.pboxMax_Click);
            // 
            // pboxClose
            // 
            this.pboxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pboxClose.Image = global::Proyecto_JJPM_Software.Properties.Resources.Close_Window__2_48px;
            this.pboxClose.Location = new System.Drawing.Point(930, 20);
            this.pboxClose.Name = "pboxClose";
            this.pboxClose.Size = new System.Drawing.Size(23, 23);
            this.pboxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxClose.TabIndex = 4;
            this.pboxClose.TabStop = false;
            this.pboxClose.Click += new System.EventHandler(this.pboxClose_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 720);
            this.Controls.Add(this.P_Login);
            this.Controls.Add(this.P_Left);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Shown += new System.EventHandler(this.frmLogin_Shown);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.P_Left.ResumeLayout(false);
            this.P_Login.ResumeLayout(false);
            this.P_Login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPassVisual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox pboxMin;
        private System.Windows.Forms.PictureBox pboxMax;
        private System.Windows.Forms.PictureBox pboxClose;
        private System.Windows.Forms.Label lblTituloCentral;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pboxLogo;
        private System.Windows.Forms.PictureBox pboxPassVisual;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel P_Left;
        private System.Windows.Forms.Panel P_Login;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.TextBox txtBoxUsername;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblUser;
    }
}