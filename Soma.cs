using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio1
{
    class Soma
    {

        private int a;
        private int b;
        private int c;
        private int soma;
       
        
        public void SetValores()
        {
     
            Console.WriteLine("Digite A");
            this.a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite B");
            this.b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite C");
            this.c = int.Parse(Console.ReadLine());
            this.soma = a + b + c;
           
        }

        public int GetSoma() {

            return soma;
        }







    }
}
