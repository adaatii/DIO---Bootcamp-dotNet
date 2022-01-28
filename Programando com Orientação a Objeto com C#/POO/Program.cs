using POO.Models;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {


            Calculadora calc = new Calculadora();
            System.Console.WriteLine("Resultado da primeira soma: " + calc.Somar(10, 10));
            System.Console.WriteLine("Resultado da segunda soma: " + calc.Somar(10, 10, 10));


            // Professor p1 = new Professor();
            // p1.Salario = 2000;            
            // p1.Nome = "Bob";
            // p1.Idade = 20;

            // p1.Apresentar();


            // Aluno p2 = new Aluno();
            // p2.Nome = "Bob";
            // p2.Idade = 20;
            // p2.Nota = 10;

            // p2.Apresentar();



            // //Valores válidos
            // Retangulo r = new Retangulo();
            // r.DefinirMedidas(30, 30);
            // Console.WriteLine($"Área: {r.ObterArea()}");

            // //Valores inválidos
            // Retangulo r2 = new Retangulo();
            // r.DefinirMedidas(0, 30);
            // Console.WriteLine($"Área: {r2.ObterArea()}");



            // Pessoa p1 = new Pessoa();

            // p1.Nome = "Bob";
            // p1.Idade = 20;

            // p1.Apresentar();
        }
    }
}