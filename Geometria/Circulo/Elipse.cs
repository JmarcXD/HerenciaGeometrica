namespace Geometria
{
    public class Elipse : Figura
    {
        private double radioA;
        private double radioB;

        public Elipse(string nombre, double radioA, double radioB) : base(nombre)
        {
            this.radioA = radioA;
            this.radioB = radioB;
        }

        public double RadioA { get { return radioA; } set { radioA = value; } }
        public double RadioB { get { return radioB; } set { radioB = value; } }

        public override double Perimetro()
        {
            return 3.14 * (radioA + radioB);
        }

        public override double Area()
        {
            return 3.14 * (radioA * radioB);
        }

        public override string ToString()
        {
            return $"Radio A {radioA} Radio B {radioB}";
        }
    }
}
