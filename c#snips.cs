/*
#####################################################################
# Example Snippets File for C# Essential Training
#####################################################################

Use these snippets of code as you follow along with the associated
videos to complete each one of the course examples. Just copy and paste
the code in the place where the video shows you - save keystrokes!
*/
//------------------------------------------------
//Chapter 3: Program Flow
//------------------------------------------------

//Reading and Writing to Console

            Console.WriteLine("Hello World!");

            Console.WriteLine("What is your name?");
            string str = Console.ReadLine();
            Console.WriteLine("Why, hello there " + str);

            int mySeconds = 60 * 60 * 24 * 365;
            Console.WriteLine("There are {0} seconds in a year", mySeconds);

//Conditional Statements

            int theVal = 50;

            if (theVal == 50) 
            {
                Console.WriteLine("firstVar is 50");
            }
            else if (theVal == 51)
            {
                Console.WriteLine("firstVar is 51");
            }
            else
            {
                Console.WriteLine("firstVar is something else");
            }

//Switch

            int theVal = 50;

            switch (theVal)
            {
                case 50:
                    Console.WriteLine("The value is 50");
                    break;
                case 51:
                    Console.WriteLine("The value is 51");
                    break;
                case 52:
                    Console.WriteLine("The value is 52");
                    break;
                default:
                    Console.WriteLine("The value is something else");
                    break;
            }

//Constants and Enumerations

        enum Temperatures
        {
            FREEZING = 32,
            LUKEWARM = 65,
            ROOMTEMP = 72,
            HOT = 105,
            BOILING = 212
        }

            // constants are values that won't ever change during a program
            const int freezingPointDegF = 32;
            const int boilingPointDegF = 212;

            int myTemp = 65;

            if (myTemp > freezingPointDegF && myTemp < boilingPointDegF)
            {
                Console.WriteLine("At this temperature, water is a liquid");
            }
            else
            {
                Console.WriteLine("Water is not a liquid at this temperature");
            }

            if (myTemp >= (int)Temperatures.FREEZING && myTemp <= (int)Temperatures.BOILING)
            {
                Console.WriteLine("At this temperature, water is a liquid");
            }
            else
            {
                Console.WriteLine("Water is not a liquid at this temperature");
            }

//Loops

            int myVal = 15;

            // basic while loop
            Console.WriteLine("Basic while() loop:");
            while (myVal < 20) {
                Console.WriteLine("myVal is currently {0}", myVal);
                // careful! Always make sure that the loop has some way to exit
                // or you'll end up with an Infinite Loop!
                myVal += 3;
            }
            Console.WriteLine();

            // the do-while loop
            Console.WriteLine("The  do-while() loop:");
            do
            {
                Console.WriteLine("myVal is currently {0}", myVal);
                myVal += 3;
            } while (myVal < 20);
            Console.WriteLine();

            // the for loop
            Console.WriteLine("The for loop:");
            for (int i = 0; i < myVal; i += 5)
            {
                Console.WriteLine("i is currently {0}", i);
            }
            Console.WriteLine();

            // using the continue and break keywords
            Console.WriteLine("Using break and continue :");
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                    continue; // skip the rest of the loop

                if (i == 9)
                    break;

                Console.WriteLine("i is currently {0}", i);
            }

//Functions and Methods

            int result1;

            result1 = formula(14);
            Console.WriteLine("The result is: {0}", result1);

        static int formula(int theVal)
        {
            return (theVal * 2) / 3 + 15;
        }



//------------------------------------------------
//Chapter 4:
//------------------------------------------------
//Numbers

            double twentieth = 0.2f;
            double one = 1.0f;

            Console.WriteLine("{0}", one - twentieth);

            decimal onetwentieth = 0.2m;
            decimal realone = 1.0m;

            Console.WriteLine("{0}", realone - onetwentieth);

