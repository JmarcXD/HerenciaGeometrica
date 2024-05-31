namespace Geometria.Poligonos
{
    public class Cuadrado : Rectangulo
    {
        public Cuadrado(double longitudBase) : base("Cuadrado", longitudBase, longitudBase) { }

        public override string ToString()
        {
            return $"Longitud base {LongitudBase}";
        }
    }
}
