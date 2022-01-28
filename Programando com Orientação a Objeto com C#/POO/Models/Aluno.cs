namespace POO.Models
{
    public class Aluno : Pessoa
    {
        public int Nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Ola meu nome é {Nome} e sou um aluno de nota {Nota}");
        }

    }
}