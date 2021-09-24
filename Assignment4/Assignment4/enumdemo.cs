using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4
{
    class enumdemo
    {
        static void Main()
        {

            var names = Enum.GetValues(typeof(cityCode));
            foreach (var name in names)
            {
                Console.WriteLine("{0}={1}", name, name.GetHashCode());
            }

            Console.ReadLine();
        }
    }
}
