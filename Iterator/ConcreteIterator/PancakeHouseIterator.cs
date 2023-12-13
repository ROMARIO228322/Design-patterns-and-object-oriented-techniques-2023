using Iterator.InterfaceIterator;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Iterator.Menus.ModelforMenus;

namespace Iterator.ConcreteIterator
{
    public class PancakeHouseIterator : IIterator
    {
        ArrayList MenuItems;
        int position = 0;
        public PancakeHouseIterator(ArrayList menuItems)
        {
            this.MenuItems = menuItems;
        }
        public bool HasNext()
        {
            // checks if position has reached to end for arraylist.
            // However, diner has allocated a max sized array also checks if we are in end of array and next one is null, 
            //which means no more items.
            
            if (position >= MenuItems.Count || MenuItems[position] == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public object Next()
        {
            //Typecasting to MENUitems and returns next items in the array and increase each time the position.
            MenuItem menuItem = (MenuItem)MenuItems[position];
            position++;
            return menuItem;
        }
    }
}
