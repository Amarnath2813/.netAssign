namespace CA_Day3_ex2
{
    internal class Program
    {
        int? a = null;
        string s = null;
       public void dojob()
        {
            Console.WriteLine("Doing job");
        }
        
        static void Main(string[] args)
        {
            string s1 = null;
            s1 ??= "Hello";
            Console.WriteLine("First letter is"+s1?[0]);
            int ? a = null;
            int x = a ?? 55;
            Console.WriteLine(x);
            Console.WriteLine("Hello, World!");
            Program p =null;
            p?.dojob();
        }
    }
}