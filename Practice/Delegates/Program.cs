namespace Delegates
{

    
    internal class Program
    {
        static void Main(string[] args)
        {
            Action action = m1;

            m2(action);
        }


        static void m1()
        {
            Console.WriteLine("m1");
        }
        static void m2(Action m1)
        {
            m1();
            Console.WriteLine("m2");
        }

    }
}
