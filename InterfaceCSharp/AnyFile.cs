namespace InterfaceCSharp;
internal class AnyFile : ITextFile, IBinaryFile
{
    public void WriteBinaryFile() => Console.WriteLine("write binary file");
    public void WriteTextFile() => Console.WriteLine("write text file");
    //dùng chính cái interface, nên không được phép public 
    void ITextFile.ReadFile() => Console.WriteLine("read file");
    //dùng chính cái interface, nên không được phép public 
    void IBinaryFile.ReadFile() => Console.WriteLine("read file");

}