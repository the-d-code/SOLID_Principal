using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principal
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("--------------------1.Single Responsiblity Principal---------------");

            EmployeeService employee = new EmployeeService();
            employee.AddEmployee("Devanshi");
            employee.AddEmployee("Deva");


            Console.WriteLine("                                               ");
            Console.WriteLine("--------------------2.Open/Closed Principal---------------");

            Console.WriteLine("Sale Amount = 100000");

            Customer preimium = new Preimium();
            double PreimiumAmount = preimium.GetDiscount(100000);
            Console.WriteLine($"Preimium Discount : {PreimiumAmount}");

            Customer gold = new Gold();
            double GoldAmount = gold.GetDiscount(100000);
            Console.WriteLine($"Gold Discount : {GoldAmount}");

            Customer silver = new Silver();
            double SilverAmount = silver.GetDiscount(100000);
            Console.WriteLine($"Silver Discount : {SilverAmount}");

            Customer enquiry = new Enquiry();
            double EnquiryAmount = enquiry.GetDiscount(100000);
            Console.WriteLine($"Enquiry Discount : {EnquiryAmount}");
            Console.WriteLine("                                               ");

            Console.WriteLine("-------------------- 3.Liskov’s Substitution Principle---------------");
            IFruit fruit = new Orange();
            Console.WriteLine($"Color of Orange: {fruit.GetColor()}");
            fruit = new Apple();
            Console.WriteLine($"Color of Apple: {fruit.GetColor()}");
            Console.WriteLine("---------------------------");
            Console.WriteLine("2.FULL NAME");
            FullName fullName = new Surname();
            Console.WriteLine($"Surname : {fullName.GetName()}");
            fullName = new Name();
            Console.WriteLine($"Name : {fullName.GetName()}");

            Console.WriteLine("                                               ");
            Console.WriteLine("--------------------4.Interface Segregation Principle---------------");
            //Using HPLaserJetPrinter we can access all Printer Services
            Console.WriteLine("                                               ");

            Console.WriteLine("1.HPLaserJetPrinter Checking");
            HPLesser hPLaserJetPrinter = new HPLesser();
            hPLaserJetPrinter.Print("Printing");
            hPLaserJetPrinter.Scan("Scanning");
            hPLaserJetPrinter.Fax("Faxing");
            hPLaserJetPrinter.Duplex("PrintDuplex");
            Console.WriteLine("                                               ");

            Console.WriteLine("2.liquidInkjetPrinter Checking                                        ");
            //Using LiquidInkjetPrinter we can only Access Print and Scan Printer Services
            LiquidInkjetPrinter liquidInkjetPrinter = new LiquidInkjetPrinter();
            liquidInkjetPrinter.Print("Printing");
            liquidInkjetPrinter.Scan("Scanning");

            Console.WriteLine("                                               ");

            Console.WriteLine("-------------------- 5.Dependency Inversion Principle---------------");
            Console.WriteLine("                                               ");

        }
    }
}
