using System;
using System.Collections.Generic;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {

            int opcao = -1;

            while (opcao != 0)
            {

                Console.WriteLine("Digite a opção desejada: \n \n [1] - Soma dois valores \n [2] -"+
                    " Área do Círculo \n [3] - Diferença  \n [4] - Calcula Salário Funcionário \n [5]" +
                    " - Calcula Peças \n [6] - Área das Formas\n [0] - Sair ");

                opcao = int.Parse(Console.ReadLine());

           
                switch (opcao)
                { 
                    case 1: 
                        
                        {
                            Soma s1 = new Soma();
                            s1.SetValores();
                            Console.WriteLine($"Soma: {s1.GetSoma()}");
                            break;
                        }
                    case 2:

                        {
                            Circulo c1 = new Circulo();
                            c1.SetRaio();
                            Console.WriteLine($"Soma: {c1.GetArea()}");
                            break;
                        }

                    case 3:
                        {
                            Diferenca d1 = new Diferenca();
                            d1.RecebeValores();
                            Console.WriteLine($"Diferença (A * B - C * D) = {d1.GetDiferenca()}");
                            break;
                        }

                    case 4:
                        {
                            Funcionario f1  = new Funcionario();

                            Console.WriteLine($"O Salário do funcionário é:  = R$ {f1.getSalario().ToString("F2")}");
                            break;
                        }

                    case 5:
                        {

                            Pecas p1 = new Pecas();

                            p1.RecebeValores();

                            p1.getPecas();

                            Console.WriteLine(p1);
                            
                            break;
                        }

                    case 6:
                        {

                            AreaFormas a = new AreaFormas();

                            Console.WriteLine("Area Trapézio: " + a.AreaTrapezio() + " m²");
                            Console.WriteLine("Area Triângulo: " + a.AreaTriangulo() + " m²");
                            Console.WriteLine("Area Círculo: " + a.AreaCirculo() + " m²");
                            Console.WriteLine("Area Quadrado: " + a.AreaQuadrado() + " m²");
                            Console.WriteLine("Area Retângulo: " + a.AreaRetangulo() + " m²");

                            break;
                        }

                    default:
                        {

                            break;

                        }
                }

            }
        }
    }
}
