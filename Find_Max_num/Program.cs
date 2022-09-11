namespace Find_Max_num
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 10; int b = 50; int c = 30;

            
            Console.WriteLine("Max number is "+ Max_number<int>.printMaximumNumbers(a,b,c));


            Console.WriteLine("_________________________________________________________");

            float x = 10.2F; float y = 50.2F; float z = 30.3F;


            Console.WriteLine("Max number is " + Max_number<float>.printMaximumNumbers(x, y, z));
        }
    }
}   