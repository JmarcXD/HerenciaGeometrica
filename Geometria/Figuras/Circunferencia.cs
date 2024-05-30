namespace Geometria
{
    public class Circunferencia : Elipse
    {
        public Circunferencia(string nombre, double radio) : base(nombre, radio, radio) { }

        public override string ToString()
        {
            return $"Radio A {RadioA}";
        }

    }
}