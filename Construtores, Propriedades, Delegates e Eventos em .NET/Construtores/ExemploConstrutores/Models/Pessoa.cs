namespace ExemploConstrutores.Models
{
    public class Pessoa
    {
        private string nome;
        private string sobrenome;

       /*  public Pessoa() //Construtor vazio.
        {
            nome = string.Empty;
            sobrenome = String.Empty;
        }
 */
        public Pessoa(string nome, string sobrenome) //Recebe nome e sobrenome
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            Console.WriteLine("Construtor classe pessoa");
        }

        public void Apresentar(){
            Console.WriteLine($"Ola meu nome é: {nome} {sobrenome}");

        }
    }
}