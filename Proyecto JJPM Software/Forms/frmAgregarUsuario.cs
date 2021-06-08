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
	public partial class frmAgregarUsuario : Form
	{
        private DatabaseManage dbManage;
		public frmAgregarUsuario()
		{
			InitializeComponent();
            dbManage = new DatabaseManage();
		}
        
        private void BTNInsert_Click_1(object sender, EventArgs e)
        {
            //Tomamos el valor de la fecha
            string Fecha = "";
            DateTime fechita = dateTPIngreso.Value.Date;
            DateTime Fechahoy = DateTime.Now;
            Fecha = dateTPIngreso.Value.Date.ToString("yyyy-MM-dd");
            if (fechita.Date>Fechahoy.Date)
            {
                MessageBox.Show("Ingresa una fecha que no haya pasado aun.","Dato Erroneo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                Fecha = "";
            }

            //Tomamos el valor del Tipo de Usuario
            string Tipo = "";
            switch (cBoxTipo.Text)
            {
                case "Caller":
                    Tipo = "Caller";
                    break;
                case "Leads":
                    Tipo = "Leads";
                    break;
                default:
                    MessageBox.Show("Selecciona un tipo de usuario valido", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
            
            //Generar el Usuario
            string Nombre = "";
            string Nombre2 = "";//Opcional
            string ApellidoP = "";
            string ApellidoM = "";//Opcional
            string UsuarioFinal = "";
            Random r = new Random();

            //Tomamos los valores de 2do nombre y apellido Materno en caso de tenerlos
            if (TBNombre2.TextLength > 0 && !(string.IsNullOrWhiteSpace(TBNombre2.Text)))
            {
                Nombre2 = TBNombre2.Text;
            }
            if (TBAm.TextLength > 0 && !(string.IsNullOrWhiteSpace(TBAm.Text)))
            {
                ApellidoM = TBAm.Text;
            }

            try
            {
                //Verificacion de que haya Nombre y Apellido Paterno
                if (string.IsNullOrWhiteSpace(TBNombre.Text) || string.IsNullOrWhiteSpace(TBAp.Text) || Tipo == "" || string.IsNullOrWhiteSpace(TBPass.Text) || Fecha == "")
                {
                    MessageBox.Show("Falta ingresar informacion necesaria", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else 
                {
                    Nombre = TBNombre.Text;
                    ApellidoP = TBAp.Text;

                    //Encritamos la Contraseña
                    string PassEncriptada = Encrypt.GetSHA256(TBPass.Text);

                    //Seleccion de Usuario (En caso de tener 2 nombres)
                    if (string.IsNullOrWhiteSpace(TBNombre2.Text))
                    {
                        UsuarioFinal = ApellidoP + (Nombre.Substring(0, 1).ToUpper()) + r.Next(10, 99);
                        MessageBox.Show("Nuevo Usuario Generado: " + UsuarioFinal, "Usuario Generado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        //Insertamos los Datos en la BD
                        if (dbManage.InsertarUsuario(TBIdInsert.Text, Nombre, ApellidoP, ApellidoM, UsuarioFinal, PassEncriptada, Tipo, Fecha))
                        {
                            MessageBox.Show("Datos insertados correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            TBIdInsert.Text = DG.Rows.Count.ToString();
                            DG.DataSource = dbManage.SeleccionarUsuarios();

                            //Limpiamos los valores
                            TBNombre.Clear();
                            TBNombre2.Clear();
                            TBAp.Clear();
                            TBAm.Clear();
                            TBPass.Clear();
                            TBNombre.Focus();
                        }
                    }
                    else
                    {
                        UsuarioFinal = ApellidoP + (Nombre.Substring(0, 1).ToUpper()) + (Nombre2.Substring(0, 1).ToUpper()) + r.Next(10, 99);
                        MessageBox.Show("Nuevo Usuario Generado: "+UsuarioFinal,"Usuario Generado",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

                        //Insertamos los Datos en la BD
                        if (dbManage.InsertarUsuario(TBIdInsert.Text, Nombre, ApellidoP, ApellidoM, UsuarioFinal, PassEncriptada, Tipo, Fecha))
                        {
                            MessageBox.Show("Datos insertados correctamente","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                            TBIdInsert.Text = DG.Rows.Count.ToString();
                            DG.DataSource = dbManage.SeleccionarUsuarios();

                            //Limpiamos los valores
                            TBNombre.Clear();
                            TBNombre2.Clear();
                            TBAp.Clear();
                            TBAm.Clear();
                            TBPass.Clear();
                            TBNombre.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex);
            }
        }

        private void pboxPassVisual_Click(object sender, EventArgs e)
        {
            //Esto hara que se pueda ver o no, la contraseña.
            if (TBPass.PasswordChar == '·')
            {
                TBPass.PasswordChar = '\0';
            }
            else
            {
                TBPass.PasswordChar = '·';
            }
        }

        private void BTNDelete_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Estas seguro que deseas eliminar a este Usuario?", "Alerta",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
            if (dr==DialogResult.Yes)
            {
                if (dbManage.EliminarUsuario(TBIdDelete.Text))
                {
                    MessageBox.Show("Datos Eliminados con exito.","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    TBIdInsert.Text = DG.Rows.Count.ToString();
                    DG.DataSource = dbManage.SeleccionarUsuarios();
                }
                else
                {
                    MessageBox.Show("Datos No Eliminados","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Error);
                } 
            }
            
        }

        private void TBNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void TBNombre2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void TBAp_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void TBAm_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void TBIdDelete_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void frmAgregarUsuario_Load(object sender, EventArgs e)
        {
            DG.DataSource = dbManage.SeleccionarUsuarios();
            TBIdInsert.Text = DG.Rows.Count.ToString();
        }
    }
}
