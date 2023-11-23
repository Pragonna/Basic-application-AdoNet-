
public class Calculator : ICalculator
{
    private ICalculator _calculator;

    private decimal d1, d2;

    public Calculator(decimal d2, decimal d1)
    {
        this.d2 = d2;
        this.d1 = d1;
    }

    // parameter = ICalculator can help to next the SumDigit method function`s result
    // if we use field = ICalculator it will be late one step for sumDigit result;
    public decimal Calculate(ICalculator calculator) => calculator.SumDigit();

    public decimal SumDigit()
    {
        var res = d1 + d2;

        if (_calculator is null)
            _calculator = new Calculator(d2, d1);

        d1 = res;
        d2 = res;

        return res;
    }
}