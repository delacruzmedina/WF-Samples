using System;
using System.Linq;
using System.Activities;
using System.Activities.Statements;

namespace BugFlow.Sample
{

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bug Status are given below: ");
            Console.WriteLine("1. OPEN");
            Console.WriteLine("2. ASSIGNED");
            Console.WriteLine("3. CHANGED");
            Console.WriteLine("4. RESOLVED");
            Console.WriteLine("5. CLOSED");

            Activity workflow1 = new Workflow1();
            WorkflowInvoker.Invoke(workflow1);

            Console.ReadLine();
        }
    }
}
