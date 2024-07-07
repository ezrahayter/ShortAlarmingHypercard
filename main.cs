using System;

class Program
{
    static void Main(string[] args)
    {
        double danielleTotal = 0;
        double edwardTotal = 0;
        double francisTotal = 0;
        double grandTotal = 0;
        bool danielleEntered = false;
        bool edwardEntered = false;
        bool francisEntered = false;
        char salespersonInitial;
        while (true)
        {

            Console.WriteLine("Enter salesperson initial (D, E, F, or Z to quit): ");
            salespersonInitial = Console.ReadKey().KeyChar;
            Console.WriteLine(); 
            if (salespersonInitial == 'Z' || salespersonInitial == 'z')
            {
                break;
            }
            
            salespersonInitial = char.ToUpper(salespersonInitial);

            switch (salespersonInitial)
            {
                
                case 'D':
                    Console.WriteLine("Enter sale amount: ");
                    double saleAmount = Convert.ToDouble(Console.ReadLine());
                    danielleTotal += saleAmount;
                    danielleEntered = true; 
                    grandTotal += saleAmount;
                    break;
                
                case 'E':
                    Console.WriteLine("Enter sale amount: ");
                    saleAmount = Convert.ToDouble(Console.ReadLine());
                    edwardTotal += saleAmount;
                    edwardEntered = true; 
                    grandTotal += saleAmount;
                    break;
                
                case 'F':
                    Console.WriteLine("Enter sale amount: ");
                    saleAmount = Convert.ToDouble(Console.ReadLine());
                    francisTotal += saleAmount;
                    francisEntered = true;
                    grandTotal += saleAmount;
                    break;
                default:
                    Console.WriteLine("Invalid salesperson initial. Please try again.");
                    break;
            }
        }
        Console.WriteLine("\nGrand Total: $" + grandTotal.ToString("0.00"));
        double highestTotal = Math.Max(danielleTotal, Math.Max(edwardTotal, francisTotal));
        if (highestTotal == danielleTotal && danielleEntered)
        {
            Console.WriteLine("\nHigest Sale: D");
        }
        else if (highestTotal == edwardTotal && edwardEntered)
        {
            Console.WriteLine("\nHighest Sale: E");
        }
        else if (highestTotal == francisTotal && francisEntered)
        {
            Console.WriteLine("\nHighest Sale: F");
        }
        else 
        {
            Console.WriteLine("No sales were entered");
        }
    }
}