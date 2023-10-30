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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();

            comboBox1.Items.Add("Negro");
            comboBox1.Items.Add("Rojo");
            comboBox1.Items.Add("Verde");
            comboBox1.Items.Add("Azul");
            comboBox1.Items.Add("Morado");
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow renglon = (DataGridViewRow)dataEstudiante.Rows[0].Clone();

                renglon.Cells[0].Value = textoModelo.Text;
                renglon.Cells[1].Value = textoMarca.Text;
                renglon.Cells[2].Value = comboBox1.Text;
                renglon.Cells[3].Value = textoTalla.Text;

                dataEstudiante.Rows.Add(renglon);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Agregando Estudiante ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            string mensaje = "Desear eliminar el registro?";
            string titulo = "Eliminando el registro";

            if (!(dataEstudiante.CurrentRow is null))
            {
                if (MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        dataEstudiante.Rows.Remove(dataEstudiante.CurrentRow);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Tenis eliminado",
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
                textoModelo.Text = dataEstudiante.CurrentRow.Cells["Modelo"].Value.ToString();
                textoMarca.Text = dataEstudiante.CurrentRow.Cells["Marca"].Value.ToString();
                comboBox1.Text = dataEstudiante.CurrentRow.Cells["Color"].Value.ToString();
                textoTalla.Text = dataEstudiante.CurrentRow.Cells["Talla"].Value.ToString();
            }
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataEstudiante.SelectedRows.Count > 0) 
                {
                    DataGridViewRow renglon = dataEstudiante.SelectedRows[0];

                    renglon.Cells[0].Value = textoModelo.Text;
                    renglon.Cells[1].Value = textoMarca.Text;
                    renglon.Cells[2].Value = comboBox1.Text;
                    renglon.Cells[3].Value = textoTalla.Text;
                }
                else
                {
                    MessageBox.Show("Selecciona un renglón para modificar.", "Modificar Estudiante",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Modificando Estudiante",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ropa ropa = new ropa();
            ropa.Show();
            Hide();
        }
    }
}
