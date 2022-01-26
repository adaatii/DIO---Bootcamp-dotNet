using System.IO;

var path = Path.Combine(Environment.CurrentDirectory,"globo");
var dirGlobo = Directory.CreateDirectory(path);
var dirAmNorte  = dirGlobo.CreateSubdirectory("América do Norte");
var dirAmCentral  = dirGlobo.CreateSubdirectory("América Central");
var dirAmSul  = dirGlobo.CreateSubdirectory("América do Sul");

dirAmNorte.CreateSubdirectory("USA");
dirAmNorte.CreateSubdirectory("Mexico");
dirAmNorte.CreateSubdirectory("Canada");

dirAmCentral.CreateSubdirectory("Costa Rica");
dirAmCentral.CreateSubdirectory("Panamá");

dirAmSul.CreateSubdirectory("Brasil");
dirAmSul.CreateSubdirectory("Argentina");
dirAmSul.CreateSubdirectory("Paraguai");