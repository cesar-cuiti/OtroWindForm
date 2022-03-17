using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindForm3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string elemen = txtNombre.Text;
            listElemento.Items.Add(elemen);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido");
            colorFav.Items.Add("rojo");
            colorFav.Items.Add("verde");
            colorFav.Items.Add("negro");
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            DateTime fecha = dtpFechaNac.Value;

            //Operador ternario
            string cafe = ckbCasado.Checked == true ? " Casado " : " Soltero ";

            string tipo;
            if (btnTrabaja.Checked)
                tipo = " Empleado ";
            else if (btnNoTrabaja.Checked)
                tipo = " Sin empleo ";
            else
                tipo = " Otro ";

            string colorFavorito = colorFav.SelectedItem.ToString();
            string numeroFavorito = numeroFav.Value.ToString();
            string mensaje = " numero favorito " + numeroFavorito + " estado civil " + cafe + " empleo " + tipo;
            MessageBox.Show("Nombre " + nombre + " fecha de nac " + fecha + " color favorito " + colorFavorito + mensaje);
        }
    }
}
