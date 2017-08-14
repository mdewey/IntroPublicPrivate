using System;

namespace IntroPublicPrivate
{
    class Program
    {
        static void Main(string[] args)
        {
            var myAccount = new Account();

            myAccount.IncreaseBalance(1000);

            myAccount.GetFullAcountNumber();

            Console.WriteLine("Hello World!");
        }
    }
}
