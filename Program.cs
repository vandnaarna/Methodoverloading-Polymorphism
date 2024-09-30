using System.Runtime.InteropServices;

namespace Methodoverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Product obj = new Product();
            obj.multiply(12,20);
            obj.multiply(10,30,40);
        }
        public class Product
        {
            public void multiply(int a, int b)
            {


                Console.WriteLine("Multiplication of a and b is:");
                Console.WriteLine("Multiplication of a and b is:");
                Console.WriteLine("Multiplication of a and b is:");
                Console.WriteLine("Multiplication of a and b is:");
                Console.WriteLine("Multiplication of a and b is:");
                Console.WriteLine(a * b);
            }
            public void multiply(int x, int y ,int z)
            {
                Console.WriteLine("multiplication of x ,y and z is:");
                Console.WriteLine(x * y *z);

            }
        }
    }
}
