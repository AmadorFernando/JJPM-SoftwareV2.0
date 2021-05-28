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
        string LocalUsuario = "";
        

		public frmLeads(string usuario)
        {
            InitializeComponent();
            LocalUsuario = usuario;
            DG.DataSource = Seleccionar();
        }


		public DataTable Seleccionar()
		{
			SqlCommand sqlCommand = new SqlCommand("select * from TemporalLeads where Usuario=@Usuario;", ConexionBD);
            SqlParameter parametro = new SqlParameter();
            sqlCommand.Parameters.Add(new SqlParameter("@Usuario", LocalUsuario));
			SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
			ds = new DataSet();
			da.Fill(ds, "Leads");
			ConexionBD.Close();
			return ds.Tables["Leads"];
		}

		public bool Insertar( string Fecha, string Nombre, string Telefono, string Manager, string Correo, string Direccion, string Zona)
		{
			ConexionBD.Open();
            SqlCommand cmd = new SqlCommand("Insert into TemporalLeads values(@Usuario,@Fecha,@Nombre,@Telefono,@Manager,@Correo,@Direccion,@Zona)",ConexionBD);
            cmd.Parameters.Add(new SqlParameter("@Usuario", LocalUsuario));
            cmd.Parameters.Add(new SqlParameter("@Fecha", Convert.ToDateTime(Fecha)));
            cmd.Parameters.Add(new SqlParameter("@Nombre", Nombre));
            cmd.Parameters.Add(new SqlParameter("@Telefono", Telefono));
            cmd.Parameters.Add(new SqlParameter("@Manager", Manager));
            cmd.Parameters.Add(new SqlParameter("@Correo", Correo));
            cmd.Parameters.Add(new SqlParameter("@Direccion", Direccion));
            cmd.Parameters.Add(new SqlParameter("@Zona", Zona));

            int filasafectadas = cmd.ExecuteNonQuery();
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
                if (Insertar( Fecha, TBNombre.Text, mas, TBManager.Text, TBCorreo.Text, TBDireccion.Text, Zona))
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
			SqlCommand sqlCommand = new SqlCommand(string.Format("Delete from TemporalLeads where idTemp = {0}", idLead), ConexionBD);
			int filasafectadas = sqlCommand.ExecuteNonQuery();
            //TBIdInsert.Text =Convert.ToString(DG.Rows.Count);
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

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            DialogResult dr =MessageBox.Show("¿Estas seguro que deseas enviar los datos almacenados?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (dr==DialogResult.OK)
            {

            }
        }
    }
}
