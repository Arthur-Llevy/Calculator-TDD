using Src.Classes;

namespace Tests;

public class CalculatorTests 
{
    public Calc constructClass () 
    {
        Calc calc = new Calc();
        return calc;
    }

    [Theory]
    [InlineData (1, 2, 3)]
    public void When_Receiving_Two_Values_Should_Return_Their_Sum(int value1, int valu2, int resultExpected)
    {
        // Arrange
        Calc calc = new Calc();

        // Act
        int resultOfSum = calc.Sum(value1, valu2);

        // Assert
        Assert.Equal(resultExpected, resultOfSum);
    }

    [Theory]
    [InlineData (3, 3, 0)]
    [InlineData (2, 1, 1)]
    public void When_Receiving_Two_Values_Should_Return_Their_Subtract(int value1, int valu2, int resultExpected)
    {
        // Arrange
        Calc calc = new Calc();

        // Act
        int resultOfSubtract = calc.Subtract(value1, valu2);

        // Assert
        Assert.Equal(resultExpected, resultOfSubtract);
    }

    [Theory]
    [InlineData (3, 3, 9)]
    [InlineData (2, 1, 2)]
    public void When_Receiving_Two_Values_Should_Return_Their_Multiply(int value1, int valu2, int resultExpected)
    {
        // Arrange
        Calc calc = new Calc();

        // Act
        int resultOfMultiply = calc.Multiply(value1, valu2);

        // Assert
        Assert.Equal(resultExpected, resultOfMultiply);
    }

    [Theory]
    [InlineData (10, 2, 5)]
    [InlineData (2, 1, 2)]
    public void When_Receiving_Two_Values_Should_Return_Their_Divide(int value1, int valu2, int resultExpected)
    {
        // Arrange
        Calc calc = new Calc();

        // Act
        int resultOfDivide = calc.Divide(value1, valu2);

        // Assert
        Assert.Equal(resultExpected, resultOfDivide);
    }

    [Fact]
    public void When_The_Divide_By_Zero_Shoud_Return_An_Divide_By_Zero_Exception() 
    {
        //Arrange
        Calc calc = new Calc();

        // Assert
        Assert.Throws<DivideByZeroException>(() => calc.Divide(3, 0));
    }

    [Fact]
    public void When_GetHistory_Method_Called_Should_Not_Return_An_Empty_List()
    {
        Calc calc = new Calc();

        calc.Sum(2, 1);
        calc.Sum(3, 1);

        var list = calc.GetHistory();
        Assert.NotEmpty(list);
        Assert.Equal(2, list.Count);
    }
}
