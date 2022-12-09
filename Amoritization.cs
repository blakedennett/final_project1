class Amoritization {

    static int numPrincipal;
    static double numRate;

    static int numYears;

    public int GetPrincipal() {
        bool done = false;

        while (done != true) {
            Console.Write("What is the principal loan? ");

            string? principal = Console.ReadLine();

            if (!int.TryParse(principal, out int result)) {
                Console.WriteLine("{0} is not an integer, please try again", principal);
            }
            else {
                numPrincipal = Int32.Parse(principal);
                done = true;
            }
        }

        return numPrincipal;
    }

    public double GetInterest() {
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
            Console.Write("How many years is the loan? ");

            string? years = Console.ReadLine();

            if (!int.TryParse(years, out int result)) {
                Console.WriteLine("{0} is not an integer, please try again", years);
            }
            else {
                numYears = Int32.Parse(years);
                done = true;
            }
            

        }

        return numYears * 12;
    }



    public double DoMath(int p, double i, int n) {

        i = i / 12;

        return p * ((i * (Math.Pow(1 + i, n))) / (Math.Pow((1 + i), n) - 1));

    }

}


// P = (i * Principle x (1 + i)^n) / ((1 + i)^n – 1