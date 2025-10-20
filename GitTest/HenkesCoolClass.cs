using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest;

public class HenkesCoolClass
{
    public string CoolString { get; set; }

    public HenkesCoolClass()
    {
        CoolString = "Henke is cool";
    }

    public void CoolMethod()
    {
        Console.WriteLine(CoolString);
    }
}
