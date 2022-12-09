class Bank {



    static double numBal; 
    static double numTransaction;

    static bool isDeposit;


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

    public bool IsDeposit() {

        bool done = false;

        List<string> possibleValues = new List<string>();

        possibleValues.Add("w");
        possibleValues.Add("withdrawal");
        possibleValues.Add("d");
        possibleValues.Add("deposit");

        while (done != true) {

            Console.Write("Is this a deposit or a withdrawal? ");

            string? input = Console.ReadLine().ToLower(); 

            if (possibleValues.Contains(input)) {
                done = true;
                if (input == "w" || input == "withdrawal") {
                    isDeposit = false;
                }
                else {
                    isDeposit = true;
                }
            }
            else {
                Console.WriteLine("Not a valid response, please try again");
            }

        }

        return isDeposit;
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


