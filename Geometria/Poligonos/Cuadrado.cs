namespace Geometria.Poligonos
{
    public class Cuadrado : Rectangulo
    {
        public Cuadrado(string nombre, double longitudBase) : base(nombre, longitudBase, longitudBase) { }

        public override string ToString()
        {
            return $"Longitud base {LongitudBase}";
        }
    }
}
