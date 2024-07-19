namespace BasicApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int i = 1;
            //Int32 j = 100;
            //float pi = 3.14f;
            //Single t = 4.45f;
            //char c = 'A';
            //double d = 23.12;
            //Double d2 = 412.322;
            //string s = "Akarsh";
            //String st = "Akarsh.String";
            //DateTime datet = DateTime.Now;

            //Console.WriteLine(i);
            ////Console.WriteLine(j);
            //Console.WriteLine(s);
            //Console.WriteLine(datet);
            ////Console.WriteLine(d);
            ////Console.WriteLine(d2);
            ////Console.WriteLine(t);
            ////Console.WriteLine(c);
            ////Console.WriteLine(pi);
            ////Console.WriteLine(st);
            //Console.Read();

            NewMethod();

        }

        private static void NewMethod()
        {
            Console.Write("Input the first number:");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the second number:");
            int second = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"First number = {first} and Second Number = {second}");
            NewMethod1(first, second);

            static void NewMethod1(int first, int second)
            {
                if (second == 0)
                {
                    Console.WriteLine("Second number can't be zero");

                }
                else
                {
                    Console.WriteLine(first - second);
                }
            }
        }
    }
}