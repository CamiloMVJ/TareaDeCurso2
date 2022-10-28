namespace Clases
{
    public class Mes
    {
        private String nombre;
        private double valor;
        private int horas;

        public Mes(String nombre, double valor, int horas)
        {
            this.horas = horas;
            this.nombre = nombre;
            this.valor = valor;
        }
        public Mes()
        {
           
        }

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public double Valor
        {
            get { return valor; }
            set { valor = (value > 0) ? value : 0; }
        }

        public int Horas
        {
            get { return horas; }
            set { horas = (value > 0) ? value : 0; }
        }
        public enum Meses
        {
            Enero = 0,
            Febrero = 1,
            Marzo = 2,
            Abril = 3,
            Mayo = 4,
            Junio = 5,
            Julio = 6,
            Agosto = 7,
            Septiembre = 8,
            Octubre = 9,
            Noviembre = 10,
            Diciembre = 11
        }
    }
}