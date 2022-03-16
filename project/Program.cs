using System;
using System.Globalization;

namespace Fernando
{
    class Program
    {
        static void Main(string[] args)
        {
            Guest[] guests = new Guest[10];

            System.Console.Write("How many rooms will be rented? ");
            int quant = int.Parse(Console.ReadLine());

            for(int i = 1; i <= quant; i++)
            {
                System.Console.WriteLine($"Rent #{i}: ");
                System.Console.Write("Name: ");
                string name = Console.ReadLine();
                System.Console.Write("Email: ");
                string email = Console.ReadLine();
                System.Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());
                System.Console.WriteLine();

                guests[room] = new Guest{ Name = name, Email = email};
            }

            System.Console.WriteLine("Busy Rooms: ");
            for(int i = 0; i < guests.Length; i++)
            {
                if(guests[i] != null)
                    System.Console.WriteLine($"{i}: {guests[i]}");
            }
        }
    }
}