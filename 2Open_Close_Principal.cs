using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principal
{

    /*
    This principle states that “software entities (classes, modules, functions, etc.) 
    should be open for extension, but closed for modification” 
    which means you should be able to extend a class behavior, without modifying it.
    */

    public class Customer
    {
        public int id { get; set; }
        public double sale { get; set; }
        public virtual double GetDiscount(double sale)
        {
            return sale;
            ////gold discount
            //if (id == 1)
            //{
            //    Console.WriteLine(sale * 20 %);
            //}
            ////sivler user
            //else
            //{
            //    Console.WriteLine(sale * 15 %);
            //}
        }

    }

    public class Preimium : Customer
    {
        public override double GetDiscount(double sale)
        {
            return base.GetDiscount((sale) * 30 / 100);
        }
    }
    public class Gold : Customer
    {
        public override double GetDiscount(double sale)
        {
            return base.GetDiscount((sale)*20/100);
        }
    }

    public class Silver:Customer
    {
        public override double GetDiscount(double sale)
        {
            return base.GetDiscount((sale) * 15 / 100);
        }
    }
    public class Enquiry : Customer
    {
        public override double GetDiscount(double sale)
        {
            return base.GetDiscount((sale) * 5/100);
        }
    }

}
