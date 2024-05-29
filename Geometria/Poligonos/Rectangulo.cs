namespace Geometria.Poligonos
{
    public class Rectangulo : Poligono
    {
        private double longitudAltura;
        public Rectangulo(string nombre, double longitudAltura, double longitudBase) : base(nombre, 4, longitudBase)
        {
            this.longitudAltura = longitudAltura;
        }

        public double LongitudAltura { get { return this.longitudAltura; } set { this.longitudAltura = value; } }

        public override double Perimetro()
        {
            return this.longitudAltura + this.longitudAltura + LongitudBase + LongitudBase;
        }

        public override double Area()
        {
            return this.longitudAltura * LongitudBase;
        }

    }
}
