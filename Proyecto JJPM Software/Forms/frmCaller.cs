using System;
using System.Windows.Forms;
using Proyecto_JJPM_Software.Clases;

namespace Proyecto_JJPM_Software.Forms
{
	public partial class frmCaller : Form
	{
        private DatabaseManage dbManage;
		public frmCaller()
		{
			InitializeComponent();
            dbManage = new DatabaseManage();
		}		

		private void BTNInsert_Click_1(object sender, System.EventArgs e)
		{
            //Fecha Actual
            string Fecha = DateTime.Now.ToString("yyyy-MM-dd");
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
                if (dbManage.InsertarCaller(TBIdLead.Text, Accion, TBComentario.Text, Fecha))
                {
                    MessageBox.Show("Datos insertados correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    DGCaller.DataSource = dbManage.SeleccionarCallers();
                    Acomodar("Callers");
                    DGCaller.Refresh();
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
                if (dbManage.EliminarCaller(TBIdDelete.Text))
                {
                    MessageBox.Show("Datos Eliminados con exito.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DGCaller.DataSource = dbManage.SeleccionarCallers();
                    Acomodar("caller");
                    DGCaller.Refresh();
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

        private void frmCaller_Load(object sender, EventArgs e)
        {
            DGLeads.DataSource = dbManage.SeleccionarLeads();
            DGCaller.DataSource = dbManage.SeleccionarCallers();
            Acomodar("Leads");
            Acomodar("caller");
            DGLeads.Refresh();
            DGCaller.Refresh();
        }

        void Acomodar(string tipo)
        {
            if (tipo=="Leads")
            {
                for (int i = 0; i < DGLeads.ColumnCount; i++)
                {
                    if (i == 0 || i==7)
                    {
                        DGLeads.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                    }
                    else
                    {
                        DGLeads.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                }
            }
            else
            {
                for (int i = 0; i < DGCaller.ColumnCount; i++)
                {
                    if (i == 0 || i == 1|| i==2)
                    {
                        DGCaller.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                    }
                    else
                    {
                        DGCaller.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                }
            }
        }
        private void DGLeads_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGLeads.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                string id = DGLeads.SelectedRows[0].Cells[0].Value.ToString();

                TBIdLead.Text =id;
            }
        }
    }
}
