using System.IO;
using static System.Console;

WriteLine("Digite o nome do arquivo");

var nome = ReadLine();

nome = LimparNome(nome);

var path = Path.Combine(Environment.CurrentDirectory, $"{nome}.txt");

CriarArquivo(path);

WriteLine("Aperte Enter para finalizar");
ReadLine();


//substitui caracteres invalidos por '-'
static string LimparNome(string nome)
{
    foreach (var @char in Path.GetInvalidFileNameChars())
    {
        nome = nome.Replace(@char, '-');
    }
    return nome;
    

}

//interface IDisposable - pode ter finalização forçada pela aplicação 
//(neste caso faz o Flush de forma automatica) 
static void CriarArquivo(string path)
{
    try
    {
        using var sw = File.CreateText(path);
        sw.WriteLine("Esta é a linha 1 do arquivo");
        sw.WriteLine("Esta é a linha 2 do arquivo");
        sw.WriteLine("Esta é a linha 3 do arquivo");
        sw.Flush();
    }
    catch (System.Exception)
    {

        WriteLine("O nome do arquivo é invalido");
    }

}



//A linhas só são descarregadas da memória para o arquivo após ser dados um Flush,
//caso contrário o StreamWriter continua em memória pois não foi finalizado de forma correta. 

/*var sw = File.CreateText(path);
sw.WriteLine("Esta é a linha 1 do arquivo");
sw.WriteLine("Esta é a linha 2 do arquivo");
sw.WriteLine("Esta é a linha 3 do arquivo");
sw.Flush();*/