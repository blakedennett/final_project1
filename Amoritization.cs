class Amoritization {




    public double DoMath(int p, double i, int n) {

        i = i / 12;

        return p * ((i * (Math.Pow(1 + i, n))) / (Math.Pow((1 + i), n) - 1));

    }

}


// P = (i * Principle x (1 + i)^n) / ((1 + i)^n – 1