//Chars and Strings

            char myChar = 'a';
            string myString = "  This is a message with a \n newline and spaces in it.  ";

            // Do some character tests
            Console.WriteLine("Calling char.IsUpper: {0}", char.IsUpper(myChar));
            Console.WriteLine("Calling char.IsDigit: {0}", char.IsDigit(myChar));
            Console.WriteLine("Calling char.IsLetter: {0}", char.IsLetter(myChar));
            Console.WriteLine("Calling char.IsPunctuation: {0}", char.IsPunctuation(myChar));
            Console.WriteLine("Calling char.IsWhiteSpace: {0}", char.IsWhiteSpace(myChar));
            Console.WriteLine("Calling char.ToUpper: {0}", char.ToUpper(myChar));
            Console.WriteLine("Calling char.ToLower: {0}", char.ToLower(myChar));
            Console.WriteLine();

            // do some string tests
            Console.WriteLine("Calling string.Trim: {0}", myString.Trim());
            Console.WriteLine("Calling string.ToUpper: {0}", myString.ToUpper());
            Console.WriteLine("Calling string.ToLower: {0}", myString.ToLower());
            Console.WriteLine("Calling string.IndexOf: {0}", myString.IndexOf("a"));
            Console.WriteLine("Calling string.LastIndexOf: {0}", myString.LastIndexOf("and"));

//Variable Scope

            for (int i = 0; i < 10; i++)
            {
                int var1 = 20;
                Console.WriteLine("The value of var1 at pass {0} is {1} ", i, var1);
            }

            //Console.WriteLine("{0}", var1);

//Type Conversion

            int i = 10;
            short x = 5;
            float f = 20.0f;

            i = x;

            x = i;

            f = i;

            i = f;

//------------------------------------------------
//Chapter 5:
//------------------------------------------------
//Defining a Class

            MyClass myC = new MyClass();

            Console.WriteLine("Calling myFunction: {0}", myC.myFunction());
            Console.WriteLine("Using a static member: {0}", MyClass.myStaticInt);

    class MyClass
    {
        int myInteger;
        string myMessage;
        public static int myStaticInt = 100;

        public int myFunction()
        {
            return myInteger;
        }

        public MyClass()
        {
            myInteger = 50;
            myMessage = "This is a string";
        }
    }



//Access Modifiers

            Wine w1 = new Wine("Mark Ryan Dissident", 52.00m);
            Wine w2 = new Wine("DeLille Chaleur Estate", 75.00m);

            w1.Description = "Dark and brooding";


        public string Name;
        public decimal Price;
        public string Description;

        private decimal discount;

        public Wine(string wineName, decimal price) {
            Name = wineName;
            Price = price;
            discount = 0.0m;
        }


//Properties

    class Wine
    {
        private string Name;
        private int year;
        private string Apellation;
        private decimal wholesalePrice;
        private const decimal retailMarkup = 1.35m;

        public decimal Price
        {
            get
            {
                return wholesalePrice * retailMarkup;
            }
            set
            {
                wholesalePrice = value;
            }
        }

        public string MenuDescription
        {
            // only a getter for this property, which is generated from private fields
            get { return year.ToString() + " " + Name + ", " + Apellation; }
        }

        public Wine(int y, string sName, string sApp, decimal wp) 
        {
            Name = sName;
            year = y;
            Apellation = sApp;
            wholesalePrice = wp;
        }
    }


            // Create some new Wine objects
            Wine w1 = new Wine(2003, "Chateau Ste. Michelle Merlot", "Seven Hills", 23.50m);
            Wine w2 = new Wine(2005, "Mark Ryan Dissident", "Ciel du Cheval", 40.00m);

            // Write out the property values
            // Note that in these cases we are using the property getters
            Console.WriteLine("Wine 1: {0}, {1}", w1.MenuDescription, w1.Price);
            Console.WriteLine("Wine 2: {0}, {1}", w2.MenuDescription, w2.Price);
            Console.WriteLine();

            // change the wholesale price of one of the wines using the setter
            w2.Price = 45.0m;

            // write out the wine description, note how the retail price automatically changes
            Console.WriteLine("Wine 2: {0}, {1}", w2.MenuDescription, w2.Price);



