using StockExercise;
using System;
using System.Globalization;


namespace MyApp {
    internal class Program {
        static void Main(string[] args) {

            Product p;

            p = new Product();

            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            p.Name = Console.ReadLine();
            Console.Write("Preço: ");
            p.Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Qtd = int.Parse(Console.ReadLine());

            Console.WriteLine($"Dados do produto: " + p);

            int userQtd;

            Console.Write("Digite o número de produtos a serem adicionados ao estoque: ");
            userQtd = int.Parse(Console.ReadLine());
            p.AddToStock(userQtd);
            Console.WriteLine($"Dados atualizados: " + p);

            Console.Write("Digite o número de produtos a serem removidos do estoque: ");
            userQtd = int.Parse(Console.ReadLine());
            p.RemoveFromStock(userQtd);
            Console.WriteLine($"Dados atualizados: " + p);


        }
    }
}