using ExtensionReviewMethod;
using System.Text;

Console.InputEncoding = System.Text.Encoding.UTF8;
Console.OutputEncoding = System.Text.Encoding.UTF8;
//nhap vao bien i
Console.WriteLine("vui long nhap so: ");
int i = int.TryParse(Console.ReadLine(), out var result) ? result : 0;
//xuat ra bien i
Console.WriteLine($"{nameof(i)} = {i}");

//so sanh i voi gia tri bat ki
Console.WriteLine("so sanh gia tri i voi so bat ki");

Console.WriteLine(Valid.isGreaterThan(i, 100) ? "i lon hon" : "i khong lon hon");

//so sanh i voi gia tri bat ki, sung ext method
Console.WriteLine("so sanh gia tri i voi so bat ki");

Console.WriteLine(i.IsGreater(100) ? "i lon hon" : "i khong lon hon");

int x = 50;

Console.WriteLine(x.IsGreater(10) ? "x>10" : "x<=10");

//====
Program pro1 = new();
pro1.Hi();