namespace Csharp_Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Patient patient = new Patient("","", 0, 0);
            Console.WriteLine("Input your First Name");
            patient.FirstName = Console.ReadLine();
            Console.WriteLine("Input your Last Name");
            patient.LastName = Console.ReadLine();
            Console.WriteLine("Input your Weight");
            patient.Weight = int.Parse(Console.ReadLine());
            Console.WriteLine("Input your Height");
            patient.Height = int.Parse(Console.ReadLine());
            Console.WriteLine("Input your systolic");
            int systolic2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input your diastolic");
            int diastolic2 = int.Parse(Console.ReadLine());
            patient.PatInfo(systolic2, diastolic2);



        }//main
    }//class
}//nawspace
