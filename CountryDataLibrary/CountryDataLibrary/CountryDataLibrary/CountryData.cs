//******************************************************
// File: CountryData.cs
//
// Purpose: DLL solution which contains the Currency
//          and Language class definitions inside of
//          it. This DLL contains all the classes used
//          for the country data application.
//
// Written By: Jason Diaz 
//
// Compiler: Visual Studio 2017
//
//******************************************************

using System;

namespace CountryDataLibrary
{
    public class Currency
    {
        #region Currency private member variables
        private string code;
        private string name;
        private string symbol;
        #endregion

        #region Currency methods
        //****************************************************
        // Method: Currency
        //
        // Purpose: Default constructor for currency. 
        //          Sets all variables to default.
        //****************************************************
        public Currency()
        {
            code = null;
            name = null;
            symbol = null;
        }

        #region Currency properties
        public string Code
        {
            get
            {
                return code;
            }
            set
            {
                code = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Symbol
        {
            get
            {
                return symbol;
            }
            set
            {
                symbol = value;
            }
        }
        #endregion

        //****************************************************
        // Method: ToString
        //
        // Purpose: Displays the contents of the class variables
        //****************************************************
        public string ToString()
        {
            return "Code:" + code + " Name:" + name + " Symbol:" + symbol;
        }
        #endregion
    }

    public class Language
    {
        #region Language private member variables
        private string name;
        private string nativeName;
        private string iso639_1;
        private string iso639_2;
        #endregion

        #region Language methods
        //****************************************************
        // Method: Language
        //
        // Purpose: Default constructor for Language. 
        //          Sets all variables to default.
        //****************************************************
        public Language()
        {
            name = null;
            nativeName = null;
            iso639_1 = null;
            iso639_2 = null;
        }

        #region Language properties
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string NativeName
        {
            get
            {
                return nativeName;
            }
            set
            {
                nativeName = value;
            }
        }

        public string Iso639_1
        {
            get
            {
                return iso639_1;
            }
            set
            {
                iso639_1 = value;
            }
        }

        public string Iso639_2
        {
            get
            {
                return iso639_2;
            }
            set
            {
                iso639_2 = value;
            }
        }
        #endregion

        //****************************************************
        // Method: ToString
        //
        // Purpose: Displays the contents of the class variables
        //****************************************************
        public string ToString()
        {
            return "name:" + name + " nativeName:" + nativeName + " iso639_1:" + iso639_1 + " iso639_2:" + iso639_2;
        }
        #endregion
    }

    public class CountryAppUnitTesting
    {
        #region CountryAppUnitTesting Methods
        public void UnitTestCurrency()
        {
            Currency c = new Currency();
            string testString = "Code1 Name Symbol!";
            string display = "***********************";

            // Test valid code
            c.Code = testString;
            // Test valid name
            c.Name = testString;
            // Test valid symbol
            c.Symbol = testString;

            Console.WriteLine("\n" + display + "\nUnit Testing: Currency\n" + display);

            if (c.Code.Equals(testString))
            {
                Console.WriteLine("Currency Code Property: Pass");
            }
            else
            {
                Console.WriteLine("Currency Code Property: FAIL!");
            }

            if (c.Name.Equals(testString))
            {
                Console.WriteLine("Currency Name Property: Pass");
            }
            else
            {
                Console.WriteLine("Currency Name Property: FAIL!");
            }

            if (c.Symbol.Equals(testString))
            {
                Console.WriteLine("Currency Symbol Property: Pass");
            }
            else
            {
                Console.WriteLine("Currency Symbol Property: FAIL!");
            }
            Console.WriteLine();
        }

        public void UnitTestLanguage()
        {
            string testString = "FName LName 123";
            Language l = new Language();
            string display = "***********************";

            // Test valid name
            l.Name = testString;
            // Test valid nativeName
            l.NativeName = testString;
            // Test valid Iso639_1
            l.Iso639_1 = testString;
            // Test valid Iso639_2
            l.Iso639_2 = testString;

            Console.WriteLine("\n" + display + "\nUnit Testing: Language\n" + display);

            if (l.Name.Equals(testString))
            {
                Console.WriteLine("Language Name Property: Pass");
            }
            else
            {
                Console.WriteLine("Language Name Property: FAIL!");
            }

            if (l.NativeName.Equals(testString))
            {
                Console.WriteLine("Language NativeName Property: Pass");
            }
            else
            {
                Console.WriteLine("Language NativeName Property: FAIL!");
            }

            if (l.Iso639_1.Equals(testString))
            {
                Console.WriteLine("Language ISO639_1 Property: Pass");
            }
            else
            {
                Console.WriteLine("Language ISO639_1 Property: FAIL!");
            }

            if (l.Iso639_2.Equals(testString))
            {
                Console.WriteLine("Language ISO639_2 Property: Pass");
            }
            else
            {
                Console.WriteLine("Language ISO639_2 Property: FAIL!");
            }
            Console.WriteLine();
        }
        #endregion
    }
}
