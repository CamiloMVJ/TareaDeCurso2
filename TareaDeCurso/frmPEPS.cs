using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;
using System.Collections;

namespace pjContabilidadMetodosValuacion
{
    public partial class frmPEPS : Form
    {
        List<MatEntradaSalida> Entrada = new List<MatEntradaSalida>();
        List<MatEntradaSalida> Salida = new List<MatEntradaSalida>();
        int suma = 0;
        public frmPEPS()
        {
            InitializeComponent();
        }

        private void frmPEPS_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrarCompras_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada.Add(new MatEntradaSalida(dtFechaCompras.Value, int.Parse(txtUnidades.Text), double.Parse(txtCosto.Text)));
                suma += int.Parse(txtUnidades.Text);
                Entrada.Sort();
                lvUnidadesCompradas.Items.Clear();
                foreach (MatEntradaSalida elemento in Entrada)
                {
                    ListViewItem compradas = new ListViewItem(elemento.Fecha.ToShortDateString());
                    compradas.SubItems.Add(elemento.UnidadesCompradas.ToString());
                    compradas.SubItems.Add(elemento.CostoUnitario.ToString("0.00"));
                    lvUnidadesCompradas.Items.Add(compradas);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Rellene las casillas requeridas", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            dtFechaCompras.ResetText();
            txtUnidades.Clear();
            txtCosto.Clear();
        }

        private void btnRegistrarUtilizadas_Click(object sender, EventArgs e)
        {
            int utilizadas = 0;
            try
            {
                Salida.Add(new MatEntradaSalida(DateTime.Parse(dtFechaUtilizadas.Text), int.Parse(txtUnidadesUtilizadas.Text)));
                utilizadas = int.Parse(txtUnidadesUtilizadas.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese un valor entero", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            Salida.Sort();
            //Incompleto
            if (suma >= Salida.Last().UnidadesUtilizadas)
            {
                for (int i = 100; i != 0; i--)
                {
                    if (Entrada.First().UnidadesCompradas > Salida.Last().UnidadesUtilizadas)
                    {
                        Entrada.First().UnidadesCompradas -= Salida.Last().UnidadesUtilizadas;
                        suma -= Salida.Last().UnidadesUtilizadas;
                        Salida.Last().CostoUnitario = Entrada.First().CostoUnitario;
                        i = 1;
                    }
                    else if (Entrada.First().UnidadesCompradas <= Salida.Last().UnidadesUtilizadas)
                    {
                        for (int j = utilizadas; j != 0; j--)
                        {
                            if (utilizadas == 0)
                            {
                                j = 1;
                                i = 1;
                            }
                            else
                            {
                                Salida.Last().CostoUnitario = Entrada.First().CostoUnitario;
                                utilizadas -= Entrada.First().UnidadesCompradas;
                                suma -= Entrada.First().UnidadesCompradas;
                                Entrada.RemoveAt(0);
                            }


                        }
                    }
                    else if(Entrada.First().UnidadesCompradas < Salida.Last().UnidadesUtilizadas)
                    {

                    }
                }
            }
            else
                MessageBox.Show("No cuenta con las unidades requeridas, solo tiene: " + suma, "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            try
            {
                Salida.Sort();
                lvUnidadesUtilizadas.Items.Clear();
                foreach (MatEntradaSalida elemento in Salida)
                {
                    ListViewItem info = new ListViewItem(elemento.Fecha.ToShortDateString());
                    info.SubItems.Add(elemento.UnidadesUtilizadas.ToString());
                    info.SubItems.Add(elemento.CostoUnitario.ToString("0.00"));
                    lvUnidadesUtilizadas.Items.Add(info);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Rellene las casilla requeridas", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            dtFechaUtilizadas.ResetText();
            txtUnidadesUtilizadas.Clear();
        }
    }
}
