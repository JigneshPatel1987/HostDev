using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _087Nov18
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine(Function.addnumber(num1, num2));

            Function inst = new Function();
            Console.WriteLine(inst.addnumber1(num1, num2));
            Console.ReadKey();

        }



    }
    
}
