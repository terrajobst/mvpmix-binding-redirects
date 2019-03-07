using Fabrikam.Logging;

namespace Demo3
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new { First = "Immo", Last = "Landwerth" };
            MyLogger.Instance.WriteLine(customer);
        }
    }
}
