using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio1
{
    class Funcionario
    {


        private int cdFuncionario;
        private double salario;
        private int horas;
        private double vlHora;

        public Funcionario() // Construtor dos atributos
        {

            Console.WriteLine("Digite o Código do Funcionário: ");
            this.cdFuncionario = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a qtde de horas trabalhadas: ");
            this.horas = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor/hora: ");
            this.vlHora= int.Parse(Console.ReadLine());

            this.setSalario();

        }


        public void setSalario()
        {
            this.salario = (this.vlHora * this.horas);


        }

        public double getSalario() {

            return this.salario;
        }

    }
}
