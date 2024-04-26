using System.ComponentModel.Design;
using static System.Console;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("**************************");
            WriteLine("* Yeeun Shin / n11470062 *");
            WriteLine("**************************");

            int in_murals;
            int ex_murals;
            const int MIN = 0, MAX = 30;
            Write("Enter the number of interior murals (between 0 and 30): ");
            in_murals = Convert.ToInt32(ReadLine());
            Write("Enter the number of exterior murals (between 0 and 30): ");
            ex_murals = Convert.ToInt32(ReadLine());

            if (in_murals >= MIN && in_murals <= MAX)
                WriteLine("Number of interior mural orders: {0}", in_murals);
                if (ex_murals >= MIN && ex_murals <= MAX)
                       WriteLine("Number of exterior mural orders: {0}", ex_murals);
                else
                       WriteLine("Please re-enter the number");


            double totalRevenue;
            const double INTERIOR_EACH = 500.00;
            const double EXTERIOR_EACH = 750.00;
            double intCost;
            double extCost;
            intCost = in_murals * INTERIOR_EACH;
            extCost = ex_murals * EXTERIOR_EACH;
            WriteLine("Expected revenue from interior murals: {0}", intCost.ToString("C"));
            WriteLine("Expected revenue from exterior murals: {0}", extCost.ToString("C"));
            totalRevenue = intCost + extCost;
            WriteLine("Total expected revenue: {0}", totalRevenue.ToString("C"));

            if (ex_murals == in_murals)
                WriteLine("Both types are equally preferred!");
            else
            {
                if (ex_murals > in_murals)
                    WriteLine("Exterior murals are becoming more attractive!");
                else
                    WriteLine("Interior murals are becoming popular!");
            }

            int x;
            int customerNum = 0;
            int MAXnum = in_murals;
            int count;
            string customerInput = Convert.ToString(in_murals);
            string[] zips = { "L", "S", "A", "O" };
            int[] muralNum = new int[zips.Length];
            int Index = Array.IndexOf(zips, customerInput);

            while (customerNum < in_murals)
            {

                
                Write("Answer the custumer name : ", customerNum);
                customerInput = Convert.ToString(ReadLine());
                customerNum++;
                WriteLine("Mural options are: ");
                WriteLine("     L for Lanscape");
                WriteLine("     S for Seascape");
                WriteLine("     A for Abstract");
                WriteLine("     O for Others");


                string entrycode;
                while (customerNum <= in_murals)
                {
                    Write("Enter the mural code {L, S, A, O}: ");
                    entrycode = ReadLine();

                    bool zipFound = false;
                    for (x = 0; x < zips.Length; ++x)
                    {
                        if (entrycode == zips[x])
                        {
                            zipFound = true;
                            muralNum[x]++;
                            break;
                        }

                    }

                    if (zipFound)
                    {
                        break;
                    }

                    else
                    {
                        Write("Please re-enter the valid mural code: ");
                        entrycode = ReadLine();
                    }

                }

            }

            WriteLine("\nHere is number of customers ordering each type of interior mural:");
            for (int i = 0; i < zips.Length; i++)
            {
                WriteLine($"Number of customers ordering {zips[i]} murals: {muralNum[i]}");
                
            }

            string codes;
            string STOPvalue = "stop";
            Write("Enter a mural code (or '999' to finish program): ");
            string inputString = ReadLine();
            codes = Convert.ToString(inputString);

            while (codes != STOPvalue)
            {

                bool zipFound = false;
                for (int i = 0; i < zips.Length; i++)
                {
                    if (inputString == zips[i])
                    {
                        zipFound = true;
                        Console.WriteLine($"{customerInput[i]} ordering mural code {inputString[i]}");
                        ReadLine();
                    }
                    else
                    {
                        WriteLine("it is invalid mural code. Please enter a valid code.");
                    }

                    WriteLine("Exiting the program.");
                    break;

                }

  


                }



            

        }
                
}
}