using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program;
public abstract class Human
{
    public string? FullName { get; set; }
    public int Age { get; set; }

    public abstract void ShowInfo();

    public override string ToString()
    {
        return $"{{{nameof(FullName)}={FullName}, {nameof(Age)}={Age.ToString()}}}";
    }
}