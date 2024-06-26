﻿using Geometria.Poligonos;
using System;
using System.Collections.Generic;

namespace Geometria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cuadrado cuadrado = new Cuadrado("Cuadrado", 5);
            //Rectangulo rectangulo = new Rectangulo("Rectangulo", 5, 10.5);

            //QuaUltraGono pentagono = new QuaUltraGono("Pentagono", 3.4, 5, 5.5);
            //QuaUltraGono hexagono = new QuaUltraGono("Hexagono", 4.3, 6, 4.6);
            //QuaUltraGono octagono = new QuaUltraGono("Octagono", 5, 8, 3);
            //Rombo rombo = new Rombo("Rombo", 5, 4, 8);

            //Triangulo triangulo = new Triangulo("Triangulo", 5, 4.5);

            //Circunferencia circulo = new Circunferencia("Circulo", 3.5);
            //Elipse elipse = new Elipse("Elipse", 3.2, 5);

            //Console.WriteLine($"Cuadrado P = {cuadrado.Perimetro()} y A = {cuadrado.Area()} ({cuadrado})");
            //Console.WriteLine($"Rectangulo P = {rectangulo.Perimetro()} y A = {rectangulo.Area()} ({rectangulo})");
            //Console.WriteLine($"Pentagono P = {pentagono.Perimetro()} y A = {pentagono.Area()} ({pentagono})");
            //Console.WriteLine($"Hexagono P = {hexagono.Perimetro()} y A = {hexagono.Area()} ({hexagono})");
            //Console.WriteLine($"Octagono P = {octagono.Perimetro()} y A = {octagono.Area()} ({octagono})");
            //Console.WriteLine($"Rombo P = {rombo.Perimetro()} y A = {rombo.Area()} ({rombo})");
            //Console.WriteLine($"Triangulo P = {triangulo.Perimetro()} y A = {triangulo.Area()} ({triangulo})");
            //Console.WriteLine($"Circulo P = {circulo.Perimetro()} y A = {circulo.Area()} ({circulo})");
            //Console.WriteLine($"Elipse P = {elipse.Perimetro()} y A = {elipse.Area()} ({elipse})");



            List<Figura> listaFigurasDiagrama = new List<Figura>();

            Random rnd = new Random();

            int numeroFiguras = rnd.Next(25);

            // Genero las figuras
            for (int i = 0; i < numeroFiguras; i++)
            {
                int figura = rnd.Next(5); // Numero aleatorio del 0 al 4

                switch ((eFiguras)figura)
                {
                    case eFiguras.Rectangulo:
                        listaFigurasDiagrama.Add(new Rectangulo(rnd.Next(25), rnd.Next(100)));
                        break;
                    case eFiguras.Triangulo:
                        listaFigurasDiagrama.Add(new Triangulo(rnd.Next(25), rnd.Next(25), rnd.Next(25), rnd.Next(25)));
                        break;
                    case eFiguras.Rombo:
                        listaFigurasDiagrama.Add(new Rombo(rnd.Next(5), rnd.Next(10)));
                        break;
                    case eFiguras.Elipse:
                        listaFigurasDiagrama.Add(new Elipse(rnd.Next(3), rnd.Next(5)));
                        break;
                }
            }

            Diagrama diagrama = new Diagrama(listaFigurasDiagrama);

            Console.WriteLine($"Perimetro Total diagrama:  {diagrama.PerimetroTotal()}");
            Console.WriteLine($"Area Total diagrama:       {diagrama.AreaTotal()}");

            Console.ReadKey();
        }
    }
}
