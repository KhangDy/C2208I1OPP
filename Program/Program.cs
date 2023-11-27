using Program;
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

//object initializer => giam thieu constructor
Teacher teacher = new()
{
    FullName = "dy",
    Age = 46,
};

teacher.ShowInfo();
Console.WriteLine(teacher);