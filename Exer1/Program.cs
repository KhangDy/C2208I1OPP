using Exer1.ExtMethod;
using Exer1.ValiDate;
using Exercise1.Dao;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

var loop = true;
var list = new ListProduct();
while (loop)
{
    Console.ResetColor();
    Console.WriteLine("1 - nhap danh sach san pham: ");
    Console.WriteLine("2 - in danh sach san pham: ");
    Console.WriteLine("3 - xoa san pham: ");

    Console.WriteLine("chon bat ki so nao khac o tren de thoat: ");

    var choose = Valid<int>.CheckCR("vui long chon so: ");
    switch (choose)
    {
        case 1:
            list.ChangeColor(ConsoleColor.Black, ConsoleColor.Cyan);
            list.AddProduct();
            break;
        case 2:
            list.ChangeColor(ConsoleColor.Green, ConsoleColor.Red);
            list.ShowProduct();
            break;
        case 3:
            list.ChangeColor(ConsoleColor.Green, ConsoleColor.Red);
            list.DeleteProduct();
            break;
        default:
            loop = false;
            break;

    }
}