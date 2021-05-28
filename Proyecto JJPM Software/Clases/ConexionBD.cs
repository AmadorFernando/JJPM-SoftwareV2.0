using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

using MySql.Data.MySqlClient;

namespace Proyecto_JJPM_Software.Clases
{
    class ConexionBD
    {
        private string HOST = "us-cdbr-east-03.cleardb.com";
        private string USER = "b65321e66023b8";
        private string PASS = "b6c76f52";
        private string DATA = "heroku_6bbfc71ddd5b758";

        public MySqlConnection ConectarBD = new MySqlConnection();

        public ConexionBD()
        {
            ConectarBD.ConnectionString = string.Format("datasource={0};username={1};password={2};database={3};", HOST, USER, PASS, DATA);
        }

        public void AbrirBD()
        {
            try
            {
                ConectarBD.Open();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error: "+ ex);
                
            }
        }

        public void CerrarBD()
        {
            ConectarBD.Close();
        }

        // Seleccionar datos para frmLeads
        public DataTable Seleccionar(string LocalUsuario, MySqlConnection conexion)
        {
            DataSet ds;
            MySqlCommand sqlCommand = new MySqlCommand("select * from TemporalLeads where Usuario=@Usuario;", conexion);
            MySqlParameter parametro = new MySqlParameter();
            sqlCommand.Parameters.Add(new MySqlParameter("@Usuario", LocalUsuario));
            MySqlDataAdapter da = new MySqlDataAdapter(sqlCommand);
            ds = new DataSet();
            da.Fill(ds, "Leads");
            return ds.Tables["Leads"];
        }

        public string[] Login(string Usuario, string Contra)
        {
            string[] TipoUsuario=new string[2];
            try
            {
                //Toma los valores de Usuario y Pass.
                //Evitando SQL Injection
                MySqlCommand cmd = new MySqlCommand("Select Usuario,Pass,Tipo,Nombre from Usuario where Usuario=@Usuario and Pass=@Pass", ConectarBD);
                cmd.Parameters.Add(new MySqlParameter("@Usuario", Usuario));
                cmd.Parameters.Add(new MySqlParameter("@Pass", Contra));
                MySqlDataAdapter dr = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dr.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    if (dt.Rows[0][2].ToString() == "Caller")
                    {
                        TipoUsuario[0] = "Caller";
                        TipoUsuario[1] = dt.Rows[0][3].ToString();
                        return TipoUsuario;
                    }
                    else if (dt.Rows[0][2].ToString() == "Leads")
                    {
                        TipoUsuario[0] = "Leads";
                        TipoUsuario[1] = dt.Rows[0][3].ToString();
                        return TipoUsuario;
                    }
                    else
                    {
                        TipoUsuario[0] = "Admin";
                        TipoUsuario[1] = dt.Rows[0][3].ToString();
                        return TipoUsuario;
                    }
                }
                else
                {
                    return null;
                }
            }

            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error: \n" + ex,"Error",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
                return null;
            }
        }

    }
}

