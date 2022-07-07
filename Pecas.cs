using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio1
{
    class Pecas
    {
        public int cod;
        public string Nome;
        public double Valor;



        dynamic pecas = new List<dynamic>();

  
        public void RecebeValores()
        {
            Console.WriteLine("Digite a quantidade de Peças");
            int n = int.Parse(Console.ReadLine());

            for (int i=0;i<n;i++)
            {

                Console.WriteLine("Digite o nome da Peça: ");
                string nome = Console.ReadLine();

                Console.WriteLine("Digite o valor da Peça: ");
                double valor = double.Parse(Console.ReadLine());

                SetPecas(i, nome, valor);
            }

        }


        public void SetPecas(int n, string nome, double valor)
        {

            pecas.Add(new Pecas());

            pecas[n].cod = n;
            pecas[n].Nome = nome;
            pecas[n].Valor = valor;
        }

        public void getPecas()
        {
            Console.WriteLine("-------------PEÇAS CADASTRADAS------------");
            foreach (var p in pecas)
            {
                Console.WriteLine(($"{p.cod+1} - { p.Nome} - {p.Valor}"));
            }

            Console.WriteLine("--------------------//--------------------");

        }

        public override string ToString()
        {
            return "";
        }

    }

}
