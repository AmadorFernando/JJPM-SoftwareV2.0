namespace Proyecto_JJPM_Software.Forms
{
    partial class frmAgregarUsuario
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
            this.lblidUsuario = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellidoP = new System.Windows.Forms.Label();
            this.lblApellidoM = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblIngreso = new System.Windows.Forms.Label();
            this.TBPass = new System.Windows.Forms.TextBox();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.TBAp = new System.Windows.Forms.TextBox();
            this.TBAm = new System.Windows.Forms.TextBox();
            this.TBIdInsert = new System.Windows.Forms.TextBox();
            this.DG = new System.Windows.Forms.DataGridView();
            this.TBIdDelete = new System.Windows.Forms.TextBox();
            this.BTNDelete = new System.Windows.Forms.Button();
            this.BTNInsert = new System.Windows.Forms.Button();
            this.TBNombre2 = new System.Windows.Forms.TextBox();
            this.lblNombre2 = new System.Windows.Forms.Label();
            this.cBoxTipo = new System.Windows.Forms.ComboBox();
            this.pboxPassVisual = new System.Windows.Forms.PictureBox();
            this.dateTPIngreso = new System.Windows.Forms.DateTimePicker();
            this.panelTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTituloCentral = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPassVisual)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblidUsuario
            // 
            this.lblidUsuario.AutoSize = true;
            this.lblidUsuario.Location = new System.Drawing.Point(61, 345);
            this.lblidUsuario.Name = "lblidUsuario";
            this.lblidUsuario.Size = new System.Drawing.Size(84, 20);
            this.lblidUsuario.TabIndex = 0;
            this.lblidUsuario.Text = "IdUsuario";
            this.lblidUsuario.Visible = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(20, 73);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 20);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellidoP
            // 
            this.lblApellidoP.AutoSize = true;
            this.lblApellidoP.Location = new System.Drawing.Point(20, 153);
            this.lblApellidoP.Name = "lblApellidoP";
            this.lblApellidoP.Size = new System.Drawing.Size(139, 20);
            this.lblApellidoP.TabIndex = 2;
            this.lblApellidoP.Text = "Apellido Paterno";
            // 
            // lblApellidoM
            // 
            this.lblApellidoM.AutoSize = true;
            this.lblApellidoM.Location = new System.Drawing.Point(20, 193);
            this.lblApellidoM.Name = "lblApellidoM";
            this.lblApellidoM.Size = new System.Drawing.Size(144, 20);
            this.lblApellidoM.TabIndex = 3;
            this.lblApellidoM.Text = "Apellido Materno";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(20, 235);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(95, 20);
            this.lblPass.TabIndex = 5;
            this.lblPass.Text = "Contraseña";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(20, 273);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(44, 20);
            this.lblTipo.TabIndex = 6;
            this.lblTipo.Text = "Tipo";
            // 
            // lblIngreso
            // 
            this.lblIngreso.AutoSize = true;
            this.lblIngreso.Location = new System.Drawing.Point(20, 315);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(122, 20);
            this.lblIngreso.TabIndex = 7;
            this.lblIngreso.Text = "Dia de Ingreso";
            // 
            // TBPass
            // 
            this.TBPass.Location = new System.Drawing.Point(170, 230);
            this.TBPass.MaxLength = 20;
            this.TBPass.Name = "TBPass";
            this.TBPass.PasswordChar = '·';
            this.TBPass.Size = new System.Drawing.Size(122, 26);
            this.TBPass.TabIndex = 5;
            // 
            // TBNombre
            // 
            this.TBNombre.Location = new System.Drawing.Point(170, 70);
            this.TBNombre.MaxLength = 25;
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(123, 26);
            this.TBNombre.TabIndex = 1;
            this.TBNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBNombre_KeyPress);
            // 
            // TBAp
            // 
            this.TBAp.Location = new System.Drawing.Point(170, 150);
            this.TBAp.MaxLength = 20;
            this.TBAp.Name = "TBAp";
            this.TBAp.Size = new System.Drawing.Size(122, 26);
            this.TBAp.TabIndex = 3;
            this.TBAp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBAp_KeyPress);
            // 
            // TBAm
            // 
            this.TBAm.Location = new System.Drawing.Point(170, 190);
            this.TBAm.MaxLength = 20;
            this.TBAm.Name = "TBAm";
            this.TBAm.Size = new System.Drawing.Size(122, 26);
            this.TBAm.TabIndex = 4;
            this.TBAm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBAm_KeyPress);
            // 
            // TBIdInsert
            // 
            this.TBIdInsert.Enabled = false;
            this.TBIdInsert.Location = new System.Drawing.Point(151, 345);
            this.TBIdInsert.Name = "TBIdInsert";
            this.TBIdInsert.Size = new System.Drawing.Size(122, 26);
            this.TBIdInsert.TabIndex = 25;
            this.TBIdInsert.TabStop = false;
            this.TBIdInsert.Visible = false;
            // 
            // DG
            // 
            this.DG.AllowUserToDeleteRows = false;
            this.DG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG.Location = new System.Drawing.Point(0, 464);
            this.DG.Name = "DG";
            this.DG.ReadOnly = true;
            this.DG.Size = new System.Drawing.Size(1080, 196);
            this.DG.TabIndex = 35;
            this.DG.TabStop = false;
            // 
            // TBIdDelete
            // 
            this.TBIdDelete.Location = new System.Drawing.Point(936, 70);
            this.TBIdDelete.Name = "TBIdDelete";
            this.TBIdDelete.Size = new System.Drawing.Size(124, 26);
            this.TBIdDelete.TabIndex = 9;
            this.TBIdDelete.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBIdDelete_KeyPress);
            // 
            // BTNDelete
            // 
            this.BTNDelete.BackColor = System.Drawing.SystemColors.Control;
            this.BTNDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNDelete.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BTNDelete.Location = new System.Drawing.Point(824, 377);
            this.BTNDelete.Name = "BTNDelete";
            this.BTNDelete.Size = new System.Drawing.Size(195, 59);
            this.BTNDelete.TabIndex = 10;
            this.BTNDelete.Text = "Eliminar";
            this.BTNDelete.UseVisualStyleBackColor = false;
            this.BTNDelete.Click += new System.EventHandler(this.BTNDelete_Click_1);
            // 
            // BTNInsert
            // 
            this.BTNInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNInsert.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNInsert.Location = new System.Drawing.Point(71, 378);
            this.BTNInsert.Name = "BTNInsert";
            this.BTNInsert.Size = new System.Drawing.Size(195, 59);
            this.BTNInsert.TabIndex = 8;
            this.BTNInsert.Text = "Ingresar";
            this.BTNInsert.UseVisualStyleBackColor = true;
            this.BTNInsert.Click += new System.EventHandler(this.BTNInsert_Click_1);
            // 
            // TBNombre2
            // 
            this.TBNombre2.Location = new System.Drawing.Point(170, 110);
            this.TBNombre2.MaxLength = 25;
            this.TBNombre2.Name = "TBNombre2";
            this.TBNombre2.Size = new System.Drawing.Size(123, 26);
            this.TBNombre2.TabIndex = 2;
            this.TBNombre2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBNombre2_KeyPress);
            // 
            // lblNombre2
            // 
            this.lblNombre2.AutoSize = true;
            this.lblNombre2.Location = new System.Drawing.Point(20, 113);
            this.lblNombre2.Name = "lblNombre2";
            this.lblNombre2.Size = new System.Drawing.Size(141, 20);
            this.lblNombre2.TabIndex = 40;
            this.lblNombre2.Text = "Segundo Nombre";
            // 
            // cBoxTipo
            // 
            this.cBoxTipo.FormattingEnabled = true;
            this.cBoxTipo.Items.AddRange(new object[] {
            "Caller",
            "Leads"});
            this.cBoxTipo.Location = new System.Drawing.Point(170, 270);
            this.cBoxTipo.Name = "cBoxTipo";
            this.cBoxTipo.Size = new System.Drawing.Size(121, 28);
            this.cBoxTipo.TabIndex = 6;
            this.cBoxTipo.Text = "Selecciona...";
            // 
            // pboxPassVisual
            // 
            this.pboxPassVisual.Image = global::Proyecto_JJPM_Software.Properties.Resources.Ojito;
            this.pboxPassVisual.Location = new System.Drawing.Point(298, 230);
            this.pboxPassVisual.Name = "pboxPassVisual";
            this.pboxPassVisual.Size = new System.Drawing.Size(28, 26);
            this.pboxPassVisual.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxPassVisual.TabIndex = 43;
            this.pboxPassVisual.TabStop = false;
            this.pboxPassVisual.Click += new System.EventHandler(this.pboxPassVisual_Click);
            // 
            // dateTPIngreso
            // 
            this.dateTPIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTPIngreso.Location = new System.Drawing.Point(170, 310);
            this.dateTPIngreso.Name = "dateTPIngreso";
            this.dateTPIngreso.Size = new System.Drawing.Size(124, 26);
            this.dateTPIngreso.TabIndex = 7;
            // 
            // panelTop
            // 
            this.panelTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.lblTituloCentral);
            this.panelTop.Location = new System.Drawing.Point(0, -1);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1080, 53);
            this.panelTop.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(757, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "Eliminar Usuario";
            // 
            // lblTituloCentral
            // 
            this.lblTituloCentral.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTituloCentral.AutoSize = true;
            this.lblTituloCentral.Font = new System.Drawing.Font("Lucida Calligraphy", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCentral.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTituloCentral.Location = new System.Drawing.Point(20, 8);
            this.lblTituloCentral.Name = "lblTituloCentral";
            this.lblTituloCentral.Size = new System.Drawing.Size(297, 37);
            this.lblTituloCentral.TabIndex = 9;
            this.lblTituloCentral.Text = "Agregar Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(786, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 48;
            this.label2.Text = "Usuario";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel2.Location = new System.Drawing.Point(351, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(401, 412);
            this.panel2.TabIndex = 47;
            // 
            // frmAgregarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 660);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTNDelete);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.dateTPIngreso);
            this.Controls.Add(this.pboxPassVisual);
            this.Controls.Add(this.cBoxTipo);
            this.Controls.Add(this.TBNombre2);
            this.Controls.Add(this.lblNombre2);
            this.Controls.Add(this.BTNInsert);
            this.Controls.Add(this.TBIdDelete);
            this.Controls.Add(this.DG);
            this.Controls.Add(this.TBPass);
            this.Controls.Add(this.TBNombre);
            this.Controls.Add(this.TBAp);
            this.Controls.Add(this.TBAm);
            this.Controls.Add(this.TBIdInsert);
            this.Controls.Add(this.lblIngreso);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblApellidoM);
            this.Controls.Add(this.lblApellidoP);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblidUsuario);
            this.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmAgregarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAgregarUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.DG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPassVisual)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Label lblidUsuario;
		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.Label lblApellidoP;
		private System.Windows.Forms.Label lblApellidoM;
		private System.Windows.Forms.Label lblPass;
		private System.Windows.Forms.Label lblTipo;
		private System.Windows.Forms.Label lblIngreso;
		private System.Windows.Forms.TextBox TBPass;
		private System.Windows.Forms.TextBox TBNombre;
		private System.Windows.Forms.TextBox TBAp;
		private System.Windows.Forms.TextBox TBAm;
		private System.Windows.Forms.TextBox TBIdInsert;
		private System.Windows.Forms.DataGridView DG;
		private System.Windows.Forms.TextBox TBIdDelete;
		private System.Windows.Forms.Button BTNDelete;
		private System.Windows.Forms.Button BTNInsert;
        private System.Windows.Forms.TextBox TBNombre2;
        private System.Windows.Forms.Label lblNombre2;
        private System.Windows.Forms.ComboBox cBoxTipo;
        private System.Windows.Forms.PictureBox pboxPassVisual;
        private System.Windows.Forms.DateTimePicker dateTPIngreso;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTituloCentral;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
    }
}