using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniture_Manager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            Manager m = new Manager();
            Customer c = new Customer();
            do
            {
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("-Furniture Management System-");
                Console.WriteLine("1) Add new furniture to inventory");
                Console.WriteLine("2) Search for a furniture");
                Console.WriteLine("3) View all furniture");
                Console.WriteLine("4) Remove an furniture from inventory");
                Console.WriteLine("5) Make a order");
                Console.WriteLine("6) Show all order information");
                Console.WriteLine("7) Exit");

                Console.Write("\nEnter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Furniture f = new Furniture();
                        m.Add(f);
                        break;
                    case 2:
                        m.Search();
                        break;
                    case 3:
                        m.View();
                        break;
                    case 4:
                        Console.Write("Enter a furniture ID: ");
                        String removefID = Console.ReadLine();
                        m.Remove(removefID);
                        Console.ReadKey();
                        break;
                    case 5:
                        Furniture o = new Furniture();
                        c.Order(o);
                        break;
                    case 6:
                        c.ViewOrder();
                        break;
                    case 7:
                        exit = true;
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            } while (!exit);
            Console.ReadLine();
        }
    }
}
