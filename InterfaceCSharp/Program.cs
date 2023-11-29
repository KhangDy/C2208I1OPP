using InterfaceCSharp;

SomeFile file = new();
file.WriteTextFile();  //cua ibinaryfile
file.WriteBinaryFile(); //cua itextfile
file.ReadFile(); //dung chung vi ca 2 deu co ReadFile
((IBinaryFile)file).ReadFile();  //cua ibinaryfile, C# old

(file as ITextFile).ReadFile(); //cua itextfile, c# new

AnyFile anyFile = new();
anyFile.WriteBinaryFile();
anyFile.WriteTextFile();
(anyFile as ITextFile).ReadFile();
(anyFile as IBinaryFile).ReadFile();
(anyFile as IBinaryFile).ShowInfo();

