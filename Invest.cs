
class Invest {


    static double yearlyInvestment;

    static int numInitial;
    static double numRate;

    static int numYears;
    static int numMonthlyPayment;
    

    public double ComputeTotal(int initial, double rate, int years, int paymentAmount) {

       yearlyInvestment += initial; 

        int numOfPayments = years * 12;

        double monthlyRate = rate / 12;

        while (numOfPayments > 0) {

            yearlyInvestment += (yearlyInvestment * monthlyRate) + paymentAmount;

            numOfPayments--;
        }

        return yearlyInvestment;

    }

    public int GetInitial() {

        bool done = false;

        while (done != true) {
            Console.Write("What is the initial payment? ");

            string? initial = Console.ReadLine();

            if (!int.TryParse(initial, out int result)) {
                Console.WriteLine("{0} is not an integer, please try again", initial);
            }
            else {
                numInitial = Int32.Parse(initial);
                done = true;
            }
            

        }

        return numInitial;
    }



    public double GetRate() {

        bool done = false;

        while (done != true) {
            Console.Write("What is the expected interest rate? ");

            string? rate = Console.ReadLine();

            if (!double.TryParse(rate, out double result)) {
                Console.WriteLine("{0} is not valid, please try again.", rate);
            }
            else {
                numRate = Double.Parse(rate);
                done = true;
            }
        }

        return numRate / 100;
    }


    public int GetYears() {

        bool done = false;

        while (done != true) {
            Console.Write("How many years do you plan to invest? ");

            string? years = Console.ReadLine();

            if (!int.TryParse(years, out int result)) {
                Console.WriteLine("{0} is not an integer, please try again", years);
            }
            else {
                numYears = Int32.Parse(years);
                done = true;
            }
            

        }

        return numYears;
    }


    public int GetMonthlyPayment() {

        bool done = false;

        while (done != true) {
            Console.Write("What Monthly Payment would you like to contribute? ");

            string? monthlyPayment = Console.ReadLine();

            if (!int.TryParse(monthlyPayment, out int result)) {
                Console.WriteLine("{0} is not an integer, please try again", monthlyPayment);
            }
            else {
                numMonthlyPayment = Int32.Parse(monthlyPayment);
                done = true;
            }
            

        }

        return numMonthlyPayment;
    }




    public int ComputeContribution(int initial, int years, int paymentAmount) {

        return initial + ((years * 12) * paymentAmount); 

    }

    public double ComputeInterest(double total, int contribution) {

        return total - contribution; 

    }

}
