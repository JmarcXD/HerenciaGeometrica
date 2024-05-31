namespace Geometria
{
    public class Triangulo : Poligono
    {
        private double longitudAltura;
        private double longitudDerecho;
        private double longitudIzquierdo;
        public double LongitudAltura { get { return this.longitudAltura; } set { this.longitudAltura = value; } }
        public double LongitudDerecho { get { return this.longitudDerecho; } set { this.longitudAltura = value; } }
        public double LongitudIzquierdo { get { return this.longitudIzquierdo; } set { this.longitudIzquierdo = value; } }

        public Triangulo(double longitudAltura, double longitudDerecho, double longitudIzquierdo, double longitudBase) : base("Triangulo", 3, longitudBase)
        {
            this.longitudAltura = longitudAltura;
            this.longitudDerecho = longitudDerecho;
            this.longitudIzquierdo = longitudIzquierdo;
        }


        public override double Perimetro()
        {
            return LongitudBase + LongitudBase + LongitudBase;
        }

        public override double Area()
        {
            return (LongitudBase * this.LongitudAltura) / 2;
        }

        public override string ToString()
        {
            return $"Longitud Altura {longitudAltura} Longitud Base {LongitudBase}";
        }
    }
}
