namespace Task3;

public class Calculator
{
    public int FirstNumber { get; set; }
    public int SecondNumber { get; set; }
    public Calculator(int firt,int second)
    {
        FirstNumber=firt;
        SecondNumber=second;
    }
    public int Sum()
    {
        return FirstNumber + SecondNumber;
    }
    public int Subtract()
    {
        return FirstNumber - SecondNumber;
    }
    public int Multiplication()
    {
        return FirstNumber * SecondNumber;
    }
    public int Division()
    {
        return FirstNumber / SecondNumber;
    }
}
