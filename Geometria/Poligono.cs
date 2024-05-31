namespace Geometria
{
    public abstract class Poligono : Figura
    {
        private int numeroLados;
        private double longitudBase;

        public int NumeroLados { get { return numeroLados; } set { numeroLados = value; } }
        public double LongitudBase { get { return longitudBase; } set { longitudBase = value; } }

        public Poligono(string nombre, int numeroLados, double longitudBase) : base(nombre)
        {
            this.numeroLados = numeroLados;
            this.longitudBase=longitudBase;
        }

        public override string ToString()
        {
            return $"Numero de lados: {numeroLados} y Longitud Base {longitudBase}";
        }
    }
}
