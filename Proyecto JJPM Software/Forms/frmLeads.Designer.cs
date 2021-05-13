namespace Proyecto_JJPM_Software.Forms
{
    partial class frmLeads
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
            this.DG = new System.Windows.Forms.DataGridView();
            this.TBManager = new System.Windows.Forms.TextBox();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.TBCorreo = new System.Windows.Forms.TextBox();
            this.TBDireccion = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblManager = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.BTNInsert = new System.Windows.Forms.Button();
            this.BTNDelete = new System.Windows.Forms.Button();
            this.lblidLeadEliminar = new System.Windows.Forms.Label();
            this.TBIdDelete = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblidLead = new System.Windows.Forms.Label();
            this.TBIdInsert = new System.Windows.Forms.TextBox();
            this.cBoxZona = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblLetreroDerecho = new System.Windows.Forms.Label();
            this.lblLetreroIzquierdo = new System.Windows.Forms.Label();
            this.mtxtTelefono = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DG)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // DG
            // 
            this.DG.AllowUserToAddRows = false;
            this.DG.AllowUserToDeleteRows = false;
            this.DG.AllowUserToOrderColumns = true;
            this.DG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG.Location = new System.Drawing.Point(0, 464);
            this.DG.Name = "DG";
            this.DG.ReadOnly = true;
            this.DG.Size = new System.Drawing.Size(1080, 196);
            this.DG.TabIndex = 0;
            this.DG.TabStop = false;
            // 
            // TBManager
            // 
            this.TBManager.Location = new System.Drawing.Point(110, 165);
            this.TBManager.MaxLength = 30;
            this.TBManager.Name = "TBManager";
            this.TBManager.Size = new System.Drawing.Size(273, 26);
            this.TBManager.TabIndex = 3;
            // 
            // TBNombre
            // 
            this.TBNombre.AcceptsTab = true;
            this.TBNombre.Location = new System.Drawing.Point(110, 85);
            this.TBNombre.MaxLength = 50;
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(274, 26);
            this.TBNombre.TabIndex = 1;
            // 
            // TBCorreo
            // 
            this.TBCorreo.Location = new System.Drawing.Point(110, 205);
            this.TBCorreo.Name = "TBCorreo";
            this.TBCorreo.Size = new System.Drawing.Size(273, 26);
            this.TBCorreo.TabIndex = 4;
            // 
            // TBDireccion
            // 
            this.TBDireccion.Location = new System.Drawing.Point(110, 245);
            this.TBDireccion.Name = "TBDireccion";
            this.TBDireccion.Size = new System.Drawing.Size(273, 26);
            this.TBDireccion.TabIndex = 5;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(20, 88);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 20);
            this.lblNombre.TabIndex = 11;
            this.lblNombre.Text = "Nombre";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(20, 128);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(78, 20);
            this.lblTelefono.TabIndex = 12;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblManager
            // 
            this.lblManager.AutoSize = true;
            this.lblManager.Location = new System.Drawing.Point(20, 168);
            this.lblManager.Name = "lblManager";
            this.lblManager.Size = new System.Drawing.Size(74, 20);
            this.lblManager.TabIndex = 13;
            this.lblManager.Text = "Manager";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(20, 208);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(61, 20);
            this.lblCorreo.TabIndex = 14;
            this.lblCorreo.Text = "Correo";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(20, 248);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(84, 20);
            this.lblDireccion.TabIndex = 15;
            this.lblDireccion.Text = "Direccion";
            // 
            // BTNInsert
            // 
            this.BTNInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNInsert.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNInsert.Location = new System.Drawing.Point(115, 380);
            this.BTNInsert.Name = "BTNInsert";
            this.BTNInsert.Size = new System.Drawing.Size(195, 59);
            this.BTNInsert.TabIndex = 7;
            this.BTNInsert.Text = "Ingresar";
            this.BTNInsert.UseVisualStyleBackColor = true;
            this.BTNInsert.Click += new System.EventHandler(this.BTNInsert_Click);
            // 
            // BTNDelete
            // 
            this.BTNDelete.BackColor = System.Drawing.SystemColors.Control;
            this.BTNDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNDelete.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BTNDelete.Location = new System.Drawing.Point(855, 380);
            this.BTNDelete.Name = "BTNDelete";
            this.BTNDelete.Size = new System.Drawing.Size(195, 59);
            this.BTNDelete.TabIndex = 8;
            this.BTNDelete.Text = "Eliminar";
            this.BTNDelete.UseVisualStyleBackColor = false;
            this.BTNDelete.Click += new System.EventHandler(this.BTNDelete_Click);
            // 
            // lblidLeadEliminar
            // 
            this.lblidLeadEliminar.AutoSize = true;
            this.lblidLeadEliminar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblidLeadEliminar.Location = new System.Drawing.Point(809, 88);
            this.lblidLeadEliminar.Name = "lblidLeadEliminar";
            this.lblidLeadEliminar.Size = new System.Drawing.Size(137, 20);
            this.lblidLeadEliminar.TabIndex = 19;
            this.lblidLeadEliminar.Text = "Numero de Lead";
            // 
            // TBIdDelete
            // 
            this.TBIdDelete.Location = new System.Drawing.Point(950, 85);
            this.TBIdDelete.Name = "TBIdDelete";
            this.TBIdDelete.Size = new System.Drawing.Size(100, 26);
            this.TBIdDelete.TabIndex = 8;
            this.TBIdDelete.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBIdDelete_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 288);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Zona";
            // 
            // lblidLead
            // 
            this.lblidLead.AutoSize = true;
            this.lblidLead.Location = new System.Drawing.Point(844, 196);
            this.lblidLead.Name = "lblidLead";
            this.lblidLead.Size = new System.Drawing.Size(63, 20);
            this.lblidLead.TabIndex = 9;
            this.lblidLead.Text = "IdLead";
            // 
            // TBIdInsert
            // 
            this.TBIdInsert.Enabled = false;
            this.TBIdInsert.Location = new System.Drawing.Point(914, 193);
            this.TBIdInsert.Name = "TBIdInsert";
            this.TBIdInsert.Size = new System.Drawing.Size(30, 26);
            this.TBIdInsert.TabIndex = 1;
            this.TBIdInsert.TabStop = false;
            // 
            // cBoxZona
            // 
            this.cBoxZona.FormattingEnabled = true;
            this.cBoxZona.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cBoxZona.Location = new System.Drawing.Point(110, 285);
            this.cBoxZona.Name = "cBoxZona";
            this.cBoxZona.Size = new System.Drawing.Size(109, 28);
            this.cBoxZona.TabIndex = 6;
            this.cBoxZona.Text = "Selecciona";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel2.Location = new System.Drawing.Point(402, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(401, 412);
            this.panel2.TabIndex = 48;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panelTop.Controls.Add(this.lblLetreroDerecho);
            this.panelTop.Controls.Add(this.lblLetreroIzquierdo);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1080, 53);
            this.panelTop.TabIndex = 49;
            // 
            // lblLetreroDerecho
            // 
            this.lblLetreroDerecho.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLetreroDerecho.AutoSize = true;
            this.lblLetreroDerecho.Font = new System.Drawing.Font("Lucida Calligraphy", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetreroDerecho.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLetreroDerecho.Location = new System.Drawing.Point(825, 8);
            this.lblLetreroDerecho.Name = "lblLetreroDerecho";
            this.lblLetreroDerecho.Size = new System.Drawing.Size(252, 37);
            this.lblLetreroDerecho.TabIndex = 10;
            this.lblLetreroDerecho.Text = "Eliminar Lead";
            // 
            // lblLetreroIzquierdo
            // 
            this.lblLetreroIzquierdo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLetreroIzquierdo.AutoSize = true;
            this.lblLetreroIzquierdo.Font = new System.Drawing.Font("Lucida Calligraphy", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetreroIzquierdo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLetreroIzquierdo.Location = new System.Drawing.Point(101, 8);
            this.lblLetreroIzquierdo.Name = "lblLetreroIzquierdo";
            this.lblLetreroIzquierdo.Size = new System.Drawing.Size(243, 37);
            this.lblLetreroIzquierdo.TabIndex = 9;
            this.lblLetreroIzquierdo.Text = "Agregar Lead";
            // 
            // mtxtTelefono
            // 
            this.mtxtTelefono.Location = new System.Drawing.Point(110, 125);
            this.mtxtTelefono.Mask = "000-000-0000";
            this.mtxtTelefono.Name = "mtxtTelefono";
            this.mtxtTelefono.Size = new System.Drawing.Size(273, 26);
            this.mtxtTelefono.TabIndex = 2;
            // 
            // frmLeads
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 660);
            this.Controls.Add(this.mtxtTelefono);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cBoxZona);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblidLeadEliminar);
            this.Controls.Add(this.TBIdDelete);
            this.Controls.Add(this.BTNDelete);
            this.Controls.Add(this.BTNInsert);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblManager);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblidLead);
            this.Controls.Add(this.TBDireccion);
            this.Controls.Add(this.TBCorreo);
            this.Controls.Add(this.TBNombre);
            this.Controls.Add(this.TBManager);
            this.Controls.Add(this.TBIdInsert);
            this.Controls.Add(this.DG);
            this.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmLeads";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmLeads";
            ((System.ComponentModel.ISupportInitialize)(this.DG)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.DataGridView DG;
		private System.Windows.Forms.TextBox TBManager;
		private System.Windows.Forms.TextBox TBNombre;
		private System.Windows.Forms.TextBox TBCorreo;
		private System.Windows.Forms.TextBox TBDireccion;
		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.Label lblTelefono;
		private System.Windows.Forms.Label lblManager;
		private System.Windows.Forms.Label lblCorreo;
		private System.Windows.Forms.Label lblDireccion;
		private System.Windows.Forms.Button BTNInsert;
		private System.Windows.Forms.Button BTNDelete;
		private System.Windows.Forms.Label lblidLeadEliminar;
		private System.Windows.Forms.TextBox TBIdDelete;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label lblidLead;
		private System.Windows.Forms.TextBox TBIdInsert;
        private System.Windows.Forms.ComboBox cBoxZona;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblLetreroDerecho;
        private System.Windows.Forms.Label lblLetreroIzquierdo;
        private System.Windows.Forms.MaskedTextBox mtxtTelefono;
    }
}