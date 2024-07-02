using System;

class Program {
  public static void Main (string[] args) {

  // User Prompt
    Console.WriteLine("Welcome to Holiday Homes, enter a salesperson initial (D, E, F) or enter \"Z\" to quit: \n");

  // Variables
    double salesDanielle = 0;
    double salesEdward = 0;
    double salesFrancis = 0;
    char initial;

  while (true)
    {
    
  // Get User's Initial & Make Sure it Reads Both Lowercase and Uppercase
      
    initial = Char.ToUpper(Console.ReadKey().KeyChar);
    Console.WriteLine("\n ");

  // If User Enters Z, Quit Program

    if (initial == 'Z')
    {
    break;
    }

  // If User Enters Correct Letter, Ask For Sales Amount

    if (initial == 'D' || initial == 'E' || initial == 'F')
    {

  // Prompt the Sale Amount
    Console.WriteLine("Enter Sales Amount: \n");
    double salesAmount = Convert.ToDouble(Console.ReadLine());

  // Add Sales Amount to the Correct Salesperson's Total
    switch (initial)
    {
    case 'D':
    salesDanielle += salesAmount;
    break;
        
    case 'E':
    salesEdward += salesAmount;
    break;
   
    case 'F':
    salesFrancis += salesAmount;
    break;   
    }
      
    }

    // If User Enters Incorrect Letter, Display Error Message

    else
    {
     Console.WriteLine("Error, invalid salesperson selected, please try again");
    }

    // Calculate the Total Sales 
    double grandTotal = salesDanielle + salesEdward + salesFrancis;

    // Determine the Salesperson with the Highest Sales
    string topSalesperson = "Danielle (D)";
    double topSales = salesDanielle;

    if (salesEdward > salesDanielle)
    {
    topSalesperson = "Edward (E)";
    topSales = salesEdward;
    }

    if (salesFrancis > salesDanielle)
    {
    topSalesperson = "Francis (F)";
    topSales = salesFrancis;
    }

    // Display the Total Sales for Each Salesperson

      Console.WriteLine("\nSales Summary:");
      Console.WriteLine($"\nGrand Total: ${grandTotal}");
      Console.WriteLine($"Highest Sale: {topSalesperson}");
      Console.WriteLine("");

      }
  }
}