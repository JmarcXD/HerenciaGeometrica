namespace Geometria
{
    public class QuaUltraGono : Poligono
    {
        private double apotema;

        public QuaUltraGono(string nombre ,double apotema, int numeroLados, double longitudBase) : base(nombre,numeroLados, longitudBase)
        {
            this.apotema = apotema;
        }

        public double Apotema { get {  return apotema; } set {  apotema = value; } }

        public override double Perimetro()
        {
            return NumeroLados * LongitudBase;
        }

        public override double Area()
        {
            return (Perimetro() * this.apotema) / 2;
        }
    }
}
