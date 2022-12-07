class Amoritization {




    public double DoMath(int p, double i, int n) {

        return p * ((i * (Math.Pow(1 + i, n))) / (Math.Pow((1 + i), n) + 1));

    }

}