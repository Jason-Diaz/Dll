//******************************************************
// File: MainApp.cs
//
// Purpose: This class presents a menu
//          to the user and then perform an
//          action depending on what the user
//          chooses to do. It contains one instance
//          of CountryAppUnitTesting in main. When
//          the program runs it displays the menu
//          to the user and gives them a chance to
//          input a choice. Depending on what choice
//          the user makes an action is performed.
//          The menu action manipulate and use the
//          appropriate class instance declared at
//          the top of main.
//
// Written By: Jason Diaz 
//
// Compiler: Visual Studio 2017
//
//******************************************************

using System;
using CountryDataLibrary;

namespace jasonDiaz_Assign1
{
    class Program
    {
        static void Main(string[] args)
        {
            CountryAppUnitTesting c =  new CountryAppUnitTesting();
            string userInput; // Menu user input
            int intVal; // Converted user input

            do
            {
                // Main Menu
                Console.WriteLine("Country Testing Menu");
                Console.WriteLine("--------------------");
                Console.WriteLine("1 - Unit Test Currency \n2 - Unit Test Language \n3 - Exit");
                Console.Write("Enter Choice: ");
                userInput = Console.ReadLine();
                // Converts to integer type
                intVal = Convert.ToInt32(userInput);

                #region Unit testing calls switch statment
                switch (intVal)
                {
                    case 1: c.UnitTestCurrency(); 
                            break;
                    case 2: c.UnitTestLanguage();
                            break;
                    case 3: break;

                    default:
                            Console.WriteLine("\nPlease enter valid input!\n");
                            break;
                }
                #endregion
            } while (intVal != 3);
        }
    }
}