//Value vs. Reference Types


    public class Point
    {
        public int x;
        public int y;
    }


        static void testFunc1(int arg1)
        {
            arg1 += 10;
            Console.WriteLine("arg1 is {0}", arg1);
        }

        static void testFunc2(Point pt)
        {
            Console.WriteLine("pt.x is {0}", pt.x);
            pt.x += 10;
            Console.WriteLine("pt.x is {0}", pt.x);
        }


            var i = 10;

            testFunc1(i);
            Console.WriteLine("i is {0}", i);
            Console.WriteLine();

            Point p = new Point();
            p.x = 10;
            p.y = 10;
            Console.WriteLine("p.x is {0}", p.x);
            testFunc2(p);
            Console.WriteLine("p.x is {0}", p.x);


//------------------------------------------------
//Chapter 6:
//------------------------------------------------
//Arrays

            int[] manyValues = { 1, 18, 745, 34, 16, 94, 73, 4, 17, 200 };
            Console.WriteLine("The fourth number is {0}", manyValues[3]);

            string[] myStrings = { "Joe", "Marini", "Teaches", "C#" };
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("{0}", myStrings[i]);
            }

            int[] otherValues = manyValues;
            otherValues[3] = 0;
            Console.WriteLine("The fourth number is {0}", manyValues[3]);

            Array.Sort(manyValues);
            Console.WriteLine("The fourth number is {0}", manyValues[3]);



//ArrayLists

            ArrayList myAL = new ArrayList();
            myAL.Add("one");
            myAL.Add(2);
            myAL.Add("three");
            myAL.Add(4);
            myAL.Insert(0, 1.25f);

            foreach (object o in myAL)
            {
                if (o is int)
                    Console.WriteLine("{0}", o);
            }


//Stacks

            Stack myStack = new Stack();

            myStack.Push("item 1");
            myStack.Push("item 2");
            myStack.Push("item 3");
            Console.WriteLine("{0} Items on the stack", myStack.Count);

            // Have a peek at the top item
            Console.WriteLine("{0}", myStack.Peek());

            myStack.Pop(); // pops "item 3" off the top
            // now "item 2" is the top item
            Console.WriteLine("{0}", myStack.Peek());

            myStack.Clear(); // get rid of everything
            Console.WriteLine("{0} Items on the stack", myStack.Count);


//Queues

            Queue myQ = new Queue();

            myQ.Enqueue("item 1");
            myQ.Enqueue("item 2");
            myQ.Enqueue("item 3");
            myQ.Enqueue("item 4");

            Console.WriteLine("There are {0} items in the Queue", myQ.Count);

            while (myQ.Count > 0)
            {
                string str = (string)myQ.Dequeue();
                Console.WriteLine("Dequeueing object {0}", str);
            }


//Dictionaries

            Hashtable myHT = new Hashtable();
            myHT.Add("SFO", "San Francisco Airport");
            myHT.Add("SEA", "Seattle Tacoma Airport");
            myHT["IAD"] = "Washington Dulles Airport";

            Console.WriteLine("Value for key {0} is {1}", "SEA", myHT["SEA"]);

            Console.WriteLine("There are {0} items", myHT.Count);

            //myHT.Remove("SFO");
            if (myHT.ContainsKey("SFO")) {
                Console.WriteLine("Value for key {0} is {1}", "SFO", myHT["SFO"]);
            }





