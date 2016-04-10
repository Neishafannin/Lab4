namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.Write("When are attending the show (Matinee or Evening) : ");           // Writing a command to the screen for user
            string timeAttending = System.Console.ReadLine();  // Reading whatever the user inputs to the console and storing what was input
            timeAttending = timeAttending.ToLower();  //converting all characters the user inputs to lower case                          

            if (timeAttending != "matinee")
            {
                if (timeAttending != "evening")    //this "if" statement ensures that the user exits the program if Matinee or Evening is not entered.
                {
                    System.Console.WriteLine("You did not enter (Matinee or Evening)");
               

                    System.Console.WriteLine();
                    System.Console.Write("Press any key to exit... ");
                    System.Console.ReadKey();

                    return;      // this return statement means program will end here.  (see why above)
                }
            }
            

            System.Console.Write(" # of Adults attending : ");
            int numAdults = int.Parse(System.Console.ReadLine());


            System.Console.Write(" # of children attending : ");
            int numChildren = int.Parse(System.Console.ReadLine());

            System.Console.Write(" # of Seniors attending : ");
            int numSeniors = int.Parse(System.Console.ReadLine());

            System.Console.Write(" How many small sodas? : ");
            int numSmallSodas = int.Parse(System.Console.ReadLine());

            System.Console.Write(" How many large sodas? : ");
            int numLargeSodas = int.Parse(System.Console.ReadLine());

            System.Console.Write(" How many Hot Dogs? : ");
            int numHotDogs = int.Parse(System.Console.ReadLine());

            System.Console.Write(" How many orders of Popcorn? : ");
            int numPopcorn = int.Parse(System.Console.ReadLine());

            System.Console.Write(" How many order of candy? : ");
            int numCandy = int.Parse(System.Console.ReadLine());

            decimal totalCost = 0;   //"decimal" us used to keep track of the cost of the bill


            if (timeAttending == "matinee")
            {
                totalCost += 3.99m * numChildren;
                totalCost += 5.99m * numAdults;
                totalCost += 4.50m * numSeniors;

            }
            else // if the user does not choose matinee evening is used as the else statement
            {
                totalCost += 6.99m * numChildren;
                totalCost += 10.99m * numAdults;
                totalCost += 8.50m * numSeniors;

            }

            totalCost += 3.50m * numSmallSodas;        // these lines of code are adding items to the bill for the final cost.
            totalCost += 5.99m * numLargeSodas;
            totalCost += 3.99m * numHotDogs;
            totalCost += 4.50m * numPopcorn;
            totalCost += 1.99m * numCandy;



            // Here is where we apply discounts...

            // Discount 1
            int numTickets = numChildren + numAdults + numSeniors;
            int numOfDiscounts = Math.Min(numPopcorn, numLargeSodas);  // gives the minimum value of these paremeters
            int actualNumOfDiscounts = Math.Min(numOfDiscounts, numTickets);
            if (actualNumOfDiscounts > 0)
            {
                totalCost -= 2.00m * actualNumOfDiscounts;
                System.Console.WriteLine("Because you purchased " + numPopcorn + " popcorns and " + numLargeSodas + " large sodas you receive " + actualNumOfDiscounts + " x $2.00 discounts");
            }
            

            // Discount 2
            if (timeAttending == "evening")
            {
                if (numTickets > 2)
                {
                    if (numPopcorn > 0)
                    {
                        System.Console.WriteLine("Because you purchased at least 3 evening ticket one of your popcorns is free");
                        totalCost -= 4.50m;
                    }
                }
            }

            // Discount 3
            int numFreeCandies = numCandy / 3;
            if (numFreeCandies > 0)
            {
                System.Console.WriteLine("You get " + numFreeCandies + " additional free candies!");
            }








            System.Console.WriteLine("Your Total Cost: $ " + totalCost );
            System.Console.Write("Press any key to exit... ");
            System.Console.ReadKey();

        }
    }
}
