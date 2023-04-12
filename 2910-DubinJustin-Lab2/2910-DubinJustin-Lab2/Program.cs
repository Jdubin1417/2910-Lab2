using System.Reflection.Metadata.Ecma335;
using System.Transactions;
using ConsoleTables;
class Calculators
{
    static void Main(string[] args)
    {
        //PART1-------------------------------------------------------
        Console.Write("Please enter a number to be added: ");
        int integer1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Please enter another number to be added: ");
        int integer2 = Convert.ToInt32(Console.ReadLine());
        int total = 0;
        total = integer1 + integer2;
        Console.WriteLine(integer1 + " + " + integer2 + " = " + total);
        //--------------------------------------------------------------
        Console.Write("Enter a number to see multiplication table: ");
        int integer3 = Convert.ToInt32(Console.ReadLine());
        Console.Write("What number would you like the multiplication table to stop at?");
        int stop = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < stop + 1;)
        {
            int Product = integer3 * i;
            Console.WriteLine(integer3 + " * " + i + " = " + Product);
            i++;
        }
    //--------------------------------------------------------------
    var table = new ConsoleTable("Type", "Byte's of memory", "Min", "Max");
        table.AddRow("sbyte", "1", sbyte.MinValue, sbyte.MaxValue);
        table.AddRow("byte", "1", byte.MinValue, byte.MaxValue);
        table.AddRow("short", "2", short.MinValue, short.MaxValue);
        table.AddRow("ushort", "2", ushort.MinValue, ushort.MaxValue);
        table.AddRow("int", "4", int.MinValue, int.MaxValue);
        table.AddRow("uint", "4", uint.MinValue, uint.MaxValue);
        table.AddRow("long", "8", long.MinValue, long.MaxValue);
        table.AddRow("ulong", "8", ulong.MinValue, ulong.MaxValue);
        table.AddRow("float", "4", float.MinValue, float.MaxValue);
        table.AddRow("double", "8", double.MinValue, double.MaxValue);
        table.AddRow("decimal", "16", decimal.MinValue, decimal.MaxValue);
        table.Write();
    //--------------------------------------------------------------
    STARTOVER:
        Console.Write("Enter a number to be calculated: ");
        int number1 = Convert.ToInt32(Console.ReadLine());
    BACK:
        Console.WriteLine("Enter a function (EX: + | - | * | / | % ");
        string function = Console.ReadLine();
        Console.Write("Enter another number to be calculated: ");
        int number2 = Convert.ToInt32(Console.ReadLine());
        if (function == "+")
        {
            int total2 = 0;
            total2 = number1 + number2;
            Console.WriteLine(number1 + " + " + number2 + " = " + total2);
        }
        else if (function == "-")
        {
            int total2 = 0;
            total2 = number1 - number2;
            Console.WriteLine(number1 + " - " + number2 + " = " + total2);
        }
        else if (function == "*")
        {
            int total2 = 0;
            total2 = number1 * number2;
            Console.WriteLine(number1 + " * " + number2 + " = " + total2);
        }
        else if (function == "/")
        {
            int total2 = 0;
            total2 = number1 / number2;
            Console.WriteLine(number1 + " / " + number2 + " = " + total2);
        }
        else if (function == "%")
        {
            int total2 = 0;
            total2 = number1 % number2;
            Console.WriteLine(number1 + " % " + number2 + " = " + total2);
        }
        else
        {
            Console.WriteLine("nope go back and try again...");
            goto BACK;
        }
    BACK2:
        Console.WriteLine("Would you like to continue? (Y/N)");
        string Input2 = Console.ReadLine();
        if (Input2 == "Y") 
        {
            goto STARTOVER;
        }
    else if (Input2 == "N")
        {
            Console.WriteLine("Press Any Key to Close Program:");
            Console.ReadLine();
        }
    else
        {
            Console.WriteLine("Invalid Option, try again!");
            goto BACK2;
        }
    }
}
