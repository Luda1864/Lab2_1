using System;


namespace zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassLibrary1.Complex t1 = new ClassLibrary1.Complex(1, 1);
            ClassLibrary1.Complex t2 = new ClassLibrary1.Complex(2, 3), t3;
            t3 = ClassLibrary1.Complex.sum(t1, t2);
            Console.WriteLine(t1.ToString());
            Console.WriteLine(t2.ToString());
            Console.WriteLine(t3.ToString());
        }
    }
}
