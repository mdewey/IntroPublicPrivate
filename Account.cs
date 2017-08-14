namespace IntroPublicPrivate
{
    // Class to model a bank account
    public class Account
    {
        public int Total { get; set; }
        public string Owner { get; set; }
        public int AccountNumber { get; set; }
        public int RoutingNumber { get; set; }

        public void IncreaseBalance(int amount)
        {
            if (amount < 500)
            {
                 this.Total += amount;
            }
        }

        public void DecreaseBalance(int amount)
        {
            this.Total -= amount;
        }

        public string GetFullAcountNumber()
        {
            // full acount number is AccountNumber + - + RoutingNumerb
            return this.getRountingAndAccountNumberAsString();
        }

        private string getRountingAndAccountNumberAsString()
        {
            return $"{AccountNumber}-{RoutingNumber}";
        } 

    }
}