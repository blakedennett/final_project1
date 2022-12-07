class Bank {

    public double DoMath(double balance, double transaction, bool isDeposit) {

        if (isDeposit == true) {
            return balance += transaction;
        }
        else {
            return balance -= transaction;
        }

    }


}