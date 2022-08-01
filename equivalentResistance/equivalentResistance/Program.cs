namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            double r1, r2, r3, rt;
            int position;

            Console.WriteLine("Enter the value of R1 resistance: ");
            r1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value of R2 resistance: ");
            r2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value of R3 resistance: ");
            r3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("**************************************************************");
            Console.WriteLine("1. Series resistance");
            Console.WriteLine("2. Parallel resistance");
            Console.Write("Please choose the position of resistances...");

            position = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("**************************************************************");
            if (position == 1)
            {
                rt = r1 + r2 + r3;
            }
            else if (position == 2)
            {
                rt = 1 / ((1 / r1) + (1 / r2) + (1 / r3));
            }
            else
            {
                rt = -1;
                Console.WriteLine("You chose a wrong transaction...");
            }
            Console.WriteLine("Equivalent resistance: " + rt + " Ohm");
            Console.ReadLine();
        }

    }

}