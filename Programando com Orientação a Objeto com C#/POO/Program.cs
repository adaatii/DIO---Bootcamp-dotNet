using POO.Helper;
using POO.Interfaces;
using POO.Models;


namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            var caminho = @"/home/adaatii/Documentos/Github/DIO---Curso-de-dotNet/Programando com Orientação a Objeto com C#/Trabalhando com Arquivos/";
            var caminhoPathCombine = Path.Combine(caminho, "Pasta Teste 1");
            var caminhoArquivo = Path.Combine(caminho, "arquivo-teste-stream.txt");
            var novoCaminhoArquivo = Path.Combine(caminho, "Pasta Teste 2", "arquivo-teste-stream.txt");
            var caminhoArquivoTeste = Path.Combine(caminho, "arquivo-teste.txt");
            var caminhoArquivoTesteCopia = Path.Combine(caminho, "arquivo-teste-bkp.txt");

            var listaString = new List<string> {"linha 1", "linha 2", "linha 3"};
            var listaStringContinuacao = new List<string> {"linha 4", "linha 5", "linha 6"};
            
            FileHelper helper = new FileHelper();           
  
            //helper.ListarDiretorios(caminho);
            //helper.ListarArquivosDiretories(caminho);            
            //helper.CriarDiretorio(Path.Combine(caminhoPathCombine));
            //helper.ApagarDiretorio(caminhoPathCombine, true);
            //helper.CriarArquivoTexto(caminhoArquivo, "Teste de escrita de arquivo");
            //helper.CriarArquivoTextoStream(caminhoArquivo, listaString);
            //helper.AdicionarTextoStream(caminhoArquivo, listaStringContinuacao);
            //helper.LerArquivoStream(caminhoArquivo);
            //helper.MoverArquivos(caminhoArquivo, novoCaminhoArquivo, false);
            //helper.CopiarArquivo(caminhoArquivoTeste, caminhoArquivoTesteCopia, false);
            helper.DeletarArquivo(caminhoArquivoTesteCopia);


            // ICalculadora calc = new Calculadora();
            // System.Console.WriteLine(calc.Somar(10, 20));

            // Corrente c = new Corrente();
            // c.Creditar(100);
            // c.ExibirSaldo();
          
            // Calculadora calc = new Calculadora();
            // System.Console.WriteLine("Resultado da primeira soma: " + calc.Somar(10, 10));
            // System.Console.WriteLine("Resultado da segunda soma: " + calc.Somar(10, 10, 10));


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