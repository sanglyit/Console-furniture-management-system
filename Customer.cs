using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniture_Manager
{
    internal class Customer
    {
        public String CName { get; set; }
        public int Phone { get; set; }
        ArrayList ListOrder = new ArrayList();
        public void Order(Furniture o)
        {
            Console.Write("\nInput customer name: ");
            CName = Console.ReadLine();
            Console.Write("Input customer phone number: ");
            Phone = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input furniture ID: ");
            o.Id = Console.ReadLine();
            Console.Write("Input furniture name: ");
            o.Name = Console.ReadLine();
            Console.Write("Input furniture Price: ");
            o.Price = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input furniture Description: ");
            o.Description = Console.ReadLine();
            ListOrder.Add(o);
        }

        public void ViewOrder()
        {
            Console.WriteLine("List of Order: ");
            if (ListOrder.Count == 0)
            {
                Console.WriteLine("No new order has been placed.");
            }
            else
            {
                foreach (Furniture o in ListOrder)
                {
                    o.Show();
                }
            }
        }
    }
}
