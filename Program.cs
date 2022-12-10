Invest invest = new Invest();
Bank bank = new Bank();
Amoritization amoritization = new Amoritization();




Console.WriteLine("Welcome to the Financial Calculator!");

int type = 0;

type = GetType();



if (type == 1) {
    int initial = invest.GetInitial();
    double rate = invest.GetRate();
    int years = invest.GetYears();
    int monthlyPayment = invest.GetMonthlyPayment();
    try
    {
        double total = invest.ComputeTotal(initial, rate, years, monthlyPayment);
        if (total < 0) {
            total = 0;
        }
        Console.WriteLine($"The amount is {total}");
    }
    catch (DivideByZeroException e)
    {
        Console.WriteLine (e.Message);
    }

    Console.WriteLine("Thank you for using the Investing Calculator! Goodbye");
}


if (type == 2) {
    double balance = bank.GetBal();
    double transaction = bank.GetTransaction();
    bool isDeposit = bank.IsDeposit();
    double newBalance = bank.DoMath(balance, transaction, isDeposit);
    Console.WriteLine($"The amount is {newBalance}");
    Console.WriteLine("Thank you for using the Banking Calculator! Goodbye");
}

if (type == 3) {
    int principal = amoritization.GetPrincipal();
    double interest = amoritization.GetInterest();
    int numPayments = amoritization.GetYears();
    try
    {
        double monthlyPayment = amoritization.DoMath(principal, interest, numPayments);
        if (monthlyPayment < 0) {
            monthlyPayment = 0;
        }
        Console.WriteLine($"The amount is {monthlyPayment}");
    }
    catch (DivideByZeroException e)
    {
        Console.WriteLine (e.Message);
    }
    
    Console.WriteLine("Thank you for using the Amoritization Calculator! Goodbye");
}



int GetType() {
    bool done = false;

    while (done != true) {

        Console.Write("Do you need the investing, banking, or amoritization calculator? ");

        string? calcType = Console.ReadLine().ToLower();

        List<string> possibleCalcTypes = new List<string>();

        possibleCalcTypes.Add("invest");
        possibleCalcTypes.Add("investing");
        possibleCalcTypes.Add("i");
        possibleCalcTypes.Add("bank");
        possibleCalcTypes.Add("banking");
        possibleCalcTypes.Add("b");
        possibleCalcTypes.Add("a");
        possibleCalcTypes.Add("amoritization");

        if (possibleCalcTypes.Contains(calcType)) {
            done = true;

            if (calcType == "invest" || calcType == "i" || calcType == "investing") {
                type = 1;
            }
            else if (calcType == "bank" || calcType == "b" || calcType == "banking") {
                type = 2;
            }
            else {
                type = 3;
            }
        }
        else {
            Console.WriteLine("Sorry! Invalid input, please check your spelling!");
        }
    }

    return type;
}


