using Proyecto_JJPM_Software.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_JJPM_Software
{
    public partial class frmPrincipal : Form
    {
        //Esta variable guardara el ultimo click, para poder realizar el movimiento de la ventana.
        Point lastclick;
        //Esta variable guarda la informacion del usuario.
        string[] InfoUsuario;
        public frmPrincipal(string[] TipoUsu)
        {
            InitializeComponent();
            InfoUsuario = TipoUsu;
            lblTituloCentral.Text = "["+TipoUsu[0]+"]"+" "+TipoUsu[1];
            if (TipoUsu[0]=="Admin")
            {
                //Habilitamos el boton "Agregar Usuario"
                lblAgregarUsuario.Enabled = true;
                lblAgregarUsuario.Visible = true;
                lblIniciar.Enabled = false;
                lblIniciar.Visible = false;
            }
        }

        //Boton para guardar el valor del ultimo click.
        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            lastclick = e.Location;
        }

        //Boton para mover la ventana.
        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastclick.X;
                this.Top += e.Y - lastclick.Y;
            }
        }

        //Boton para minimizar la ventana.
        private void pboxMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //Boton para regresar el tamaño de la ventana al anterior.
        private void pboxRestore_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            pboxMax.Visible = true;
            pboxRestore.Visible = false;
        }

        //Boton para agrandar la ventana a tamaño completo.
        private void pboxMax_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            pboxMax.Visible = false;
            pboxRestore.Visible = true;
        }

        //Boton para cerrar la ventana.
        private void pboxClose_Click(object sender, EventArgs e)
        {
            DialogResult Dr=MessageBox.Show("¿Estas seguro que quieres cerrar la aplicacion?","Cerrar",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (Dr==DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void AbrirTipoUsuario(string Usuario)
        {
            if (Usuario == "Caller")
            {
                frmCaller frm = new frmCaller() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                this.panelCenter.Controls.Add(frm);
                frm.Show();
                lblIniciar.Enabled = false;
            }
            else if (Usuario == "Leads")
            {
                frmLeads frm1 = new frmLeads() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                this.panelCenter.Controls.Add(frm1);
                frm1.Show();
                lblIniciar.Enabled = false;
            }
            
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Estas seguro que deseas cerrar sesion?", "Cerrado de Sesion", MessageBoxButtons.YesNo,
            MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                this.Hide();
                var form1 = new frmLogin();
                form1.Closed += (s, args) => this.Close();
                form1.Show();
            }
        }

        private void lblIniciar_Click(object sender, EventArgs e)
        {
            AbrirTipoUsuario(InfoUsuario[0]);
        }

        private void lblAgregarUsuario_Click(object sender, EventArgs e)
        {
            frmAgregarUsuario frm2 = new frmAgregarUsuario() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panelCenter.Controls.Add(frm2);
            frm2.Show();
        }
    }
}
