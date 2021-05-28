using Proyecto_JJPM_Software.Clases;
using Proyecto_JJPM_Software.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_JJPM_Software.Forms
{
    public partial class frmLogin : Form
    {
        //Esta variable guardara el ultimo click, para poder realizar el movimiento de la ventana.
        Point lastclick;
        private DatabaseManage dbManage;

        public frmLogin()
        {
            InitializeComponent();
            dbManage = new DatabaseManage();
        }

        //Boton para minimizar la ventana.
        private void pboxMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //Boton para agrandar la ventana a tamaño completo.
        private void pboxMax_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            Left = Top = 0;
            if (Width > 965)
            {
                pboxMax.Image = new Bitmap(Resources.Maximize_Window_2_48px);
                Width = 965;
                Height = 720;
                Left = (Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2);
                Top = (Screen.PrimaryScreen.WorkingArea.Height / 2) - (Height / 2);
            }
            else 
            {
                pboxMax.Image = new Bitmap(Resources.Restore_Window_2_48px);
                Width = Screen.PrimaryScreen.WorkingArea.Width;
                Height = Screen.PrimaryScreen.WorkingArea.Height;
            }
        }

        //Boton para cerrar la ventana.
        private void pboxClose_Click(object sender, EventArgs e)
        {
            DialogResult Dr = MessageBox.Show("¿Estas seguro que quieres cerrar la aplicacion?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Dr == DialogResult.Yes)
            {
                Application.Exit();
            }
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

        //Boton para guardar el valor del ultimo click.
        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            lastclick = e.Location;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string[] TipUsuario = new string[2];
            string PassEncriptada = "";
            //Encritamos la Contraseña
            PassEncriptada = Encrypt.GetSHA256(txtBoxPassword.Text.Trim());
            if (string.IsNullOrWhiteSpace(txtBoxUsername.Text)||string.IsNullOrWhiteSpace(txtBoxPassword.Text))
            {
                MessageBox.Show("Ingresa tu usuario y contraseña.", "Falta de Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    TipUsuario = dbManage.Login(txtBoxUsername.Text, PassEncriptada);
                    if (TipUsuario[0] == "Caller")
                    {
                        this.Hide();
                        var form1 = new frmPrincipal(TipUsuario,txtBoxUsername.Text);
                        form1.Closed += (s, args) => this.Close();
                        form1.Show();
                    }
                    else if (TipUsuario[0] == "Leads")
                    {
                        this.Hide();
                        var form1 = new frmPrincipal(TipUsuario,txtBoxUsername.Text);
                        form1.Closed += (s, args) => this.Close();
                        form1.Show();

                    }
                    else if (TipUsuario[0] == "Admin")
                    {
                        this.Hide();
                        var form1 = new frmPrincipal(TipUsuario,txtBoxUsername.Text);
                        form1.Closed += (s, args) => this.Close();
                        form1.Show();
                    }
                    else
                    {
                        MessageBox.Show("El usuario/contraseña invalida.");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("El usuario/contraseña invalida.", "Alerta",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtBoxPassword.Text = "jjpass%2020";
            txtBoxUsername.Text = "Admin";
        }

        //RIP Mensaje secreto :( Eddy lo mato </3
        private void label1_Click(object sender, EventArgs e)
        {
            //Shhhh 
            DialogResult dr = MessageBox.Show("¡Ten un buen dia =D!","Mensaje Secreto",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
        }

        private void pboxPassVisual_Click(object sender, EventArgs e)
        {
            //Esto hara que se pueda ver o no, la contraseña.
            if (txtBoxPassword.PasswordChar == '·')
            {
                txtBoxPassword.PasswordChar ='\0';
            }
            else
            {
                txtBoxPassword.PasswordChar = '·';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtBoxPassword.Text = "123";
            txtBoxUsername.Text = "RodriguezJE30";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtBoxPassword.Text = "12345";
            txtBoxUsername.Text = "RamirezJ87";
        }


        private void frmLogin_Shown(object sender, EventArgs e)
        {
            txtBoxUsername.Focus();
        }

        private void pboxPassVisual_DoubleClick(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(Resources.Ojito);
            bmp.Save("bmp.png");
        }
    }
}