//------------------------------------------------
//Chapter 7:
//------------------------------------------------
//Overloading Methods

    class Wine
    {
        public int Year;
        public string Name;
        public decimal price;

        public Wine(string s)
        {
            Name = s;
        }
        public Wine(string s, int y)
        {
            Name = s;
            Year = y;
        }
        public Wine(string s, decimal p, int y)
        {
            Name = s;
            price = p;
            Year = y;
        }
    }


            Wine w1 = new Wine("Charles Shaw Merlot");
            Wine w2 = new Wine("Mark Ryan Dissident", 2004);
            Wine w3 = new Wine("Dom Perignon", 120.00m, 1994);

            Console.WriteLine("{0}", w1.Name);
            Console.WriteLine("{0} {1}", w2.Year, w2.Name);
            Console.WriteLine("{0} {1} {2}", w3.Year, w3.Name, w3.price);



//Overriding Methods

    class baseClass
    {
        public virtual void doSomething() 
        {
            Console.WriteLine("This is the baseClass saying hi!");
        }
    }

    class subClass : baseClass
    {
        public override void doSomething()
        {
            base.doSomething();
            Console.WriteLine("This is the subClass saying hi!");
        }
    }


            baseClass obj1 = new subClass();

            obj1.doSomething();



//Abstract Classes and Methods

    abstract class myBaseClass
    {
       public abstract int myMethod(int arg1, int arg2);
    }

    class myDerivedClass : myBaseClass
    {
        public override int myMethod(int arg1, int arg2)
        {
            return arg1 + arg2;
        }
    }


//Sealed Classes

    sealed class myExampleClass
    {
        public static string myMethod(int arg1)
        {
            return String.Format("You sent me the number {0}", arg1);
        }
    }

    class mySubClass : myExampleClass
    {
    }



//Defining Structs

    public struct Point
    {
        private int xCoord;
        private int yCoord;

        public Point(int x, int y) 
        {
            xCoord = x;
            yCoord = y;
        }

        public int x
        {
            get { return xCoord; }
            set { xCoord = value; }
        }

        public int y
        {
            get { return xCoord; }
            set { xCoord = value; }
        }
    }


            Point p1 = new Point(100, 100);

            Point p2 = new Point();
            p2.x = 50;
            p2.y = 75;


//Using Interfaces


    interface ITalkative
    {
        void SayHello();
        void SayGoodBye();
    }

    class myExampleClass : ITalkative
    {
        public myExampleClass()
        {
        }

        public void SayHello()
        {
            Console.WriteLine("Saying hello!");
        }

        public void SayGoodBye()
        {
            Console.WriteLine("Saying goodbye!");
        }
    }


            myExampleClass myEC = new myExampleClass();

            myEC.SayHello();
            myEC.SayGoodBye();



//------------------------------------------------
//Chapter 8:
//------------------------------------------------
//Exceptions

            int x = 10;
            int y = 5;
            int result;

            try
            {
                result = x / y;
                Console.WriteLine("The result is: {0}", result);
            }
            catch
            {
                Console.WriteLine("An error occurred! Better check the code!");
            }
            finally
            {
                Console.WriteLine("Just proving that this code always runs.");
            }



//The Exception Object


            int x = 10;
            int y = 0;
            int result;

            try
            {
                result = x / y;
                Console.WriteLine("The result is: {0}", result);
            }
            catch (System.DivideByZeroException e)
            {
                Console.WriteLine("Whoops! You tried to divide by zero!");
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Just proving that this code always runs.");
            }



//Creating Exceptions

    public class NoJoesException : Exception
    {
        public NoJoesException() : base("We don't allow no Joes in here!")
        {
            this.HelpLink = "http://www.joemarini.com/";
        }
    }


        static string GetName()
        {
            string s = Console.ReadLine();
            if (s.Equals("Joe"))
                throw new NoJoesException();

            return s;
        }



            string theName;

            try
            {
                theName = GetName();
                Console.WriteLine("Hello {0}", theName);
            }
            catch (NoJoesException nje)
            {
                Console.WriteLine(nje.Message);
                Console.WriteLine("For help, visit: {0}", nje.HelpLink);
            }
            finally
            {
                Console.WriteLine("Have a nice day!");
            }



