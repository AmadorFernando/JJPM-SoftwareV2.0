namespace Proyecto_JJPM_Software
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTituloCentral = new System.Windows.Forms.Label();
            this.pboxMin = new System.Windows.Forms.PictureBox();
            this.pboxMax = new System.Windows.Forms.PictureBox();
            this.pboxRestore = new System.Windows.Forms.PictureBox();
            this.pboxClose = new System.Windows.Forms.PictureBox();
            this.panelLeftSide = new System.Windows.Forms.Panel();
            this.lblAgregarUsuario = new System.Windows.Forms.Label();
            this.lblIniciar = new System.Windows.Forms.Label();
            this.lblLogout = new System.Windows.Forms.Label();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxRestore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxClose)).BeginInit();
            this.panelLeftSide.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panelTop.Controls.Add(this.lblTituloCentral);
            this.panelTop.Controls.Add(this.pboxMin);
            this.panelTop.Controls.Add(this.pboxMax);
            this.panelTop.Controls.Add(this.pboxRestore);
            this.panelTop.Controls.Add(this.pboxClose);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1280, 60);
            this.panelTop.TabIndex = 0;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
            // 
            // lblTituloCentral
            // 
            this.lblTituloCentral.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTituloCentral.AutoSize = true;
            this.lblTituloCentral.Font = new System.Drawing.Font("Lucida Calligraphy", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCentral.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTituloCentral.Location = new System.Drawing.Point(504, 12);
            this.lblTituloCentral.Name = "lblTituloCentral";
            this.lblTituloCentral.Size = new System.Drawing.Size(0, 37);
            this.lblTituloCentral.TabIndex = 12;
            // 
            // pboxMin
            // 
            this.pboxMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pboxMin.Image = global::Proyecto_JJPM_Software.Properties.Resources.Minimize_Window_2_48px;
            this.pboxMin.Location = new System.Drawing.Point(1091, 5);
            this.pboxMin.Name = "pboxMin";
            this.pboxMin.Size = new System.Drawing.Size(48, 48);
            this.pboxMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pboxMin.TabIndex = 11;
            this.pboxMin.TabStop = false;
            this.pboxMin.Click += new System.EventHandler(this.pboxMin_Click);
            // 
            // pboxMax
            // 
            this.pboxMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pboxMax.Image = global::Proyecto_JJPM_Software.Properties.Resources.Maximize_Window_2_48px;
            this.pboxMax.Location = new System.Drawing.Point(1151, 6);
            this.pboxMax.Name = "pboxMax";
            this.pboxMax.Size = new System.Drawing.Size(48, 48);
            this.pboxMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pboxMax.TabIndex = 10;
            this.pboxMax.TabStop = false;
            this.pboxMax.Click += new System.EventHandler(this.pboxMax_Click);
            // 
            // pboxRestore
            // 
            this.pboxRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pboxRestore.Image = global::Proyecto_JJPM_Software.Properties.Resources.Restore_Window_2_48px;
            this.pboxRestore.Location = new System.Drawing.Point(1152, 7);
            this.pboxRestore.Name = "pboxRestore";
            this.pboxRestore.Size = new System.Drawing.Size(48, 48);
            this.pboxRestore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pboxRestore.TabIndex = 9;
            this.pboxRestore.TabStop = false;
            this.pboxRestore.Click += new System.EventHandler(this.pboxRestore_Click);
            // 
            // pboxClose
            // 
            this.pboxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pboxClose.Image = global::Proyecto_JJPM_Software.Properties.Resources.Close_Window__2_48px;
            this.pboxClose.Location = new System.Drawing.Point(1212, 6);
            this.pboxClose.Name = "pboxClose";
            this.pboxClose.Size = new System.Drawing.Size(48, 48);
            this.pboxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pboxClose.TabIndex = 8;
            this.pboxClose.TabStop = false;
            this.pboxClose.Click += new System.EventHandler(this.pboxClose_Click);
            // 
            // panelLeftSide
            // 
            this.panelLeftSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panelLeftSide.Controls.Add(this.lblAgregarUsuario);
            this.panelLeftSide.Controls.Add(this.lblIniciar);
            this.panelLeftSide.Controls.Add(this.lblLogout);
            this.panelLeftSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftSide.Location = new System.Drawing.Point(0, 60);
            this.panelLeftSide.Name = "panelLeftSide";
            this.panelLeftSide.Size = new System.Drawing.Size(200, 660);
            this.panelLeftSide.TabIndex = 1;
            // 
            // lblAgregarUsuario
            // 
            this.lblAgregarUsuario.AutoSize = true;
            this.lblAgregarUsuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAgregarUsuario.Enabled = false;
            this.lblAgregarUsuario.Font = new System.Drawing.Font("Lucida Calligraphy", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAgregarUsuario.Location = new System.Drawing.Point(12, 466);
            this.lblAgregarUsuario.Name = "lblAgregarUsuario";
            this.lblAgregarUsuario.Size = new System.Drawing.Size(168, 76);
            this.lblAgregarUsuario.TabIndex = 13;
            this.lblAgregarUsuario.Text = "Agregar \r\nUsuario";
            this.lblAgregarUsuario.Visible = false;
            this.lblAgregarUsuario.Click += new System.EventHandler(this.lblAgregarUsuario_Click);
            // 
            // lblIniciar
            // 
            this.lblIniciar.AutoSize = true;
            this.lblIniciar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIniciar.Font = new System.Drawing.Font("Lucida Calligraphy", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIniciar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblIniciar.Location = new System.Drawing.Point(34, 74);
            this.lblIniciar.Name = "lblIniciar";
            this.lblIniciar.Size = new System.Drawing.Size(133, 39);
            this.lblIniciar.TabIndex = 12;
            this.lblIniciar.Text = "Iniciar";
            this.lblIniciar.Click += new System.EventHandler(this.lblIniciar_Click);
            // 
            // lblLogout
            // 
            this.lblLogout.AutoSize = true;
            this.lblLogout.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLogout.Font = new System.Drawing.Font("Lucida Calligraphy", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLogout.Location = new System.Drawing.Point(34, 576);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(129, 39);
            this.lblLogout.TabIndex = 11;
            this.lblLogout.Text = "Logout";
            this.lblLogout.Click += new System.EventHandler(this.lblLogout_Click);
            // 
            // panelCenter
            // 
            this.panelCenter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(200, 60);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(1080, 660);
            this.panelCenter.TabIndex = 2;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.panelLeftSide);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JJPM Software          [Software]";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxRestore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxClose)).EndInit();
            this.panelLeftSide.ResumeLayout(false);
            this.panelLeftSide.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelLeftSide;
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.PictureBox pboxMin;
        private System.Windows.Forms.PictureBox pboxMax;
        private System.Windows.Forms.PictureBox pboxRestore;
        private System.Windows.Forms.PictureBox pboxClose;
        private System.Windows.Forms.Label lblIniciar;
        private System.Windows.Forms.Label lblLogout;
        private System.Windows.Forms.Label lblAgregarUsuario;
        private System.Windows.Forms.Label lblTituloCentral;
    }
}

