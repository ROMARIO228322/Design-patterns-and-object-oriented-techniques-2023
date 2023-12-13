using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Menus
{
    internal class ModelforMenus
    {
        // ALL of the existing menu items there constructors are listed here as a map.
        public class MenuItem
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public bool Vegetarian { get; set; }
            public double Price { get; set; }

            public MenuItem(string name, string description, bool vegetarian, double price)
            {
                Name = name;
                Description = description;
                Vegetarian = vegetarian;
                Price = price;
            }

            public string GetName()
            {
                return Name;
            }

            public string GetDescription()
            {
                return Description;
            }

            public Boolean IsVegetarian()
            {
                return Vegetarian;
            }

            public double GetPrice()
            {
                return Price;
            }
        }
    }
}
