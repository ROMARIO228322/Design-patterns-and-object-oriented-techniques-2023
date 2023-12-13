using IteratorAndCompositeExercise.InterfaceIterator;
using IteratorAndCompositeExercise.Menus;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IteratorAndCompositeExercise.Menus.ModelforMenus;
using static IteratorAndCompositeExercise.Program;

namespace IteratorAndCompositeExercise
{
    public class Waitress
    {
        PancakeHouseMenu pancakeHouseMenu;
        DinerMenu dinerMenu;

        public Waitress(PancakeHouseMenu pancakeHouseMenu,DinerMenu dinerMenu)
        {
            this.pancakeHouseMenu = pancakeHouseMenu;
            this.dinerMenu = dinerMenu;
        }
        public void PrintMenu()
        {
            //Creating two iterators for each menus.
            IIterator pancakeIterator = pancakeHouseMenu.CreateIterator();
            IIterator dinerIterator = dinerMenu.CreateIterator();
            Console.WriteLine("MENU\n---\nBREAKFAST");
            // calls the overloaded printmenu with each iterator.
            PrintMenu(pancakeIterator);
            Console.WriteLine("\nLUNCH");
            PrintMenu(dinerIterator);  
        }
        public void PrintMenu(IIterator iterator)
        {
            while (iterator.HasNext())
                //Testing if there are any more items existing.
            {
                MenuItem menuItem = (MenuItem)iterator.Next();
                Console.Write(menuItem.GetName() + ", ");
                Console.Write(menuItem.GetPrice() + " -- ");
                Console.WriteLine(menuItem.GetDescription());
            }
        }

    }
}
