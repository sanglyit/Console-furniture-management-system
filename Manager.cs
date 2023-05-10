using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniture_Manager
{
    internal class Manager
    {
        ArrayList ListFurniture = new ArrayList();
        public void Add(Furniture f)
        { 
            Console.Write("\nInput furniture ID: ");
            f.Id = Console.ReadLine();
            Console.Write("Input furniture name: ");
            f.Name = Console.ReadLine();
            Console.Write("Input furniture Price: ");
            f.Price = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input furniture Description: ");
            f.Description = Console.ReadLine();
            ListFurniture.Add(f);
        }
        public void View()
        {
            Console.WriteLine("List of Furnitures: ");
            if (ListFurniture.Count == 0)
            {
                Console.WriteLine("No new Furniture has been added.");
            }
            else
            {
                foreach (Furniture f in ListFurniture)
                {
                    f.Show();
                }
            }
        }
        public void Search()
        {
            bool Found = false;
            Console.Write("Input furniture name: ");
            String search = Console.ReadLine();
            Console.WriteLine("List of all the furnitures with the name " + search);
            foreach (Furniture f in ListFurniture)
            {
                if (f.Name == search)
                {
                    f.Show();
                    Found = true;
                }
            }
            if (!Found)
            {
                Console.WriteLine("No Furniture were found!");
            }
        }
        public void Remove(String id)
        {
            foreach (Furniture f in ListFurniture)
            {
                if (f.Id == id)
                {
                    this.ListFurniture.Remove(f);
                    Console.WriteLine("A Furniture has been removed");
                    break;
                }
                else
                {
                    Console.WriteLine("Cannot find a Furniture with similar id to remove");
                }
            }
        }
    }
}
