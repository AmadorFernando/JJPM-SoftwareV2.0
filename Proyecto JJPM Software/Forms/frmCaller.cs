using System;
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
	public partial class frmCaller : Form
	{
        //Nombre, para que puse la clase que hace la conexion xD usala we, no hace falta hacer conexiones en cada form.
        //public SqlConnection ConexionBD = new SqlConnection("Data Source=ASUS-A\\ADMINISTRACIONBD;Initial Catalog=PruebaCSharpSQL;Integrated Security=True");
        public SqlConnection ConexionBD = new SqlConnection("Data Source=DESKTOP-PRRK88P;Initial Catalog=PruebaCSharpSQL;Integrated Security= True");
        public DataSet ds;

		public frmCaller()
		{
			InitializeComponent();
			DGLeads.DataSource = SeleccionarLeads();
			DGCaller.DataSource = SeleccionarCaller();
			TBIdCaller.Text = DGCaller.Rows.Count.ToString();
		}


		public DataTable SeleccionarCaller()
		{
			SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Caller", ConexionBD);
			SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
			ds = new DataSet();
			da.Fill(ds, "Caller");
			ConexionBD.Close();
			return ds.Tables["Caller"];
		}
		public bool Insertar(string idCaller, string idLeads, string Accion, string Comentario, string Ingreso)
		{
			ConexionBD.Open();
			SqlCommand sqlCommand = new SqlCommand(string.Format("Insert into Caller values ({0}, '{1}', '{2}', '{3}', '{4}')", new string[] { idCaller, idLeads, Accion, Comentario, Ingreso }), ConexionBD);
			int filasafectadas = sqlCommand.ExecuteNonQuery();
			if (filasafectadas > 0) return true;
			else return false;
		}
		public bool Eliminar(string idCaller)
		{
			ConexionBD.Open();
			SqlCommand sqlCommand = new SqlCommand(string.Format("Delete from Caller where idCaller = {0}", idCaller), ConexionBD);
			int filasafectadas = sqlCommand.ExecuteNonQuery();
			ConexionBD.Close();
			if (filasafectadas > 0) return true;
			else return false;
		}


		public DataTable SeleccionarLeads()
		{
			SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Leads", ConexionBD);
			SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
			ds = new DataSet();
			da.Fill(ds, "Leads");
			ConexionBD.Close();
			return ds.Tables["Leads"];
		}

		private void BTNInsert_Click_1(object sender, System.EventArgs e)
		{
            //Fecha Actual
            string Fecha = DateTime.Now.ToShortDateString();
            //Accion
            string Accion = "";

            switch (cboxAccion.Text)
            {
                case "C":
                    Accion = "C";
                    break;
                case "B/V":
                    Accion = "B/V";
                    break;
                case "D/C":
                    Accion = "D/C";
                    break;
                case "N/I":
                    Accion = "N/I";
                    break;
                default:
                    MessageBox.Show("Selecciona una accion valida", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
            if (string.IsNullOrWhiteSpace(TBIdLead.Text)||Accion=="")
            {
                MessageBox.Show("Falta ingresar informacion necesaria", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Insertar(TBIdCaller.Text, TBIdLead.Text, Accion, TBComentario.Text, Fecha))
                {
                    MessageBox.Show("Datos insertados correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TBIdCaller.Text = DGCaller.Rows.Count.ToString();
                    DGCaller.DataSource = SeleccionarCaller();

                    //Limpiamos las textbox
                    TBIdLead.Clear();
                    TBComentario.Clear();
                    TBIdLead.Focus();
                }
                else
                {
                    MessageBox.Show("Los datos no fueron insertados correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
		}

        private void BTNDelete_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Estas seguro que deseas eliminar a este registro?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.Yes && !(string.IsNullOrWhiteSpace(TBIdDelete.Text)))
            {
                if (Eliminar(TBIdDelete.Text))
                {
                    MessageBox.Show("Datos Eliminados con exito.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TBIdCaller.Text = DGCaller.Rows.Count.ToString();
                    DGCaller.DataSource = SeleccionarCaller();
                }
                else
                {
                    MessageBox.Show("Datos No Eliminados", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Favor de ingresar el ID", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

    }
}
