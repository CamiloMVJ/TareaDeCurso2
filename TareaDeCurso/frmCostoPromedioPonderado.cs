using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Clases;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjContabilidadMetodosValuacion
{
    public partial class frmCostoPromedioPonderado : Form
    {
        List<PromedioPonderado> ponderado = new List<PromedioPonderado>();
        int num = 0;
        double promedio;
        public frmCostoPromedioPonderado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ponderado.Add(new PromedioPonderado(int.Parse(mtbCantidad.Text), double.Parse(mtbCosto.Text)));
                PromedioPonderado[] listview = ponderado.ToArray();
                ListViewItem a = new ListViewItem(num.ToString());
                num++;
                a.SubItems.Add(ponderado.Last().UnidadesCompradas.ToString());
                a.SubItems.Add(ponderado.Last().PrecioDeCompra.ToString());
                a.SubItems.Add(ponderado.Last().Calculo(listview).ToString("0.00"));
                promedio = ponderado.Last().Calculo(listview);
                lvPromedio.Items.Add(a);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese un valor entero", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (mtbUsadas.Text.Trim().Length != 0 && mtbInvFinal.Text.Trim().Length != 0 && mtbCompradas.Text.Trim().Length != 0)
            {
                lvCostos.Items.Clear();
                String[] costos = new String[3];
                costos[0] = (int.Parse(mtbUsadas.Text) * promedio).ToString("0.00");
                costos[1] = (int.Parse(mtbInvFinal.Text) * promedio).ToString("0.00");
                costos[2] = (int.Parse(mtbCompradas.Text) * promedio).ToString("0.00");
                ListViewItem info = new ListViewItem(costos);
                lvCostos.Items.Add(info);
            }
            else
            {
                MessageBox.Show("Rellene todos los campos necesarios", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtbUsadas.Focus();
            }


        }


    }
}
