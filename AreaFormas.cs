using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio1
{
    class AreaFormas
    {

        private double A;
        private double B;
        private double C;

        public AreaFormas()
        {
            Console.WriteLine("Digite o valor de A: ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de B: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de C: ");
            double c = double.Parse(Console.ReadLine());

            this.A = a;
            this.B = b;
            this.C = c;

        }

        public double AreaTriangulo() {

            double area_triangulo = A * C / 2;
            return area_triangulo;
  
        }

        public double AreaCirculo()
        {
            double area_circulo = Math.Pow((3.14159 *C), 2);
            return area_circulo;
        }

        public double AreaTrapezio()
        {
            double area_trapezio = ((A +B) * C) / 2;
            return area_trapezio;
        }

        public double AreaQuadrado()
        {

            double area_quadrado = Math.Pow(B, 2);
            return area_quadrado;

        }

        public double AreaRetangulo()
        {
            double area_ret = A *B;
            return area_ret;

        }


    }
}
