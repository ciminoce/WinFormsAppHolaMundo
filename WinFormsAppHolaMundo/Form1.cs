using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppHolaMundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CerrarButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Se realizaron {contadorSumas} sumas", "Mensaje Final", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            Application.Exit();
        }

        private int numero1;
        private int numero2;

        private int contadorSumas;
        private int contadorRestas;
        private void SumarButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                var suma = SumarNumeros(numero1, numero2);
                MessageBox.Show($"La suma es {suma}", "Resultado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                contadorSumas++;
                Numero2TextBox.Clear();
                Numero1TextBox.Clear();
                Numero1TextBox.Focus();

            }
            //else
            //{
            //    MessageBox.Show("Hay errores", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    Numero1TextBox.SelectAll();
            //    Numero1TextBox.Focus();
            //}

        }

        private int SumarNumeros(int nro1, int nro2) => nro1 + nro2;
        

        private bool ValidarDatos()
        {
            bool valido = true;
            ErroresErrorProvider.Clear();
            if (!int.TryParse(Numero1TextBox.Text, out numero1))
            {
                ErroresErrorProvider.SetError(Numero1TextBox,"Número mal ingresado");
                valido = false;

            }

            if (!int.TryParse(Numero2TextBox.Text, out numero2))
            {
                ErroresErrorProvider.SetError(Numero2TextBox, "Número mal ingresado");

                valido = false;
            }

            return valido;
        }

        private void RestarButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                var mult = MultiplicarNumeros(numero1, numero2);
                MessageBox.Show($"El producto es {mult}", "Resultado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                contadorRestas++;
                Numero2TextBox.Clear();
                Numero1TextBox.Clear();
                Numero1TextBox.Focus();

            }

        }

        private int MultiplicarNumeros(int nro1, int nro2) => nro1 * nro2;

        private int RestarNumeros(int nro1, int nro2) => nro1 - nro2;

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void LimpiarControles()
        {
            throw new NotImplementedException();
        }
    }
}
