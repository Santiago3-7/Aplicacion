using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aplicación_.Formas;

namespace Aplicación_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxUsuario.Text == string.Empty)
            {
                if (textBoxContraseña.Text == string.Empty)
                {
                    MessageBox.Show("El usuario o contraseña son incorrectos", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (textBoxContraseña.Text == "2616")
                    {
                        MessageBox.Show("El usuario invalido", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("El usuario o contraseña son incorrectos", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                if (textBoxUsuario.Text == string.Empty)
                {
                    MessageBox.Show("La contraseña es incorrecta", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (textBoxUsuario.Text == "Santiago" && textBoxContraseña.Text == "2616")
                    {
                        MessageBox.Show("Ingreso Correcto", "Atención",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Home Home = new Home();
                        Home.Show();
                        Hide();
                    }

                    else if (textBoxUsuario.Text != "Santiago" && textBoxContraseña.Text == "2616")
                    {
                        MessageBox.Show("El usuario es incorrecto", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (textBoxUsuario.Text == "Santiago" && textBoxContraseña.Text != "2616")
                    {
                        MessageBox.Show("La contraseña es incorrecta", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private bool EsValido(string usernameOrEmail, string password)
        {
            return true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Registrarse Registrarse = new Registrarse();
            Registrarse.Show();
            Hide();
        }
    }
}
