namespace typesOfConstructor
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Types of Constructors!");
            Console.WriteLine("Default Parameter Less Consturctor \n");

            // 1 Programmer Class : Default System Parameter Less Constructor
            Programmer p1 = new Programmer();

            Console.WriteLine("Programmer Id is:  " + p1.Id);
            Console.WriteLine("Programmer Name is:  " + p1.Name);
            Console.WriteLine("Programmer DeptNo is:  " + p1.DeptNo);
            Console.WriteLine("Programmer Location is:  " + p1.Location);
            Console.WriteLine("Is Programmer Senior:  " + p1.IsSenior);

             // 2. Consultant Class : User - Parameter less Constructor
            Console.WriteLine("\nDefault User - Parameter Less Constructor \n");

            Consultant c1 = new Consultant();
            Console.Write("\nFirst Instance : c1");
            c1.DisplayConsultant();

            Consultant c2 = new Consultant();
            Console.Write("\nSecond Instance : c2");
            c2.DisplayConsultant();

            // 3. Parameterized Constructor

            Frenchies f1 = new Frenchies(8);
            f1.FrenchiesDisplay();            
            
            Frenchies f2 = new Frenchies(18);
            f2.FrenchiesDisplay();

            Console.WriteLine("Two instances separately i.e. instance1 and instance2. So, internally two copies of the num variable are available in the memory for us.\n");

            // 4. Copy Constructor Single Instance

            BranchCopy Branch1 = new BranchCopy(12);
            Branch1.BranchDisplay();

            // 4. Copy Constructor Overloading Branch1 Constructor to initiate duplicate instance.
            BranchCopy Branch2 = new BranchCopy(Branch1);
            Branch2.BranchDisplay();

            Console.WriteLine("Copy Constructor memory is separate for each instance but the value is going to be the same for both instances.\n");

            // 5. Static Constructor
            Console.WriteLine("\nMain Method Exceution Started. Display for Static Const Execution...");
            //5. Static Constructor



            Console.ReadLine();
        }
            static void StaticConstructor()
                {
                    Console.WriteLine("Static Constructor Executed!");
                }
    }

        // 1. Programmer Class : Default System Parameter Less Constructor
        class Programmer
        {
            public int Id, DeptNo;
            public string Name, Location;
            public bool IsSenior;
        }

        // 2. Consultant Class : User - Parameter less Constructor
        class Consultant
        {
            public int BadgeId, Age;
            public string OfficeAdd, CName;
            public bool IsManager;

            //User Defined Default Constructor

            public Consultant()
            {
                BadgeId = 201;
                Age = 55;
                OfficeAdd = "NY-DevDept";
                CName = "Jade";
                IsManager = true;
            }

            public void DisplayConsultant()
            {
                Console.WriteLine("Consultant BadgeId is:  " + BadgeId);
                Console.WriteLine("Consultant Age is:  " + Age);
                Console.WriteLine("Consultant Office Address is:  " + OfficeAdd);
                Console.WriteLine("Consultant Name is:  " + CName);
                Console.WriteLine("Is Consultant a Manager:  " + IsManager);
            }
        }

        // 3. Parameterized Constructor
        public class Frenchies
        {
            int num;
            public Frenchies(int i)
            {
                num = i;
                Console.WriteLine($"\nThe total no. of Frenchies ABC has are: {i}");
            }

            public void FrenchiesDisplay()
            {
                Console.WriteLine($"Value of num = {num}");
            }
    }

        // 4. Copy Constructor
        public class BranchCopy
        {
            int branch;
            // 1st Constructor: BranchCopy Constructor
            public BranchCopy(int branchNo)
            {
                branch = branchNo;
            Console.WriteLine("BranchCopy first Constructor!");
            }            
        
            // 2nd Constructor: Constructor is passed as a Parameter
            public BranchCopy(BranchCopy obj)
            {
                branch = obj.branch;
            Console.WriteLine("\nSecond Constructor : Duplicates elements of first Constructor");
            }


            public void BranchDisplay()
            {
                Console.WriteLine($"Number of Branches are = {branch}");
            }
        }


}


