namespace Src.Classes;

public class Calc 
{
    private List<string> _history;
    public Calc ()
    {
        _history = new List<string>();
    }
    public int Sum(int value1, int value2) 
    {
        int result = value1 + value2;
        _history.Insert(0, $"{value1} + {value2} = {result}");
        return value1 + value2;
    }

    public int Subtract(int value1, int value2) 
    {
        int result = value1 - value2;
        _history.Insert(0, $"{value1} - {value2} = {result}");
        return value1 - value2;
    }

    public int Multiply(int value1, int value2) 
    {
        int result = value1 * value2;
        _history.Insert(0, $"{value1} * {value2} = {result}");
        return value1 * value2;
    }

    public int Divide(int value1, int value2) 
    {
        int result = value1 / value2;
        _history.Insert(0, $"{value1} / {value2} = {result}");
        return value1 / value2;
    }

    public List<string> GetHistory()
    {
        if (_history.Count > 3)
        {
            _history.RemoveRange(3, _history.Count - 3);
            return _history;
        }
        return _history;
    }
}