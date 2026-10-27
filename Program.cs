using Stoelendans;

namespace MyFirstClass2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stoel rodestoel = new Stoel("rood", 60);
            Console.WriteLine(rodestoel.echoKleur());
            Console.WriteLine("Zithoogte rode stoel: " + rodestoel.getZithoogte());

            rodestoel.verstellen(70);
            Console.WriteLine("Zithoogte na verstelling: " + rodestoel.getZithoogte());

        }
    }
}