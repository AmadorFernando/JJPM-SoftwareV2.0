using System;
using System.Windows.Forms;
using Proyecto_JJPM_Software.Clases;

namespace Proyecto_JJPM_Software.Forms
{
    public partial class frmLeads : Form
    {
        // Instancia de Database Manage
        private DatabaseManage dbManage;
        // Usuario
        protected string LocalUsuario;
        

		public frmLeads(string usuario)
        {
            InitializeComponent();
            LocalUsuario = usuario;
            dbManage = new DatabaseManage();
        }		

		private void BTNInsert_Click(object sender, EventArgs e)
		{
            //Zona
            string Zona = "";
            switch (cBoxZona.Text)
            {
                case "1":
                    Zona = "1";
                    break;
                case "2":
                    Zona = "2";
                    break;
                case "3":
                    Zona = "3";
                    break;
                case "4":
                    Zona = "4";
                    break;
                case "5":
                    Zona = "5";
                    break;
                case "6":
                    Zona = "6";
                    break;
                default:
                    //if (Zona == "" || (mtxtTelefono.Text.Length < 12) || string.IsNullOrWhiteSpace(TBNombre.Text) || string.IsNullOrWhiteSpace(mtxtTelefono.Text) || string.IsNullOrWhiteSpace(TBManager.Text) || string.IsNullOrWhiteSpace(TBCorreo.Text) || string.IsNullOrWhiteSpace(TBDireccion.Text))
                    //{
                    //    MessageBox.Show("Falta ingresar informacion necesaria", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Selecciona una zona valida", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //}
                    break;
            }
            //Telefono
            string mas = mtxtTelefono.Text;

            if (Zona==""||(mas.Length<12)||string.IsNullOrWhiteSpace(TBNombre.Text) || string.IsNullOrWhiteSpace(mtxtTelefono.Text) || string.IsNullOrWhiteSpace(TBManager.Text) || string.IsNullOrWhiteSpace(TBCorreo.Text) || string.IsNullOrWhiteSpace(TBDireccion.Text))
            {
                MessageBox.Show("Falta ingresar informacion necesaria", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                //Fecha Actual
                string Fecha = DateTime.Now.ToShortDateString();
                MessageBox.Show(Fecha);
                if (dbManage.InsertarLead(LocalUsuario, Fecha, TBNombre.Text, mas, TBManager.Text, TBCorreo.Text, TBDireccion.Text, Zona))
                {
                    MessageBox.Show("Datos insertados correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TBIdInsert.Text = Convert.ToString(DG.Rows.Count);
                    DG.DataSource = dbManage.SeleccionarLeads(LocalUsuario);

                    //Limpiamos las textbox
                    TBNombre.Clear();
                    mtxtTelefono.Clear();
                    TBManager.Clear();
                    TBCorreo.Clear();
                    TBDireccion.Clear();
                    TBNombre.Focus();
                }
                else
                {
                    MessageBox.Show("Los datos no fueron insertados correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
		}

		private void BTNDelete_Click(object sender, EventArgs e)
		{
            DialogResult dr = MessageBox.Show("¿Estas seguro que deseas eliminar a este Lead?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.Yes && !(string.IsNullOrWhiteSpace(TBIdDelete.Text)))
            {
                if (dbManage.EliminarLead(int.Parse(TBIdDelete.Text)))
                {
                    MessageBox.Show("Datos Eliminados con exito.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TBIdInsert.Text = DG.Rows.Count.ToString();
                    DG.DataSource = dbManage.SeleccionarLeads(LocalUsuario);
                }
                else
                {
                    MessageBox.Show("Datos No Eliminados", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Favor de ingresar el ID","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
		}

        private void TBIdDelete_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Estas seguro que deseas enviar los datos almacenados?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (dr==DialogResult.OK)
            {
                dbManage.IngresoLeadsDefinitivo(LocalUsuario);
                MessageBox.Show("Se ha enviado correctamente");
                DG.DataSource = dbManage.SeleccionarLeads(LocalUsuario);
            }
        }

        private void frmLeads_Load(object sender, EventArgs e)
        {
            DG.DataSource = dbManage.SeleccionarLeads(LocalUsuario);
        }
    }
}
