using CSVExampleProblem;
using System;
namespace CSV_HelperDemo
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("\t\t\t\t\tREADING THE DATA FROM CSV FILE\t\t\t\t\t\n");
            PersonDataManagements data = new PersonDataManagements();
            data.ImplementationCsv();
            data.ImplementationJson();
        }
    }
}
