using ClassLib;
namespace _402._Remove_K_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            string test = "1432219";
            int k = 3;
            string result = solution.RemoveKdigits(test, k);
            Console.WriteLine(result);
        }
    }
}
