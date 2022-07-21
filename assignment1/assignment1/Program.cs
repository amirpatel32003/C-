using System;

class Rational
{
    public int Denominator { get; private set; }
    public int Numerator { get; private set; }

    public Rational(int numerator = 0,
             int denominator = 1)
    {
        Denominator = denominator;
        Numerator = numerator;
    }

    public override string ToString()
    {
        return Numerator.ToString() + "/" + Denominator.ToString();
    }

    public void IncreaseBy(Rational other)
    {
        if (Denominator == other.Denominator)
        {
            Numerator += other.Numerator;
        }
        else
        {
            int lcm = 1;
            int oldDenominator = Denominator;
            int oldOtherDenominator = other.Denominator;
            int newNominator, newOtherNumerator;
            int max = (Denominator > other.Denominator) ? Denominator : other.Denominator;
            for (int i = max; ; i += max)
            {
                if (i % Denominator == 0 && i % other.Denominator == 0)
                {
                    lcm = i;
                    break;
                }
            }

            Denominator = lcm;
            newNominator = ((Denominator / oldDenominator) * Numerator);
            newOtherNumerator = ((Denominator / oldOtherDenominator) * other.Numerator);
            Numerator = newNominator + newOtherNumerator;
        }
    }

    public void DecreaseBy(Rational other)
    {
        if (Denominator == other.Denominator)
        {
            Numerator += other.Numerator;
        }
        else
        {
            int lcm = 1;
            int oldDenominator = Denominator;
            int oldOtherDenominator = other.Denominator;
            int newNominator, newOtherNumerator;
            int max = (Denominator > other.Denominator) ? Denominator : other.Denominator;
            for (int i = max; ; i += max)
            {
                if (i % Denominator == 0 && i % other.Denominator == 0)
                {
                    lcm = i;
                    break;
                }
            }

            Denominator = lcm;
            newNominator = ((Denominator / oldDenominator) * Numerator);
            newOtherNumerator = ((Denominator / oldOtherDenominator) * other.Numerator);
            Numerator = newNominator - newOtherNumerator;
        }
    }


}

class Testing
{
    static void Main()
    {
        Console.WriteLine("Rational Numbers: ");
        Rational r1 = new Rational();
        Console.WriteLine("1. Using Default Constructor Values: " + r1.ToString());

        Rational r2 = new Rational(4);
        Console.WriteLine("2. Setting the First Argument (Numerator) with a Different Value: " + r2.ToString());

        Rational r3 = new Rational(2, 6);
        Console.WriteLine("3. Setting up both class arguments with other values: " + r3.ToString());

        Rational r4 = new Rational(r2.Numerator, r3.Denominator);
        Console.WriteLine("4. Where Numerator value is from the 2nd's and Denominator is from the 3rd's : " + r4.ToString());

        Console.WriteLine("\nLet's Increase 2nd Rational Number By the 3rd Rational Number: ");
        Console.WriteLine(r2.ToString() + " + " + r3.ToString());
        r2.IncreaseBy(r3);
        Console.WriteLine("Sum: " + r2.ToString());

        Console.WriteLine("\nLet's Decrease 3rd Rational Number By the 4th Rational Number: ");
        Console.WriteLine(r3.ToString() + " - " + r4.ToString());
        r3.DecreaseBy(r4);
        Console.WriteLine("Sum: " + r3.ToString());


    }
}

