using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer1.ValiDate;
internal class Valid<T>
{
    public static T CheckCR(string message)
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;

        Console.WriteLine(message);
        var type = Type.GetTypeCode(typeof(T));
        var i = new object();
        bool flag;
        do
        {
            flag = true;
            try
            {
                var str = Console.ReadLine();
                //guard clause - design pattern
                if (string.IsNullOrEmpty(str))
                {
                    throw new Exception("loi, null hay empty");
                }
                switch (type)
                {
                    case TypeCode.String:
                        i = str;
                        if (((string)i).Length < 5)
                            throw new Exception("loi, chieu dai chuoi phai >= 5");
                        break;
                    case TypeCode.Int32:
                        i = Convert.ToInt32(str);
                        if ((int)i <= 0)
                            throw new Exception("loi, so phai >= 0");
                        break;
                    case TypeCode.Double:
                        i = Convert.ToDouble(str);
                        break;
                    case TypeCode.DateTime:
                        var date = DateTime.TryParseExact(str, ["dd-MM-yyyy", "dd/MM/yyyy"], new CultureInfo("vi-VN"), DateTimeStyles.None, out DateTime t) ? t : throw new Exception("loi, phai la dd-MM-yyyy hay dd/MM/yyyy");
                        i = date.Add(DateTime.Now.TimeOfDay);
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message}, nhap lai");
                flag = false;
            }
        } while (!flag);

        return (T)i;
    }
}
