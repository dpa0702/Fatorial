using System;

namespace Fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Fatorial(0);
            Fatorial(1);
            Fatorial(2);
            Fatorial(3);
            Fatorial(4);
            Fatorial(5);
            Fatorial(6);
            Fatorial(7);
            Fatorial(8);
            Fatorial(9);
            Fatorial(10);
            Fatorial(11);
        }

        public static void Fatorial(int num)
        {
            var total = 1;
            var texto = "";

            for (var a = num; a > 0; a--)
            {
                total = total * a;
                texto = texto + a + "x";
            }

            if(num != 0)
            {
                Console.WriteLine(num + "! = " + texto.Substring(0, (texto.Length - 1)) + " = " + total);
            }
            else
            {
                Console.WriteLine(num + "! = " + total);
            }
        }
    }
}
