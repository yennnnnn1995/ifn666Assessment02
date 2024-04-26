using static System.Console;
using System;


namespace Assessment_YeeunShin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double FeesPerHour, DurationOfTheJob;
            double TotalFees;

            //first method
            DisplayInstructions();

            //second method
            GetFeesAndDuration(out FeesPerHour, out DurationOfTheJob);

            if (FeesPerHour > 0 && DurationOfTheJob > 0) {
                WriteLine("Accept!");
            }

            else
            {
                WriteLine("Please re-enter the fees and duration.");
            };

            //third method
            TotalFees = TotalFee(FeesPerHour, DurationOfTheJob);
            WriteLine("Total fee is {0}", TotalFees.ToString("C"));

            //last method
            Finalmessage(FeesPerHour, DurationOfTheJob, TotalFees);

        }

        public static void DisplayInstructions()
        {
            WriteLine("This program will determine how much fees to cost.");
            WriteLine();
            WriteLine("You will be asked to enter the pacing fees per hour");
            WriteLine("and the duration of the job.");
            WriteLine("Then, you can get the total cost.");
            WriteLine();
        }

        public static void GetFeesAndDuration(out double fees, out double duration)
        {

            Write("Enter the paving fees per hour: ");
            fees = Convert.ToDouble(ReadLine());
            Write("Enter the duration of the job: ");
            duration = Convert.ToDouble(ReadLine());

        }

        public static double TotalFee(double totalfees, double totalduration)
        {
            WriteLine("The paving fees per hour is {0} ", totalfees.ToString("C"));
            WriteLine("The dutaion of the job is {0} hours ", totalduration);
            return (totalfees * totalduration);
        }

        public static void Finalmessage(double totalfees, double totalduration, double totalcost)
        {
            WriteLine("Therefore, for this program, the fees per hour is {0}, duration of the job is {1} hours, and total fee is {2}", totalfees.ToString("C"), totalduration, totalcost.ToString("C"));
        }
    }
}