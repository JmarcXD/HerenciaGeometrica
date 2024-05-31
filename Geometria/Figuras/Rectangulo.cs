namespace Geometria.Poligonos
{
    public class Rectangulo : Poligono
    {
        private double longitudAltura;

        public double LongitudAltura { get { return this.longitudAltura; } set { this.longitudAltura = value; } }

        public Rectangulo(double longitudAltura, double longitudBase) : base("Rectangulo", 4, longitudBase)
        {
            this.longitudAltura = longitudAltura;
        }

        public Rectangulo(string nombre,double longitudAltura, double longitudBase) : base(nombre, 4, longitudBase)
        {
            this.longitudAltura = longitudAltura;
        }

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
