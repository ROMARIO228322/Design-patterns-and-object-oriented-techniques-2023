using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.InterfaceIterator
{
    public interface IIterator
    {
        // this method returns whether or not there is next element to iterate over in MENULIST.
        Boolean HasNext();
        //returns the next element of the MENULIST.
        Object Next();
    }
}
