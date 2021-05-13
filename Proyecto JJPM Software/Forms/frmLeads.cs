using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_JJPM_Software.Clases;

namespace Proyecto_JJPM_Software.Forms
{
    public partial class frmLeads : Form
    {

        //public SqlConnection ConexionBD = new SqlConnection("Data Source=ASUS-A\\ADMINISTRACIONBD;Initial Catalog=PruebaCSharpSQL;Integrated Security=True");
        public SqlConnection ConexionBD = new SqlConnection("Data Source=DESKTOP-PRRK88P;Initial Catalog=PruebaCSharpSQL;Integrated Security= True");
        public DataSet ds;

		public frmLeads()
        {
            InitializeComponent();
			DG.DataSource = Seleccionar();
            //TBIdInsert.Text = DG.Rows.Count.ToString();
            TBIdInsert.Text = Convert.ToString(DG.Rows.Count + 1);
        }


		public DataTable Seleccionar()
		{
			SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Leads", ConexionBD);
			SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
			ds = new DataSet();
			da.Fill(ds, "Leads");
			ConexionBD.Close();
			return ds.Tables["Leads"];
		}

		public bool Insertar(/*atributos*/ string idLead, string Fecha, string Nombre, string Telefono, string Manager, string Correo, string Direccion, string Zona)
		{
			ConexionBD.Open();
			SqlCommand sqlCommand = new SqlCommand(string.Format("Insert into Leads values ({0}, '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', {7})", new string[] { idLead, Fecha, Nombre, Telefono, Manager, Correo, Direccion, Zona }), ConexionBD);
            //TBIdInsert.Text = DG.Rows.Count.ToString();
            TBIdInsert.Text = Convert.ToString(DG.Rows.Count);
            int filasafectadas = sqlCommand.ExecuteNonQuery();
			if (filasafectadas > 0) return true;
			else return false;
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
                    MessageBox.Show("Selecciona una zona valida", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
       
                if (Insertar(TBIdInsert.Text, Fecha, TBNombre.Text, mas, TBManager.Text, TBCorreo.Text, TBDireccion.Text, Zona))
                {
                    MessageBox.Show("Datos insertados correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TBIdInsert.Text = Convert.ToString(DG.Rows.Count);
                    DG.DataSource = Seleccionar();

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

		public bool Eliminar(string idLead)
		{
			ConexionBD.Open();
			SqlCommand sqlCommand = new SqlCommand(string.Format("Delete from Leads where IdLead = {0}", idLead), ConexionBD);
			int filasafectadas = sqlCommand.ExecuteNonQuery();
            TBIdInsert.Text =Convert.ToString(DG.Rows.Count);
            ConexionBD.Close();
			if (filasafectadas > 0) return true;
			else return false;
		}
		private void BTNDelete_Click(object sender, EventArgs e)
		{
            DialogResult dr = MessageBox.Show("¿Estas seguro que deseas eliminar a este Lead?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.Yes && !(string.IsNullOrWhiteSpace(TBIdDelete.Text)))
            {
                if (Eliminar(TBIdDelete.Text))
                {
                    MessageBox.Show("Datos Eliminados con exito.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TBIdInsert.Text = DG.Rows.Count.ToString();
                    DG.DataSource = Seleccionar();
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

    }
}
