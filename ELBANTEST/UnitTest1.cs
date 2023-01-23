using ELBAN;

namespace ELBANTEST;

public class UnitTest1
{
    [Fact]
    public void BubbleSortTest()
    {

        int[] arr = { 3, 7, 1, 6, 3, 9 };

        EBLO.BubbleSrt(arr);

        Assert.Equal(new[] { 1, 3, 3, 6, 7, 9 }, arr);
    }
}