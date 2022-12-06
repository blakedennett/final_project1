
class Invest {


    static double yearlyInvestment;
    

    public double ComputeTotal(int initial, double rate, int years, int paymentAmount) {

        yearlyInvestment += initial; 

        int numOfPayments = years * 12;

        double monthlyRate = rate / 12;

        while (numOfPayments > 1) {

            yearlyInvestment += (yearlyInvestment * monthlyRate) + paymentAmount;

            numOfPayments--;
        }

        return yearlyInvestment;

    }

    public int ComputeContribution(int initial, int years, int paymentAmount) {

        return initial + ((years * 12) * paymentAmount); 

    }

    public double ComputeInterest(double total, int contribution) {

        return total - contribution; 

    }

}
