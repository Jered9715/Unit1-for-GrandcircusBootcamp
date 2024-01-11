//Deliverable 1 for C# BootCamp

internal class Program
{
    public static void Main(string[] args)
    {
        //Declaring variables for Restock Program
        //Initial variable values established as base line inventory
        int sodaStock = 100;
        int restockSoda = 40;

        int chipsStock = 40;
        int restockChips = 20;

        int candyStock = 60;
        int restockCandy = 40;

        //Intro string for restock program
        Console.WriteLine("Welcome to the restocking tool!");
        Console.WriteLine();

        //Gathering input for Soda Stock adjustment
        Console.WriteLine("How many Sodas have been sold today? " + sodaStock + " are in stock.");
        Console.Write(">");
        sodaStock = int.Parse(Console.ReadLine());


        //If statement used to determine acceptable user input for Soda
        if (sodaStock <= 100)
        {
            sodaStock = 100 - sodaStock;
            Console.WriteLine("There are " + sodaStock + " Sodas left");
        }
        else
        {
            Console.WriteLine("That value is too high. Stock not adjusted");
        }

        Console.WriteLine();


        //Gathering input for Chips stock adjustment
        Console.WriteLine("How many Chips have been sold today? " + chipsStock + " are in stock.");
        Console.Write(">");
        chipsStock = int.Parse(Console.ReadLine());


        //If statement used to determine acceptable user input for Chips
        if (chipsStock <= 40)
        {
            chipsStock = 40 - chipsStock;
            Console.WriteLine("There are " + chipsStock + " Chips left");
        }
        else
        {
            Console.WriteLine("That value is too high. Stock not adjusted");
        }
        Console.WriteLine();

        //Gathering input for Candy Stock
        Console.WriteLine("How many Candy have been sold today? " + candyStock + " are in stock.");
        Console.Write(">");
        candyStock = int.Parse(Console.ReadLine());


        //If statement used to determine acceptable user input for Candy
        if (candyStock <= 60)
        {
            candyStock = 60 - candyStock;
            Console.WriteLine("There are " + candyStock + " Candy left");
        }
        else
        {
            Console.WriteLine("That value is too high. Stock not adjusted");
        }

        Console.WriteLine();
        Console.WriteLine();


        //list of items that have exceeded the minimum value for restock
        Console.WriteLine("Thank you for filling out the values. Here's what needs to be restocked.");


        //if statement for Soda restock message
        if (sodaStock <= restockSoda)
            Console.WriteLine("Soda needs to be restocked");

        //if statement for Chips restock message
        if (chipsStock <= restockChips)
            Console.WriteLine("Chips needs to be restocked");

        //if statement for Candy restock message
        if (candyStock <= restockCandy)
            Console.WriteLine("Candy needs to be restocked");

        Console.WriteLine();


        //ending statement
        Console.WriteLine("Goodbye!");
    }
}