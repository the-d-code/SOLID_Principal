using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principal
{
    /*
    This principle is the first principle that applies to Interfaces instead of classes in SOLID and it is similar 
    to the single responsibility principle.
        It states that “do not force any client to implement an interface which is irrelevant to them“. 
        Here your main goal is to focus on avoiding fat interface and give preference to many small client-specific interfaces.
        You should prefer many client interfaces rather than one general interface and each interface should have a specific responsibility.
    */

    public interface IPrinterTask
    {
        void Print(String PrintContent);
        void Scan(String ScanContent);
    
    }
    public interface IFaxTask
    {
        void Fax(String FaxContent);
    }
    public interface IDuplexTask
    {
        void Duplex(string DuplexContent);
    }


    public class HPLesser : IPrinterTask, IFaxTask,IDuplexTask
    {

        public void Print(string PrintContent)
        {
            Console.WriteLine("Print Done");
        }

        public void Scan(String ScanContent)
        {
            Console.WriteLine("Scan Done");
        }

        public void Fax(string FaxContent)
        {
            Console.WriteLine("Fax Done");
        }

        public void Duplex(String DuplexContent)
        {
            Console.WriteLine("Duplex Done");
        }
    }

    class LiquidInkjetPrinter : IPrinterTask
    {
        public void Print(string PrintContent)
        {
            Console.WriteLine("Print Done");
        }
        public void Scan(string ScanContent)
        {
            Console.WriteLine("Scan content");
        }
    }


}
