using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    JustAClass a = new JustAClass();

    a.Method();
    Console.WriteLine(a.value);

    a.Method(7);
    Console.WriteLine(a.value);

    a.Method("7");
    Console.WriteLine(a.value);
    Console.ReadKey();
}

class JustAClass
{
    public int value { get; set; }
    public void Method()
    {
        value = 5;
    }
    public void Method(int input)
    {
        value = input;
    }
    public void Method(string input)
    {
        value = 10;
    }
}