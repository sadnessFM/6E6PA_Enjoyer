using Xunit;

namespace BebraTests;

public class Testing
{
    [Fact]
    public void BubbleSortTest()
    {

        int[] arr = { 3, 7, 1, 6, 3, 9 };

        bub.BubbleSrt(arr);

        Assert.Equal(new[] { 1, 3, 3, 6, 7, 9 }, arr);
    }
}