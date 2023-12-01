namespace ExtensionReviewMethod;
//class sd theo cac phuong thuc mow rong( extension method)
//buoc phai la static class
//toan bo ben trong class deu phai la static
static class ExtMethod
{
    public static bool IsGreater(this int i, int value) =>  i > value;
    public static void Hi(this Program obj) => Console.WriteLine("xin chao");
}
