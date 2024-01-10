// See https://aka.ms/new-console-template for more information

using ITEC275_A01;
using System.Data;
using System.Diagnostics;
using System.IO.Pipes;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Channels;

internal class Program
{
    private static void MainMenu()
    {
        Console.WriteLine("Welcome to the Database Assignment 1 CLI.");
        Console.WriteLine();
        Console.WriteLine("Choose from the following options:");
        Console.WriteLine();

        Console.WriteLine("Press 1 to Select Customers by Customer ID.");
        Console.WriteLine("Press 2 to Select Products by Price Range.");
        Console.WriteLine("Press 3 to Select All Orders with some Order Details.");
        Console.WriteLine("Press 4 to Insert an Order by Customer ID for 10 Units of Chai.");
        Console.WriteLine("Press 5 to Update a Products Unit Price by Product ID.");
        Console.WriteLine("Press 6 to Update a Customers Phone Number.");
        Console.WriteLine("Press 7 to Install Stored Procedures.");
        Console.WriteLine("Press Esc to Exit.");
        Console.WriteLine();
    }

    private static void ReadDataTable(DataTable dt)
    {
        foreach (DataRow dr in dt.Rows)
        {
            StringBuilder sb = new StringBuilder();
            foreach (DataColumn dc in dt.Columns)
            {
                sb.Append($"{dr[dc]}, ");
            }
            sb = sb.Remove(sb.Length - 2, 2);
            Console.WriteLine(sb);
        }
    }

    private static void FailedRequest() //Exception message?
    {
        Console.WriteLine();
        Console.WriteLine("An error occurred.");
        Console.WriteLine();
        Console.WriteLine("Press enter to return to menu...");
        Console.ReadLine();
    }

    private static void FailedRequest(string message)
    {
        Console.WriteLine($"An error occurred. {message}");
        Console.WriteLine();
        Console.WriteLine("Press enter to return to menu...");
        Console.ReadLine();
    }

    private static void SuccessfulRequest() 
    {
        Console.WriteLine();
        Console.WriteLine("Request successful.");
        Console.WriteLine();
        Console.WriteLine("Press enter to return to menu...");
        Console.ReadLine();
    }

    private static void MainMenuInput()
    {
        ConsoleKeyInfo input = Console.ReadKey();

        BusinessLayer bl = new BusinessLayer();

        DataTable dt = new DataTable();

        string? customerID = "";

        switch (input.Key)
        {
            case ConsoleKey.D1:
                Console.Clear();
                Console.WriteLine("Insert Customer ID:");
                dt = bl.SelectCustomersByCustomerID(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Returned Data:");
                Console.WriteLine();
                Console.WriteLine(@"Record Format: CustomerID | CompanyName | ContactName | ContactTitle | Address | City | Region | PostCode | Country | Phone | Fax");
                Console.WriteLine();

                ReadDataTable(dt);
                SuccessfulRequest();
                Console.SetCursorPosition(0, 0);

                break;

            case ConsoleKey.D2:
                Console.Clear();
                Console.WriteLine("Insert a Minimum Price:");
                string? minPrice = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Insert a Maximum Price:");
                string? maxPrice = Console.ReadLine();
                Console.Clear();

                if (decimal.TryParse(minPrice, out decimal parsedMinPrice) && decimal.TryParse(maxPrice, out decimal parsedMaxPrice)) 
                {
                    dt = bl.SelectProductsByPriceRange(parsedMinPrice, parsedMaxPrice);
                    Console.WriteLine("Returned Data:");
                    Console.WriteLine();
                    Console.WriteLine(@"Record Format: ProductID | ProductName | SupplierID | CategoryID | QuantityPerUnit | UnitPrice | UnitsOnOrder | ReorderLevel | Discontinued  ");
                    Console.WriteLine();
                    ReadDataTable(dt);
                    SuccessfulRequest();
                    Console.SetCursorPosition(0, 0);
                }
                else
                {
                    FailedRequest("The inputs could not be parsed as decimals.");
                }
                break;

            case ConsoleKey.D3:
                Console.Clear();
                dt = bl.SelectAllOrdersWithOrderDetails();
                Console.WriteLine("Returned Data:");
                Console.WriteLine();
                Console.WriteLine(@"Record Format: OrderID | CustomerID | EmployeeID | Total Sum of Order ");
                Console.WriteLine();

                ReadDataTable(dt);
                SuccessfulRequest();
                Console.SetCursorPosition(0, 0);
                break;

            case ConsoleKey.D4:
                Console.Clear();
                Console.WriteLine("Insert Customer ID:");
                customerID = Console.ReadLine();
                if (bl.InsertOrderByCustomerIDTenUnitsOfChaiAndRandomEmployee(customerID!))
                {
                    Console.WriteLine();
                    Console.WriteLine($"Inserted an order for 10 units of chai for customer: {customerID}");
                    SuccessfulRequest();
                }
                else
                {
                    FailedRequest("The Customer may not exist.");  
                }
                break;

            case ConsoleKey.D5:
                Console.Clear();
                Console.WriteLine("Insert Product ID to Update:");
                string? productID = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Insert updated Unit Price:");
                Console.WriteLine();
                string? updatedUnitPrice = Console.ReadLine();
                Console.Clear();

                if(int.TryParse(productID, out int productIDresult) && decimal.TryParse(updatedUnitPrice, out decimal updatedUnitPriceResult))
                {
                    bl.UpdateProductUnitPriceByProductID(productIDresult, updatedUnitPriceResult);
                    Console.WriteLine($"Product ID: {productIDresult} updated with new Unit Price: {updatedUnitPrice}.");
                    SuccessfulRequest();
                }
                else
                {
                    FailedRequest("Make sure the product exists.");
                }
                break;

            case ConsoleKey.D6:
                Console.Clear();
                Console.WriteLine("Insert Customer ID to Update:");
                customerID = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Insert updated Phone:");
                string? updatedPhone = Console.ReadLine();
                Console.Clear();

                if(bl.UpdateCustomerPhoneByCustomerID(customerID!, updatedPhone!))
                {
                    Console.WriteLine($"Updated {customerID}'s phone record to {updatedPhone}.");
                    SuccessfulRequest();
                }
                else
                {
                    FailedRequest("Ensure the Customer Exists.");
                }
                break;

            case ConsoleKey.D7:
                Console.Clear();
                Console.WriteLine("Would you like to install stored procedures? (Return Y)");
                string? stringInput = Console.ReadLine();
                if (stringInput == "Y" || stringInput == "y")
                {
                    Console.WriteLine("Ensure docker is running and an SQL server named NwindDB is setup on localhost,1434.");
                    Console.WriteLine("Press Enter to Continue...");
                    Console.ReadLine();

                    try
                    {
                        bl = new BusinessLayer();
                        bl.InstallProcedures();
                        Console.Clear();

                        Console.WriteLine("Stored Procedures Install Complete.");
                        SuccessfulRequest();
                    }
                    catch
                    {
                        FailedRequest();
                    }
                }
                break;

            case ConsoleKey.Escape:
                Environment.Exit(0);
                break;

            default:
                Console.Clear();
                break;
        }
    }

    private static void Main(string[] args)
    {
        BusinessLayer bl = new BusinessLayer();
        Console.WriteLine("Attempting to connect to server...");

        if (bl.CheckConnection())
        {
            while (true)
            {
                Console.Clear();
                MainMenu();
                MainMenuInput();
            }
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Cannot connect to database, ensure docker is running and a Northwinds database named NwindDB is setup on localhost,1434.");
            Console.WriteLine();
        }

        
    }
}