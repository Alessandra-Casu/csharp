// See https://aka.ms/new-console-template for more information


using System;

namespace IntegralTypes
{
    class Program
    {
         static void Main(string[] args)
        {
            int a = 500;
            short b = 100;
            sbyte c = -50;
            long d = 100_000_000L;
            int e = 0b10101010;
            ushort f = 0x0A56;

            Console.WriteLine("a = {0}, b = {1}, c = {2}, d = {3}, e = {4}, f = {5}", a, b, c, d, e, f);
            Console.WriteLine($"a = {a}, b = {b}, c = {c}, d = {d}, e = {e}, f = {f}");
        }
    }

}
