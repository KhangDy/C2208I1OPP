using System.Collections;
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

ArrayList arrayList1= new ();
arrayList1.Add("dy");
arrayList1.Add("5");
arrayList1.Add(true);

ArrayList arrayList2 = ["dy", 6, false];

for (int i = 0; i < arrayList1.Count; i++)
{
    Console.WriteLine(arrayList1[i]);
}

foreach (var item in arrayList2)
{
    Console.WriteLine(item);
}

