namespace pjContabilidadMetodosValuacion
{
    public partial class frmPrincipal : Form
    {
        frmMétodoEstadístico formularioMetodoEstadistico;
        frmCostoPromedioSimple formularioValuacionPromedioSimple;
        frmMetodoPuntoAltoBajo formularioPuntoAltoBajo;
        frmPEPS formularioPEPS;
        frmIdentificacionEspecifica formularioIdentificacionEspecifica;
        frmCostoPromedioPonderado formularioPonderado;



        public frmPrincipal()
        {
            InitializeComponent();
            formularioMetodoEstadistico = new frmMétodoEstadístico();
            formularioValuacionPromedioSimple = new frmCostoPromedioSimple();
            formularioPuntoAltoBajo = new frmMetodoPuntoAltoBajo();
            formularioPEPS = new frmPEPS();
            formularioIdentificacionEspecifica = new frmIdentificacionEspecifica();
            formularioPonderado = new frmCostoPromedioPonderado();

            formularioIdentificacionEspecifica = new frmIdentificacionEspecifica();

            formularioPonderado = new frmCostoPromedioPonderado();

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {


        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {

            if (rbPuntoAltoBajo.Checked == true)
            {
                formularioPuntoAltoBajo.ShowDialog();
                rbPuntoAltoBajo.Checked = false;
            }
            else if (rbEstadistico.Checked == true)
            {

                formularioMetodoEstadistico.ShowDialog();

            }
            else if (rbIdentificacionEspecifica.Checked == true)
            {
                formularioIdentificacionEspecifica.ShowDialog();
            }
            else if (rbPromedioSimple.Checked == true)
            {
                formularioValuacionPromedioSimple.ShowDialog();
            }
            else if (rbPromedioPonderado.Checked == true)
            {
                formularioPonderado.ShowDialog();
            }
            else if (rbPEPS.Checked == true)
            {
                formularioPEPS.ShowDialog();

            }
            else if (rbUEPS.Checked == true)
            {
                this.Close();
            }

        }
    }
}
