using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicación_.Formas
{
    public partial class Registrarse : Form
    {
        public Registrarse()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usernameOrEmail = textBox1.Text;
            string password = textBox2.Text;

            if (string.IsNullOrEmpty(usernameOrEmail) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (EsValido(usernameOrEmail, password))
            {
                MessageBox.Show("Acceso concedido. ¡Bienvenido!", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas. Acceso denegado.", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Home Home = new Home();
            Home.Show();
        }
        private bool EsValido(string usernameOrEmail, string password)
        {
            return true;
        }

    }
}
    
