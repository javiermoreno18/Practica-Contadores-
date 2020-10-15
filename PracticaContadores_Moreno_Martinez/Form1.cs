using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaContadores
{
    public partial class Generador : Form
    {
        int contador = 1;
        public Generador()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (contador <= 25)
            {
                tbPantalla.Text = Convert.ToString(contador);
                contador += 1;
            }
            else
            {
                MessageBox.Show("Ya se han generado 25 números", "Advertencia");
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (tbPantalla.Text == "" || tbPantalla.Text == null)
            {
                MessageBox.Show("No hay ningún número para borrar", "Advertencia");
            }
            else
            {
                tbPantalla.Text = "";
            }
        }
    }
}
