using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Proyecto_JJPM_Software.Clases
{
    class DatabaseManage
    {
        private string HOST = "us-cdbr-east-03.cleardb.com";
        private string USER = "b65321e66023b8";
        private string PASS = "b6c76f52";
        private string DATA = "heroku_6bbfc71ddd5b758";
        private MySqlConnection dbConnection = null;

        #region Usuarios
        public DataTable SeleccionarUsuarios()
        {
            try
            {
                InstanciarBaseDatos();
                DataSet ds;
                MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM Usuario", dbConnection);
                MySqlDataAdapter da = new MySqlDataAdapter(sqlCommand);
                ds = new DataSet();
                da.Fill(ds, "Usuario");
                CerrarBaseDatos();
                return ds.Tables["Usuario"];
            }
            catch (Exception ex)
            {
                CerrarBaseDatos();
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        public bool InsertarUsuario(/*atributos*/ string idUsuario, string Nombre, string ApellidoP, string ApellidoM, string Usuario, string Pass, string Tipo, string Ingreso)
        {
            try
            {
                InstanciarBaseDatos();
                MySqlCommand sqlCommand = new MySqlCommand(string.Format("Insert into Usuario values ({0}, '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')", new string[] { idUsuario, Nombre, ApellidoP, ApellidoM, Usuario, Pass, Tipo, Ingreso }), dbConnection);
                int filasafectadas = sqlCommand.ExecuteNonQuery();
                CerrarBaseDatos();
                if (filasafectadas > 0) return true;
                else return false;
            }
            catch(Exception ex)
            {
                CerrarBaseDatos();
                Console.WriteLine(ex.Message);
            }
            return false;
        }

        public bool EliminarUsuario(string idUsuario)
        {
            try
            {
                InstanciarBaseDatos();
                MySqlCommand sqlCommand = new MySqlCommand(string.Format("Delete from Usuario where IdUsuario = {0}", idUsuario), dbConnection);
                int filasafectadas = sqlCommand.ExecuteNonQuery();
                CerrarBaseDatos();
                if (filasafectadas > 0) return true;
                else return false;
            }
            catch(Exception ex)
            {
                CerrarBaseDatos();
                Console.WriteLine(ex.Message);
            }
            return false;
        }

        public string[] Login(string Usuario, string Contra)
        {
            string[] TipoUsuario = new string[2];
            try
            {
                //Toma los valores de Usuario y Pass.
                //Evitando SQL Injection
                InstanciarBaseDatos();
                MySqlCommand cmd = new MySqlCommand("Select Usuario,Pass,Tipo,Nombre from Usuario where Usuario=@Usuario and Pass=@Pass", dbConnection);
                cmd.Parameters.Add(new MySqlParameter("@Usuario", Usuario));
                cmd.Parameters.Add(new MySqlParameter("@Pass", Contra));
                MySqlDataAdapter dr = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dr.Fill(dt);
                CerrarBaseDatos();
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
                CerrarBaseDatos();
                System.Windows.Forms.MessageBox.Show("Error: \n" + ex, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return null;
            }
        }

        #endregion

        #region Callers
        public DataTable SeleccionarCallers()
        {
            try
            {
                InstanciarBaseDatos();
                DataSet ds;
                MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM Caller", dbConnection);
                MySqlDataAdapter da = new MySqlDataAdapter(sqlCommand);
                ds = new DataSet();
                da.Fill(ds, "Caller");
                CerrarBaseDatos();
                return ds.Tables["Caller"];
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                CerrarBaseDatos();
            }
            return null;
        }

        public bool InsertarCaller(string idLeads, string Accion, string Comentario, string Ingreso)
        {
            try
            {
                InstanciarBaseDatos();
                MySqlCommand sqlCommand = new MySqlCommand(string.Format("Insert into Caller (idLead, Accion, Comentarios, Fecha) values ({0}, '{1}', '{2}', '{3}')", new string[] { idLeads, Accion, Comentario, Ingreso }), dbConnection);
                int filasafectadas = sqlCommand.ExecuteNonQuery();
                CerrarBaseDatos();
                if (filasafectadas > 0) return true;
                else return false;
            }
            catch (Exception ex)
            {
                CerrarBaseDatos();
                Console.WriteLine(ex.Message);
            }
            return false;
        }

        public bool EliminarCaller(string idCaller)
        {
            try
            {
                InstanciarBaseDatos();
                MySqlCommand sqlCommand = new MySqlCommand(string.Format("Delete from Caller where idCaller = {0}", idCaller), dbConnection);
                int filasafectadas = sqlCommand.ExecuteNonQuery();
                CerrarBaseDatos();
                if (filasafectadas > 0) return true;
                else return false;
            }
            catch (Exception ex)
            {
                CerrarBaseDatos();
                Console.WriteLine(ex.Message);
            }
            return false;
        }
        #endregion

        #region Leads
        public DataTable SeleccionarLeads()
        {
            try
            {
                InstanciarBaseDatos();
                DataSet ds;
                MySqlCommand sqlCommand = new MySqlCommand("select * from Leads", dbConnection);
                MySqlDataAdapter da = new MySqlDataAdapter(sqlCommand);
                ds = new DataSet();
                da.Fill(ds, "Leads");
                CerrarBaseDatos();
                return ds.Tables["Leads"];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                CerrarBaseDatos();
            }
            return null;
        }

        public DataTable SeleccionarLeads(string LocalUsuario)
        {
            try
            {
                InstanciarBaseDatos();
                DataSet ds;
                MySqlCommand sqlCommand = new MySqlCommand("select *  from TemporalLeads where Usuario=@Usuario;", dbConnection);
                MySqlParameter parametro = new MySqlParameter();
                sqlCommand.Parameters.Add(new MySqlParameter("@Usuario", LocalUsuario));
                MySqlDataAdapter da = new MySqlDataAdapter(sqlCommand);
                ds = new DataSet();
                da.Fill(ds, "Leads");
                CerrarBaseDatos();
                return ds.Tables["Leads"];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                CerrarBaseDatos();
            }
            return null;
        }

        public bool InsertarLead(string LocalUsuario, string Fecha, string Nombre, string Telefono, string Manager, string Correo, string Direccion, string Zona)
        {
            try
            {
                InstanciarBaseDatos();
                MySqlCommand cmd = new MySqlCommand("Insert into TemporalLeads (Usuario, Fecha, Nombre, Telefono, Manager, Correo, Direccion, Zona) values (@Usuario,@Fecha,@Nombre,@Telefono,@Manager,@Correo,@Direccion,@Zona)", dbConnection);
                cmd.Parameters.Add(new MySqlParameter("@Usuario", LocalUsuario));
                cmd.Parameters.Add(new MySqlParameter("@Fecha", Convert.ToDateTime(Fecha)));
                cmd.Parameters.Add(new MySqlParameter("@Nombre", Nombre));
                cmd.Parameters.Add(new MySqlParameter("@Telefono", Telefono));
                cmd.Parameters.Add(new MySqlParameter("@Manager", Manager));
                cmd.Parameters.Add(new MySqlParameter("@Correo", Correo));
                cmd.Parameters.Add(new MySqlParameter("@Direccion", Direccion));
                cmd.Parameters.Add(new MySqlParameter("@Zona", Zona));
                int filasafectadas = cmd.ExecuteNonQuery();
                CerrarBaseDatos();
                if (filasafectadas > 0) return true;
                else return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                CerrarBaseDatos();
            }
            return false;
        }

        public bool EliminarLead(int idLead)
        {
            try
            {
                InstanciarBaseDatos();
                MySqlCommand sqlCommand = new MySqlCommand(string.Format("Delete from TemporalLeads where idTemp = {0}", idLead), dbConnection);
                int filasafectadas = sqlCommand.ExecuteNonQuery();
                //TBIdInsert.Text =Convert.ToString(DG.Rows.Count);
                CerrarBaseDatos();
                if (filasafectadas > 0) return true;
                else return false;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                CerrarBaseDatos();
            }
            return false;
        }

        public void IngresoLeadsDefinitivo(string usuario)
        {
            try
            {
                InstanciarBaseDatos();
                //Agrega a la tabla original
                MySqlCommand cmd = new MySqlCommand("INSERT INTO Leads(Fecha, Nombre, Telefono, Manager, Correo, Direccion, Zona, Usuario) SELECT Fecha, Nombre, Telefono, Manager, Correo, Direccion, Zona, Usuario FROM TemporalLeads where Usuario =@Usuario",dbConnection);
                cmd.Parameters.Add(new MySqlParameter("@Usuario", usuario));
                cmd.ExecuteNonQuery();
                CerrarBaseDatos();

                InstanciarBaseDatos();
                //Eliminamos de la tabla temporal
                MySqlCommand cmd2 = new MySqlCommand("DELETE FROM TemporalLeads WHERE Usuario=@Usuario",dbConnection);
                cmd2.Parameters.Add(new MySqlParameter("@Usuario", usuario));
                cmd2.ExecuteNonQuery();
                CerrarBaseDatos();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                CerrarBaseDatos();
            }
        }
        #endregion

        #region BaseDatos
        private void InstanciarBaseDatos()
        {
            // Crear conexion e instanciar
            try
            {
                if (dbConnection == null) dbConnection = new MySqlConnection();
                dbConnection.ConnectionString = string.Format("datasource={0};username={1};password={2};database={3};", HOST, USER, PASS, DATA);
                dbConnection.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void CerrarBaseDatos()
        {
            try
            {
                if(dbConnection!= null)
                {
                    if (dbConnection.State == ConnectionState.Open)
                    {
                        dbConnection.Close();
                        dbConnection = null;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion

    }
}
