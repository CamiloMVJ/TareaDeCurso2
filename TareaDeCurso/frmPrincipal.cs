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
                //Aqui modifique que cuando se cierre el form de altoBajo se cierre el principal, para por si acaso el usuario quiera cambiar de metodo
                formularioPuntoAltoBajo.ShowDialog();
                //this.Close();
                rbPuntoAltoBajo.Checked = false;
            }
            else if (rbEstadistico.Checked == true)
            {

                formularioMetodoEstadistico.ShowDialog();
                this.Close();

            }
            else if (rbIdentificacionEspecifica.Checked == true)
            {
                formularioIdentificacionEspecifica.ShowDialog();
                this.Close();
            }
            else if (rbPromedioSimple.Checked == true)
            {
                formularioValuacionPromedioSimple.ShowDialog();
                this.Close();
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
