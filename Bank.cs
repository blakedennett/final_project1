class Bank {



    static double numBal; 
    static double numTransaction;


    public double GetBal() {
        bool done = false;

        while (done != true) {
            Console.Write("What is the current balance? ");

            string? bal = Console.ReadLine();

            if (!double.TryParse(bal, out double result)) {
                Console.WriteLine("{0} is not valid, please try again.", bal);
            }
            else {
                numBal = Double.Parse(bal);
                done = true;
            }
        }

        return numBal;
    }


    public double GetTransaction() {
        bool done = false;

        while (done != true) {
            Console.Write("What is the transaction amount? ");

            string? transaction = Console.ReadLine();

            if (!double.TryParse(transaction, out double result)) {
                Console.WriteLine("{0} is not valid, please try again.", transaction);
            }
            else {
                numTransaction = Double.Parse(transaction);
                done = true;
            }
        }

        return numTransaction;
    }



    public double DoMath(double balance, double transaction, bool isDeposit) {

        if (isDeposit == true) {
            return balance += transaction;
        }
        else {
            return balance -= transaction;
        }

    }


}


