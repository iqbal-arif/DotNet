namespace typesOfConstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Types of Constructors!");
            Console.WriteLine("Default Parameter Less Consturctor");

            Programmer p1 = new Programmer();
            Console.WriteLine("Programmer Id is:  " + p1.Id);
            Console.WriteLine("Programmer Name is:  " + p1.Name);
            Console.WriteLine("Programmer DeptNo is:  " + p1.DeptNo);
            Console.WriteLine("Programmer Location is:  " + p1.Location);
            Console.WriteLine("Is Programmer Senior:  " + p1.IsSenior);
            Console.ReadKey();

        }
    }
        class Programmer
        {
            public int Id, DeptNo;
            public string Name, Location;
            public bool IsSenior;
        }
}
