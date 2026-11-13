namespace CalculatorApp;

public static class OptionsManager
{
    public static readonly string[] OptionsList =
    {
        "a - Add",
        "s - Subtract",
        "m - Multiply",
        "d - Divide",
        "sabs - Subtract absolute value",
        "r - Remainder",
        "p - Power",
        "l - Logarithm (log base b of a)",
        "f - Sum of two factorials",
        "x - Exit"
    };

    public static double Add(double a, double b) => a + b;
    public static double Subtract(double a, double b) => a - b;
    public static double Multiply(double a, double b) => a * b;

    public static double Divide(double a, double b)
    {
        if (b == 0) throw new DivideByZeroException("Деление на нула не е позволено.");
        return a / b;
    }

    public static double SubtractAbs(double a, double b) => Math.Abs(a - b);

    public static double Remainder(double a, double b)
    {
        if (b == 0) throw new DivideByZeroException("Остатъчно деление на нула не е позволено.");
        return a % b;
    }

    public static double Power(double a, double b) => Math.Pow(a, b);

    // В задачата резултатът е логаритъм на a с база b.
    public static double Logarithm(double a, double b)
    {
        if (a <= 0) throw new ArgumentOutOfRangeException(nameof(a), "Аргументът a трябва да е положителен.");
        if (b <= 0 || b == 1)
            throw new ArgumentOutOfRangeException(nameof(b), "Базата b трябва да е положителна и различна от 1.");
        return Math.Log(a, b);
    }

    public static double SumFactorials(double a, double b) =>
        Factorial(a) + Factorial(b);

    private static double Factorial(double value)
    {
        if (value < 0 || value != Math.Truncate(value))
            throw new ArgumentOutOfRangeException(nameof(value), "Факториелът е дефиниран тук за цели неотрицателни числа.");
        if (value > 170)
            throw new ArgumentOutOfRangeException(nameof(value), "Числото е твърде голямо за изчисление с double.");

        double result = 1;
        for (int i = 2; i <= (int)value; i++)
            result *= i;
        return result;
    }
}
