using Iterator.ConcreteIterator;
using Iterator.InterfaceIterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Iterator.Menus.ModelforMenus;

namespace Iterator.Menus
{
    public class DinerMenu
    {
       
         private int Max_Items = 6;
         int numberOfItems = 0;
         MenuItem[] MenuItems;

         public DinerMenu()
         {
         MenuItems = new MenuItem[Max_Items];

         AddItem("Vegetarian BLT", "(Fakin´) Bacon with lettuce & tomato on whole wheat", true, 2.99);
         AddItem("BLT", "Bacon with lettuce & tomato on whole wheat", false, 2.99);
         AddItem("Soup of the day", "Soup of the day, with a side of potato salad", false, 3.29);
         AddItem("HotDog", "A hot dog, with saurkraut, relish, onions, topped with cheese", false, 3.29);
            AddItem("Steamed Veggies and Brown Rice", "Steamed Vegetable over brown rice", true, 3.99);
            AddItem("Pasta", "Spaghetti with Marinara Sauce, and a slice of sourdough bread", true, 3.89);
         }
            
        
          public void AddItem(string name, string description, bool vegetarian, double price)
          {
              MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
              if (numberOfItems >= Max_Items)
              {
                  Console.WriteLine("Sorry, menu is full! Can't add item to menu");
              }
              else
              {
                  MenuItems[numberOfItems] = menuItem;
                  numberOfItems++;
              }
          }
       public IIterator CreateIterator()
        {
            return new DinerMenuIterator(MenuItems);
        }
    }
    }
