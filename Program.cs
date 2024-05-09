using System.Globalization;

namespace Assignment_1._3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] newArray = { 2, 5, 7 };
            int length = newArray.Length;
            int temp = 0;


            for (int i = 0; i < length / 2; i++)
            {
                temp = newArray[i];
                newArray[i] = newArray[length - i - 1];
                newArray[length - i - 1] = temp;

            }

            foreach (int i in newArray)
            {
                Console.WriteLine(i);
            }
        }
    }
}