//Re-throwing Exceptions


        static void DoSomeMath()
        {
            int x = 10, y = 0;
            int result;

            try
            {
                result = x / y;
                Console.WriteLine("Result is {0}", result);
            }
            catch
            {
                Console.WriteLine("Error in DoSomeMath()");
                throw new ArithmeticException();
            }
        }


            try
            {
                DoSomeMath();
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine("Hmm, there was an error in there, be careful!");
            }



//------------------------------------------------
//Chapter 9:
//------------------------------------------------
//Existing Files

            bool fileExists = false;
            string thePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string theFile = thePath + @"\testfile.txt";

            fileExists = File.Exists(theFile);

            if (fileExists)
            {
                Console.WriteLine("The file exists");
            }
            else
            {
                Console.WriteLine("The file does not exist, creating it");
                File.Create(theFile);
            }

            if (fileExists)
            {
                Console.WriteLine("It was created on {0}", File.GetCreationTime(theFile));
                Console.WriteLine("It was last accessed on {0}", File.GetLastAccessTime(theFile));

                Console.WriteLine("Moving the file...");
                File.Move(theFile, thePath + @"\newfile.txt");
            }

//Existing Directories

            string thePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // Check to see if a directory exists
            bool dirExists = Directory.Exists(thePath);
            if (dirExists)
                Console.WriteLine("The directory exists.");
            else
                Console.WriteLine("The directory does not exist.");
            Console.WriteLine();

            // Write out the names of the files in the directory
            string[] files = Directory.GetFiles(thePath);
            foreach (string s in files)
            {
                Console.WriteLine("Found file: " + s);
            }
            Console.WriteLine();

            // Get information about each fixed disk drive
            Console.WriteLine("Drive Information:");
            foreach (DriveInfo d in DriveInfo.GetDrives())
            {
                if (d.DriveType == DriveType.Fixed)
                {
                    Console.WriteLine("Drive Name: {0}", d.Name);
                    Console.WriteLine("Free Space: {0}", d.TotalFreeSpace);
                    Console.WriteLine("Drive Type: {0}", d.DriveType);
                    Console.WriteLine();
                }
            }

//Path Operations

            // get the path to the documents folder from the Environment class
            string thePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            thePath += @"\testfile.txt";

            // Exercise the Path class methods
            Console.WriteLine("The directory name is {0}", Path.GetDirectoryName(thePath));
            Console.WriteLine("The file name is {0}", Path.GetFileName(thePath));
            Console.WriteLine("File name without extension is {0}", Path.GetFileNameWithoutExtension(thePath));
            Console.WriteLine("Random file name for path is {0}", Path.GetRandomFileName());


//Reading and Writing Files

            // create a path to the My Documents folder and the file name
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + 
                                Path.DirectorySeparatorChar + "examplefile.txt";

            // if the file doesn't exist, create it by using WriteAllText
            if (!File.Exists(filePath))
            {
                string content = "This is a text file." + Environment.NewLine;
                Console.WriteLine("Creating the file...");
                File.WriteAllText(filePath, content);
            }

            // Use the AppendAllText method to add text to the content
            string addedText = "Text added to the file" + Environment.NewLine;
            Console.WriteLine("Adding content to the file...");
            File.AppendAllText(filePath, addedText);
            Console.WriteLine();

            // Read the contents of the file
            Console.WriteLine("The current contents of the file are:");
            Console.WriteLine("-------------------------------------");

            // Read the contents of the file using ReadAllText
            string currentContent = File.ReadAllText(filePath);
            Console.Write(currentContent);
            Console.WriteLine();

            // Read the contents of the file using ReadAllLines
            /*
            string[] contents = File.ReadAllLines(filePath);
            foreach (string s in contents)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
            */


