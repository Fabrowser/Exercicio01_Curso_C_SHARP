using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio1
{
    class Diferenca
    {

        private int A;
        private int B;
        private int C;
        private int D;
        private int diferenca;


        public void RecebeValores()
        {

            Console.WriteLine("Digite o valor de A: ");
            this.A = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de B: ");
            this.B = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de C: ");
            this.C = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de D: ");
            this.D = int.Parse(Console.ReadLine());

            this.CalculaDiferenca();

        }

        public void CalculaDiferenca() {


            this.diferenca = (this.A * this.B - this.C * this.D);
        
        
        }


        public int GetDiferenca() {


            return this.diferenca;
 
        
        }



    }
}
