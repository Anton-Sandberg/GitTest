namespace GitTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            AnnelieTest test = new AnnelieTest();
            test.TestMethod();

            HenkesCoolClass coolClass = new HenkesCoolClass();
            coolClass.CoolMethod();

        }
    }
}
