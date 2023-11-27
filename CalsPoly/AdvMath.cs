using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalsPoly;
internal class AdvMath : BasicMath
{
    public override void Divide()
    {
        try 
        {
            Console.WriteLine(NumberOne / NumberTwo);
        } 
        catch (Exception ) when (NumberTwo == 0)
        {
            Console.WriteLine("NumberTwo phai khac 0");

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
       
    }
}
