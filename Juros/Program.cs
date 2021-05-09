using System;
using System.Globalization;

namespace Juros {
    class Program {
        static void Main(string[] args) {


            while (true) {
                Console.WriteLine("Você deseja o calculo de:");
                Console.WriteLine("1- Juros simple;\n2- Juros compostos;");
                Console.Write("Opção: ");
                int op = int.Parse(Console.ReadLine());

                if(op == 1 || op == 2) {
                    AddVariaveis(op);
                }
                else {
                    Console.WriteLine("Opção invalida.\n");
                }
            }
        }

        static void AddVariaveis(int op) {
            double montante;

            Console.Write("\nInforme o capital: ");
            double capital = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Informe a taxa em % ao mês: ");
            double taxa = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Informe o prazo em meses: ");
            int tempo = int.Parse(Console.ReadLine());

            if(op == 1) {
                JurosSimples simples = new JurosSimples(capital, taxa, tempo);

                montante = simples.Calcular();

                Console.WriteLine($"O total a se pagar será R${montante.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else {
                JurosCompostos compostos = new JurosCompostos(capital, taxa, tempo);

                montante = compostos.Calcular();

                Console.WriteLine($"O total a se pagar será R${montante.ToString("F2", CultureInfo.InvariantCulture)}");
            }

            return;
        }
    }
}
