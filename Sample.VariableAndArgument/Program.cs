using System;
using System.Linq;
using System.Activities;
using System.Activities.Statements;
using Common.Utility;

namespace Sample.VariableAndArgument
{

    class Program
    {
        static void Main(string[] args)
        {
            double CandidateHeight = 0.00;

            ConsoleHelper.WriteLineInColor(ConsoleColor.Cyan, "Sample of InvokeComplete method of WorkflowInvoker.");

            ConsoleHelper.WriteLineInColor(ConsoleColor.White, "Please enter your height:");
            string height = Console.ReadLine();
            if (double.TryParse(height, out CandidateHeight))
            {

                Activity workflow1 = new Workflow1()
                {
                    argHeight = CandidateHeight
                };

                WorkflowInvoker.Invoke(workflow1);



            }
            else
            {
                ConsoleHelper.WriteLineInColor(ConsoleColor.Cyan, "Please enter correct height nexttime.");
            }
            Console.Read();
        }
       
    }

    public class Helper
    {
        public static Person AskProfile()
        {
            int age = 0;

            Person person = new Person();
            ConsoleHelper.WriteLineInColor(ConsoleColor.Gray, "Please Enter your name:");
            person.Name = Console.ReadLine();

            ConsoleHelper.WriteLineInColor(ConsoleColor.Gray, "Please Enter your Age:");
            string strAge = Console.ReadLine();
            int.TryParse(strAge, out age);
            person.Age = age;

            ConsoleHelper.WriteLineInColor(ConsoleColor.Gray, "Please Enter your country:");
            person.Country = Console.ReadLine();

            return person;
        }
    }
}
