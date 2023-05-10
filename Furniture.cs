using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniture_Manager
{
    internal class Furniture
    {
        public String Name { get; set; }
        public String Description { get; set; }
        public String Id { get; set; }
        public int Price { get; set; }
        public Furniture() { }
        public Furniture(string name, string description, string id, int price)
        {
            this.Name = name;
            this.Description = description;  
            this.Id = id;
            this.Price = price;
        }

        public void Show()
        {
                Console.WriteLine("\nID: " + Id);
                Console.WriteLine("Name: " + Name);
                Console.WriteLine("Description: " + Description);
                Console.WriteLine("Price: " + Price);
        }
    }
}
