using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PrimeiroProjetoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = "Ana Ceclia";
            int idade = 16;
            string cidade = "Campos do Jordão";


            Console.WriteLine(" Digite o seu nome");
            nome = Console.ReadLine();
            Console.WriteLine(" digite sua idade");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine(" Digite sua cidade");
            cidade = Console.ReadLine();
            Console.WriteLine("Nome: {0} \n Idade: {1} anos \n Cidade: {2}" ,nome, idade, cidade);
        }
    }
}
