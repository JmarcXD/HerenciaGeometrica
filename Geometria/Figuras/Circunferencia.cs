namespace Geometria
{
    public class Circunferencia : Elipse
    {
        public Circunferencia(double radio) : base("Circunferencia", radio, radio) { }

        public override string ToString()
        {
            return $"Radio A {RadioA}";
        }

    }
}