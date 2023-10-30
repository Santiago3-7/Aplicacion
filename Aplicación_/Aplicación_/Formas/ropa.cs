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
    public partial class ropa : Form
    {
        public ropa()
        {
            InitializeComponent();

            comboBox1.Items.Add("Negro");
            comboBox1.Items.Add("Rojo");
            comboBox1.Items.Add("Verde");
            comboBox1.Items.Add("Azul");
            comboBox1.Items.Add("Morado");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow renglon = (DataGridViewRow)dataRopa.Rows[0].Clone();

                renglon.Cells[0].Value = textoModelo.Text;
                renglon.Cells[1].Value = textoMarca.Text;
                renglon.Cells[2].Value = comboBox1.Text;
                renglon.Cells[3].Value = textoTalla.Text;
                renglon.Cells[4].Value = textoPrecio.Text;

                dataRopa.Rows.Add(renglon);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Agregando Estudiante ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            string mensaje = "Desear eliminar el registro?";
            string titulo = "Eliminando el registro";

            if (!(dataRopa.CurrentRow is null))
            {
                if (MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        dataRopa.Rows.Remove(dataRopa.CurrentRow);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Prenda eliminada",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debes selecionar un renglón", "Eliminado Estudiante",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            {
                textoModelo.Text = dataRopa.CurrentRow.Cells["Modelo"].Value.ToString();
                textoMarca.Text = dataRopa.CurrentRow.Cells["Marca"].Value.ToString();
                comboBox1.Text = dataRopa.CurrentRow.Cells["Color"].Value.ToString();
                textoTalla.Text = dataRopa.CurrentRow.Cells["Talla"].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home Home = new Home();
            Home.Show();
            Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
