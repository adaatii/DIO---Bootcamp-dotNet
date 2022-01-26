using System.IO;


var path = Path.Combine (Environment.CurrentDirectory, "teste.txt");

//interface IDisposable - pode ter finalização forçada pela aplicação 
//(neste caso faz o Flush de forma automatica) 

using var sw = File.CreateText(path);
sw.WriteLine("Esta é a linha 1 do arquivo");
sw.WriteLine("Esta é a linha 2 do arquivo");
sw.WriteLine("Esta é a linha 3 do arquivo");

//A linhas só são descarregadas da memória para o arquivo após ser dados um Flush,
//caso contrário o StreamWriter continua em memória pois não foi finalizado de forma correta. 

/*var sw = File.CreateText(path);
sw.WriteLine("Esta é a linha 1 do arquivo");
sw.WriteLine("Esta é a linha 2 do arquivo");
sw.WriteLine("Esta é a linha 3 do arquivo");
sw.Flush();*/