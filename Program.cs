Invest invest = new Invest();
Amoritization amoritization = new Amoritization();






int initial = 100;

double rate = .12;

int years = 30;

int monthlyPayment = 100;

Console.WriteLine(invest.ComputeTotal(initial, rate, years, monthlyPayment));
// Console.WriteLine(invest.ComputeContribution(initial, years, monthlyPayment));


Console.WriteLine(amoritization.DoMath(300000, .02, 30 * 12));