//------------------------------------------------
//Chapter 10:
//------------------------------------------------
//Variable Parameter Lists

            int result;

            result = addNumbers(4, 6, 8);
            Console.WriteLine("result is {0}", result);

            result = addNumbers(12, 20, 31, 5, 7, 9);
            Console.WriteLine("result is {0}", result);


        static int addNumbers(params int[] nums)
        {
            int total = 0;

            foreach (int x in nums)
            {
                total += x;
            }

            return total;
        }


//Function Parameter Modifiers


        static void SquareAndRoot(double num, out double sq, out double sqrt)
        {
            sq = num * num;
            sqrt = Math.Sqrt(num);
        }


            double n = 9.0;
            double theSquare, theRoot;

            SquareAndRoot(n, out theSquare, out theRoot);
            Console.WriteLine("The square of {0} is {1} and its square root is {2}", n, theSquare, theRoot);
            


//Named and Optional Parameters

            // call the Named parameters example
            myNamedParamExample(stateName: "Washington", zipCode: 98121, cityName: "Seattle");
            myNamedParamExample(cityName: "San Francisco", zipCode: 94109, stateName: "California");
            myNamedParamExample(zipCode: 94109, cityName: "New York", stateName: "New York");

            // call the Optional parameters example
            myOptionalParamFunc(15);
            myOptionalParamFunc(10, 2.71828d);
            myOptionalParamFunc(10, 2.71828d, "a different string");
            // myOptionalParamFunc(10, "a different string");

            // Now do both
            myOptionalParamFunc(10, param3: "named and optional in same call!");

        static void myOptionalParamFunc(int param1, double param2 = 3.14159d, string param3 = "placeholder string")
        {
            Console.WriteLine("Called with: \n\tparam1 {0}, \n\tparam2 {1}, \n\tparam3 {2}",param1, param2, param3);
        }

        static void myNamedParamExample(string cityName, string stateName, int zipCode)
        {
            Console.WriteLine("Arguments passed: \n\tcityName is {0}, \n\tstateName is {1}, \n\tzipCode is {2}",
                        cityName, stateName, zipCode);
        }


//The C# Preprocessor


#define DEBUGCODE
#define JOE


        #region This is the main function
        #endregion

#if DEBUGCODE
            Console.WriteLine("This is only in debug code");
#else
            Console.WriteLine("This only gets written out in non-debug code");
#endif

#if JOE
            Console.WriteLine("Joe was here!");
#endif


//Delegates


    public delegate int NumberFunction (int x);


            NumberFunction f = Square;
            Console.WriteLine("result of the delegate is {0}", f(5));

            // now change the delgate
            f = Cube;
            Console.WriteLine("result of the delegate is {0}", f(5));



        static int Square(int num)
        {
            return num * num;
        }

        static int Cube(int num)
        {
            return num * num * num;
        }


//Using Events

    public delegate void myEventHandler(string newValue);

    class EventExample
    {
        private string theValue;
        public event myEventHandler valueChanged;

        public string Val
        {
            set {
                this.theValue = value;
                this.valueChanged(theValue); 
            }
        }
    }


            EventExample myEvt = new EventExample();

            myEvt.valueChanged += new myEventHandler(myEvt_valueChanged);

            string str;
            do 
            {
                str = Console.ReadLine();
                if (!str.Equals("exit"))
                    myEvt.Val = str;

            } while (!str.Equals("exit"));


        static void myEvt_valueChanged(string newValue)
        {
            Console.WriteLine("The value changed to {0}", newValue);
        }

//------------------------------------------------
//Chapter 11:
//------------------------------------------------
//Garbage Collection

            Console.WriteLine("Allocated memory is: {0}", GC.GetTotalMemory(false));
			Console.WriteLine();
            Console.ReadLine();

            byte[] myArray = new byte[100000];

            Console.WriteLine("Allocated memory is: {0}", GC.GetTotalMemory(false));
			Console.WriteLine();
            Console.ReadLine();

            GC.Collect();

            Console.WriteLine("Allocated memory is: {0}", GC.GetTotalMemory(false));
			Console.WriteLine();
            Console.ReadLine();

