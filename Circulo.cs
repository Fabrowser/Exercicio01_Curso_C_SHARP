using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio1
{
    class Circulo
    {

        private double r;
        private double area;
        private double pi;


        public void SetRaio()
        {
            this.pi = 3.14;
            Console.WriteLine("Digite o Raio");
            this.r = double.Parse(Console.ReadLine());
            SetArea(r, pi);
        }

        public void SetArea(double raio, double p)
        {
            
            this.area = Math.Pow((p*raio),2);
         }

        public double GetArea()
        {
            return this.area;
        }

    }
}
