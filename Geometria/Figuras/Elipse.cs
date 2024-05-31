using System;

namespace Geometria
{
    public class Elipse : Figura
    {
        private double radioA;
        private double radioB;
        public double RadioA { get { return radioA; } set { radioA = value; } }
        public double RadioB { get { return radioB; } set { radioB = value; } }

        public Elipse( double radioA, double radioB) : base("Elipse")
        {
            this.radioA = radioA;
            this.radioB = radioB;
        }

        public Elipse(string nombre,double radioA, double radioB) : base(nombre)
        {
            this.radioA = radioA;
            this.radioB = radioB;
        }

        public override double Perimetro()
        {
            return Math.PI * (radioA + radioB);
        }

        public override double Area()
        {
            return Math.PI * (radioA * radioB);
        }

        public override string ToString()
        {
            return $"Radio A {radioA} Radio B {radioB}";
        }
    }
}
