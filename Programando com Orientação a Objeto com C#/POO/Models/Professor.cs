namespace POO.Models
{
    public class Professor : Pessoa
    {
        public double Salario { get; set; }

          public override void Apresentar()
        {
            Console.WriteLine($"Ola meu nome é {Nome} sou um professor, e ganho {Salario}");
        }
    }
}