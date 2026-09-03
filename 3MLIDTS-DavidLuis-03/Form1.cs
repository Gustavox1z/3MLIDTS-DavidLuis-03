using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3MLIDTS_DavidLuis_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCelsius.Clear();
            txtFahrenheit.Clear();
            txtKelvin.Clear();
            rbCelsius.Checked = false;
            rbFahrenheit.Checked = false;
            rbKelvin.Checked = false;
            txtCelsius.Enabled = true;
            txtFahrenheit.Enabled = true;
            txtKelvin.Enabled = true;

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtCelsius.Text != "" || txtFahrenheit.Text != "" || txtKelvin.Text != "")
            {
                if (!string.IsNullOrEmpty (txtCelsius.Text) )
                {
                    if (rbCelsius.Checked)
                    {
                        txtFahrenheit.Enabled = false;
                        txtKelvin.Enabled = false;
                    }
                    float Ce = float.Parse(txtCelsius.Text);
                    float Fa = (Ce * 9f / 5f) + 32;
                    float Ke = Ce + 273;

                    txtFahrenheit.Text = Fa.ToString();
                    txtKelvin.Text = Ke.ToString();
                }
                else if (!string.IsNullOrEmpty (txtFahrenheit.Text) )
                {
                    if (rbFahrenheit.Checked)
                    {
                        txtCelsius.Enabled = false;
                        txtKelvin.Enabled = false;
                    }
                    float Fa = float.Parse(txtFahrenheit.Text);
                    float Ce = (Fa - 32) * 5.0f / 9.0f;
                    float Ke = Ce + 273;
                    txtCelsius.Text = Ce.ToString();
                    txtKelvin.Text = Ke.ToString();
                }
                else if (!string.IsNullOrEmpty (txtKelvin.Text) )
                {
                    if (rbKelvin.Checked)
                    {
                        txtCelsius.Enabled = false;
                        txtFahrenheit.Enabled = false;
                    }
                    float Ke = float.Parse (txtKelvin.Text);
                    float Ce = Ke - 273;
                    float Fa = (Ce * 9f / 5f) + 32;
                    txtFahrenheit.Text = Fa.ToString();
                    txtCelsius.Text = Ce.ToString();
                }
            }
            else
            {
                MessageBox.Show("Ingrese valores numericos para el calculo de temperatura", "Error de valores",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}
