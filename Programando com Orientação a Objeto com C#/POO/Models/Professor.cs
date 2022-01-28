namespace POO.Models
{
    public class Professor : Pessoa
    {
        public double Salario { get; set; }

          public /* sealed */ override void Apresentar() // sealed trava o comportamento na classe pai.
        {
            Console.WriteLine($"Ola meu nome é {Nome} sou um professor, e ganho {Salario}");
        }
    }
}