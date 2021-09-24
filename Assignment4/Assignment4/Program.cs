using System;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student(2, "Veena", "female", 12345678);
            Console.WriteLine(st.Display());

            Console.ReadLine();

        }
    }
}
