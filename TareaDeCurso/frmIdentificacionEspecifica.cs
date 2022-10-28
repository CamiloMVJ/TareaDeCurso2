using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjContabilidadMetodosValuacion
{
    public partial class frmIdentificacionEspecifica : Form
    {
        double UnidadesCompradas, UnidadesUsadas, UnidadesDisponibles = 0, CostoUnidadesDisponibles = 0;
        double CostoUnitario;
        int ContadorTransacciones = 0;


        public frmIdentificacionEspecifica()
        {
            InitializeComponent();
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (ValidaDatos() == "")
            {
                if (txtUnidadesUsadas.Text.Trim().Length == 0)
                    UnidadesUsadas = 0;
                else
                    UnidadesUsadas = double.Parse(txtUnidadesUsadas.Text);

                if(txtUnidadesCompradas.Text.Trim().Length == 0)
                    UnidadesCompradas = 0;
                else
                    UnidadesCompradas = double.Parse(txtUnidadesCompradas.Text);

              
                if(txtCostoUnitario.Text.Trim().Length == 0)
                    CostoUnitario = 0;
                else
                    CostoUnitario = double.Parse(txtCostoUnitario.Text);



                
                string Fecha = DTP.Text;
                UnidadesDisponibles += (UnidadesCompradas - UnidadesUsadas);
                CostoUnidadesDisponibles += (UnidadesCompradas * CostoUnitario);



                //ListView presentando los datos
                ListViewItem fila = new ListViewItem(Fecha.ToString());
                fila.SubItems.Add(UnidadesCompradas.ToString());
                fila.SubItems.Add(CostoUnitario.ToString("C"));
                lvDatosIngresados.Items.Add(fila);
                txtCostoUnitario.Clear();
                txtUnidadesCompradas.Clear();
                txtUnidadesCompradas.Focus();
            }
            else
            {
                MessageBox.Show(ValidaDatos(), "¡Error!");
            }
        }

        private string ValidaDatos()
        {
            if ((txtUnidadesCompradas.Text.Trim().Length == 0) && (txtUnidadesUsadas.Text.Trim().Length == 0))
            {
                return "No se han registrado Unidades, ni de entradas y/o salidas";

            }
            else if (txtUnidadesUsadas.Text.Trim().Length > 0)
            {
                return "";
            }
            else if ((txtUnidadesCompradas.Text.Trim().Length >= 0) && (txtCostoUnitario.Text.Trim().Length == 0))
            {
                return "No se ha registrado el 'Costo por Unidad'";
            }


            return "";
        }

        private void frmIdentificacionEspecifica_Load(object sender, EventArgs e)
        {
            
        }

    }
}
