using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principal
{
    /*
    The principle was introduced by Barbara Liskov in 1987 and according to this principle 
    “Derived or child classes must be substitutable for their base or parent classes“.
    This principle ensures that any class that is the child of a parent class should 
    be usable in place of its parent without any unexpected behavior.
    You can understand it in a way that a farmer’s son should inherit farming skills 
    from his father and should be able to replace his father if needed.If the son wants to become a farmer then he 
    can replace his father but if he wants to become a cricketer then definitely 
    the son can’t replace his father even though they both belong to the same family hierarchy.

    */


    public interface IFruit
    {
        string GetColor();
    }
    public class Apple : IFruit
    {
        public string GetColor()
        {
            return "Red";
        }
    }
    public class Orange : IFruit
    {
        public string GetColor()
        {
            return "Orange";
        }
    }



    public interface FullName
    {
        string GetName();
    }

    public class Surname : FullName
    {
        public string GetName()
        {
            return "Akbari";
        }
    }
    public class Name : FullName
    {
        public string GetName()
        {
            return "Devanshi";
        }
    }

}
