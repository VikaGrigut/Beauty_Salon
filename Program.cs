using System;

namespace Beauty_Salon
{
    class Program
    {
        static void Main(string[] args)
        {
            Client vika = new Client("Vika", "Grigut", 03, 03, 2004, 1, 2500, "+375297850414");
            Console.WriteLine(vika.date_of_birth);
        }
    }
}
