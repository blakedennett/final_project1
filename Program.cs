Invest invest = new Invest();
Bank bank = new Bank();
Amoritization amoritization = new Amoritization();




Console.WriteLine("Welcome to the Financial Calculator!");

int type = 0;


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


if (type == 1) {
    int initial = invest.GetInitial();
    double rate = invest.GetRate();
    int years = invest.GetYears();
    int monthlyPayment = invest.GetMonthlyPayment();
    double total = invest.ComputeTotal(initial, rate, years, monthlyPayment);
    Console.WriteLine($"The amount is {total}");
    Console.WriteLine("Thank you for using the Investing Calculator! Goodbye");
}


if (type == 2) {
    double balance = bank.GetBal();
    double transaction = bank.GetTransaction();
}


// Console.WriteLine(amoritization.DoMath(250000, .06, 15 * 12));




