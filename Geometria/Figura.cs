namespace Geometria
{
    public abstract class Figura
    {
        private string nombre;

        public string Nombre { get { return nombre; } set { this.nombre = value; } }

        public Figura(string nombre)
        {
            this.nombre = nombre;
        }

        public abstract double Perimetro();
        public abstract double Area();

        public override string ToString()
        {
            return nombre;
        }
    }
}
