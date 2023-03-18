using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principal
{
    /*
     This principle states that “a class should have only one reason to change” 
    which means every class should have a single responsibility or single job or single purpose. 
    Take the example of developing software. 
    The task is divided into different members doing different things as front-end designers do design, 
    the tester does testing and backend developer 
    takes care of backend development part then we can say that everyone has a single job or responsibility. 
    */


    public class EmployeeService
    {
        Logger objLogger = new Logger();
        public void AddEmployee(string name)
        {
            Console.WriteLine("Employee Added:" + name);
            if(name!= "Devanshi")
            {
                objLogger.Logs(name);

            }
        }
    }
    public class Logger
    {
        public void Logs(string name)
        {
            File.WriteAllText(@"I:\VS\IRIS\SOLID_Principal\Logs\SRP.txt", "Wrong Name : " +name + " , Correct name is : Devanshi");
        }
    }
  
}
