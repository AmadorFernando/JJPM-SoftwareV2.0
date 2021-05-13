namespace Proyecto_JJPM_Software.Forms
{
    partial class frmCaller
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
            this.DGCaller = new System.Windows.Forms.DataGridView();
            this.TBIdCaller = new System.Windows.Forms.TextBox();
            this.TBComentario = new System.Windows.Forms.TextBox();
            this.TBIdLead = new System.Windows.Forms.TextBox();
            this.lblidCaller = new System.Windows.Forms.Label();
            this.lblidLead = new System.Windows.Forms.Label();
            this.lblAccion = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BTNInsert = new System.Windows.Forms.Button();
            this.BTNDelete = new System.Windows.Forms.Button();
            this.TBIdDelete = new System.Windows.Forms.TextBox();
            this.lblIdcallerEliminar = new System.Windows.Forms.Label();
            this.DGLeads = new System.Windows.Forms.DataGridView();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboxAccion = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblLetreroDerecho = new System.Windows.Forms.Label();
            this.lblLetreroIzquierdo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGCaller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGLeads)).BeginInit();
            this.panelCenter.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGCaller
            // 
            this.DGCaller.AllowUserToAddRows = false;
            this.DGCaller.AllowUserToDeleteRows = false;
            this.DGCaller.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGCaller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGCaller.Location = new System.Drawing.Point(1, 412);
            this.DGCaller.Name = "DGCaller";
            this.DGCaller.ReadOnly = true;
            this.DGCaller.Size = new System.Drawing.Size(1079, 195);
            this.DGCaller.TabIndex = 30;
            this.DGCaller.TabStop = false;
            // 
            // TBIdCaller
            // 
            this.TBIdCaller.Enabled = false;
            this.TBIdCaller.Location = new System.Drawing.Point(108, 9);
            this.TBIdCaller.Name = "TBIdCaller";
            this.TBIdCaller.Size = new System.Drawing.Size(40, 26);
            this.TBIdCaller.TabIndex = 31;
            this.TBIdCaller.TabStop = false;
            // 
            // TBComentario
            // 
            this.TBComentario.Location = new System.Drawing.Point(278, 18);
            this.TBComentario.MaxLength = 500;
            this.TBComentario.Multiline = true;
            this.TBComentario.Name = "TBComentario";
            this.TBComentario.Size = new System.Drawing.Size(208, 81);
            this.TBComentario.TabIndex = 3;
            // 
            // TBIdLead
            // 
            this.TBIdLead.AcceptsTab = true;
            this.TBIdLead.Location = new System.Drawing.Point(107, 41);
            this.TBIdLead.MaxLength = 30;
            this.TBIdLead.Name = "TBIdLead";
            this.TBIdLead.Size = new System.Drawing.Size(41, 26);
            this.TBIdLead.TabIndex = 1;
            // 
            // lblidCaller
            // 
            this.lblidCaller.AutoSize = true;
            this.lblidCaller.Location = new System.Drawing.Point(38, 12);
            this.lblidCaller.Name = "lblidCaller";
            this.lblidCaller.Size = new System.Drawing.Size(70, 20);
            this.lblidCaller.TabIndex = 37;
            this.lblidCaller.Text = "IdCaller";
            // 
            // lblidLead
            // 
            this.lblidLead.AutoSize = true;
            this.lblidLead.Location = new System.Drawing.Point(38, 44);
            this.lblidLead.Name = "lblidLead";
            this.lblidLead.Size = new System.Drawing.Size(63, 20);
            this.lblidLead.TabIndex = 39;
            this.lblidLead.Text = "IdLead";
            // 
            // lblAccion
            // 
            this.lblAccion.AutoSize = true;
            this.lblAccion.Location = new System.Drawing.Point(39, 76);
            this.lblAccion.Name = "lblAccion";
            this.lblAccion.Size = new System.Drawing.Size(63, 20);
            this.lblAccion.TabIndex = 40;
            this.lblAccion.Text = "Accion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(160, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 41;
            this.label5.Text = "Comentarios";
            // 
            // BTNInsert
            // 
            this.BTNInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNInsert.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNInsert.Location = new System.Drawing.Point(142, 108);
            this.BTNInsert.Name = "BTNInsert";
            this.BTNInsert.Size = new System.Drawing.Size(195, 59);
            this.BTNInsert.TabIndex = 4;
            this.BTNInsert.Text = "Ingresar";
            this.BTNInsert.UseVisualStyleBackColor = true;
            this.BTNInsert.Click += new System.EventHandler(this.BTNInsert_Click_1);
            // 
            // BTNDelete
            // 
            this.BTNDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.BTNDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNDelete.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BTNDelete.Location = new System.Drawing.Point(832, 108);
            this.BTNDelete.Name = "BTNDelete";
            this.BTNDelete.Size = new System.Drawing.Size(195, 59);
            this.BTNDelete.TabIndex = 45;
            this.BTNDelete.Text = "Eliminar";
            this.BTNDelete.UseVisualStyleBackColor = false;
            this.BTNDelete.Click += new System.EventHandler(this.BTNDelete_Click_1);
            // 
            // TBIdDelete
            // 
            this.TBIdDelete.Location = new System.Drawing.Point(924, 18);
            this.TBIdDelete.Name = "TBIdDelete";
            this.TBIdDelete.Size = new System.Drawing.Size(56, 26);
            this.TBIdDelete.TabIndex = 5;
            // 
            // lblIdcallerEliminar
            // 
            this.lblIdcallerEliminar.AutoSize = true;
            this.lblIdcallerEliminar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblIdcallerEliminar.Location = new System.Drawing.Point(768, 21);
            this.lblIdcallerEliminar.Name = "lblIdcallerEliminar";
            this.lblIdcallerEliminar.Size = new System.Drawing.Size(144, 20);
            this.lblIdcallerEliminar.TabIndex = 47;
            this.lblIdcallerEliminar.Text = "Numero de Caller";
            // 
            // DGLeads
            // 
            this.DGLeads.AllowUserToAddRows = false;
            this.DGLeads.AllowUserToDeleteRows = false;
            this.DGLeads.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DGLeads.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGLeads.Location = new System.Drawing.Point(1, 178);
            this.DGLeads.Name = "DGLeads";
            this.DGLeads.ReadOnly = true;
            this.DGLeads.Size = new System.Drawing.Size(1079, 198);
            this.DGLeads.TabIndex = 54;
            this.DGLeads.TabStop = false;
            // 
            // panelCenter
            // 
            this.panelCenter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCenter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.panelCenter.Controls.Add(this.panel2);
            this.panelCenter.Controls.Add(this.cboxAccion);
            this.panelCenter.Controls.Add(this.panel1);
            this.panelCenter.Controls.Add(this.DGLeads);
            this.panelCenter.Controls.Add(this.lblIdcallerEliminar);
            this.panelCenter.Controls.Add(this.TBIdDelete);
            this.panelCenter.Controls.Add(this.BTNDelete);
            this.panelCenter.Controls.Add(this.BTNInsert);
            this.panelCenter.Controls.Add(this.label5);
            this.panelCenter.Controls.Add(this.lblAccion);
            this.panelCenter.Controls.Add(this.lblidLead);
            this.panelCenter.Controls.Add(this.lblidCaller);
            this.panelCenter.Controls.Add(this.TBIdLead);
            this.panelCenter.Controls.Add(this.TBComentario);
            this.panelCenter.Controls.Add(this.TBIdCaller);
            this.panelCenter.Controls.Add(this.DGCaller);
            this.panelCenter.Location = new System.Drawing.Point(0, 53);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(1080, 606);
            this.panelCenter.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel2.Location = new System.Drawing.Point(492, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 179);
            this.panel2.TabIndex = 57;
            // 
            // cboxAccion
            // 
            this.cboxAccion.FormattingEnabled = true;
            this.cboxAccion.Items.AddRange(new object[] {
            "C",
            "B/V",
            "D/C",
            "N/I"});
            this.cboxAccion.Location = new System.Drawing.Point(108, 74);
            this.cboxAccion.Name = "cboxAccion";
            this.cboxAccion.Size = new System.Drawing.Size(107, 28);
            this.cboxAccion.TabIndex = 2;
            this.cboxAccion.Text = "Selecciona";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel1.Location = new System.Drawing.Point(1, 376);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1079, 36);
            this.panel1.TabIndex = 56;
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
            this.panelTop.TabIndex = 50;
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
            this.lblLetreroDerecho.Size = new System.Drawing.Size(175, 37);
            this.lblLetreroDerecho.TabIndex = 10;
            this.lblLetreroDerecho.Text = "Eliminar ";
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
            this.lblLetreroIzquierdo.Size = new System.Drawing.Size(166, 37);
            this.lblLetreroIzquierdo.TabIndex = 9;
            this.lblLetreroIzquierdo.Text = "Agregar ";
            // 
            // frmCaller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 660);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelCenter);
            this.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmCaller";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmCaller";
            ((System.ComponentModel.ISupportInitialize)(this.DGCaller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGLeads)).EndInit();
            this.panelCenter.ResumeLayout(false);
            this.panelCenter.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGCaller;
        private System.Windows.Forms.TextBox TBIdCaller;
        private System.Windows.Forms.TextBox TBComentario;
        private System.Windows.Forms.TextBox TBIdLead;
        private System.Windows.Forms.Label lblidCaller;
        private System.Windows.Forms.Label lblidLead;
        private System.Windows.Forms.Label lblAccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BTNInsert;
        private System.Windows.Forms.Button BTNDelete;
        private System.Windows.Forms.TextBox TBIdDelete;
        private System.Windows.Forms.Label lblIdcallerEliminar;
        private System.Windows.Forms.DataGridView DGLeads;
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblLetreroDerecho;
        private System.Windows.Forms.Label lblLetreroIzquierdo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboxAccion;
        private System.Windows.Forms.Panel panel2;
    }
}