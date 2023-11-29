using ListandLinq;
using System.Collections;
using System.Diagnostics;
using System.Globalization;
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

List<Student> list1 = new();
list1.Add(new Student() { RollNumber = 1, FullNmae = "DUY", Section = "day 1", RoomNumber = 2 });
list1.Add(new Student() { RollNumber = 4, FullNmae = "tui", Section = "day 3", RoomNumber = 14 });

List<Student> list2 = [
new Student() { RollNumber = 1, FullNmae = "DUY", Section = "day 1", RoomNumber = 2 },
new Student() { RollNumber = 4, FullNmae = "tui", Section = "day 3", RoomNumber = 14 }
];

//Do toc do
Stopwatch sw = new();
//khoi dong bang cach retart lai
sw.Restart();


foreach (var item in list1)
{
    Console.WriteLine(item);
}

sw.Stop();
Console.WriteLine($"foreach run: {sw.ElapsedMilliseconds}");
Console.WriteLine("==========");

//khoi dong lai bang cach retart lai
sw.Restart();
IEnumerator enu = list1.GetEnumerator();
while (enu.MoveNext())
{
    Console.WriteLine(enu.Current.ToString());
}

sw.Stop();
Console.WriteLine($"ienumerator run: {sw.ElapsedMilliseconds}"); 
Console.WriteLine("===============");

//duyet qua list chi lay roomnumber lon hon 2

foreach (var stud in list1)
{
    if (stud.RoomNumber >2)
    {
        Console.WriteLine(stud);
    }
}

//linq co 2 style viet
//a) query syntax => dung cu phap cua sql theo cau truc 
//from [bien/ doi tuong] in [danh sach]
//where dieu kien la gi do (bien > hay < gi do)
//group by gom nhom
//having xet dieu kien cho nhom group by
//order by sap xep
//cuoi cung moi la select

//var listStu = from stu in list1
//              where stu.RoomNumber == 2
//              select stu;
//Console.WriteLine(listStu.Count());
foreach (var t in from stu in list1
                  where stu.RoomNumber >2
                  orderby stu.RollNumber descending
                  select stu)
{
    Console.WriteLine(t);
}

//rut gon code
foreach ( var t in from stu in list1
                   where stu.RoomNumber >2
                   select stu)
{
    Console.WriteLine(t);
}

//b) method syntax (su dung lamba)
var x = list1.Where(u => u.RollNumber > 2);
foreach (var i in x)
{
    Console.WriteLine(x);
}

//rut gon lai
foreach ( var i in list2.Where(u => u.RollNumber > 2))
{
    Console.WriteLine(i);
}

//ban than collection co luon foreach
list1.ForEach(Console.WriteLine);
list1.ForEach (stu => Console.WriteLine(stu.FullNmae));

list1.ForEach(
    stu =>
    {
        if (stu.RoomNumber > 2)
        {
            Console.WriteLine(stu);
        }
    }
);

list1.Where(u => u.RollNumber > 2)
    .ToList()
    .ForEach(Console.WriteLine);

//QUERY SYNTAX
(from stu in list1
 where stu.RoomNumber > 2
 select stu).ToList().ForEach(Console.WriteLine);