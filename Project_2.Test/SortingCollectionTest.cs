using Project_2;
using NUnit.Framework;

public class SortingCollectionTest
{
    #region Поле

    private SortingCollection _sortingCollection;

    #endregion

    #region Метод

    [SetUp]
    public void SortingCollectionTestSetUp()
    {
        _sortingCollection = new SortingCollection();
    }
    
    #endregion
    
    #region Тест 1. Сортировка выбором

    private static readonly object[] ArrayForTask1 = new object[]
    {
        new object[] { new double[] {1, 10, -5, 5}, new double[] {-5, 1, 5, 10} },
        new object[] { new double[] {1.50, -1.50, -2.0, 3.0}, new double[] {-2.0, -1.50, 1.50, 3.0} },
        new object[] { new double[] {-1.6, -5, -5.1, 1}, new double[] {-5.1, -5, -1.6, 1} }
    };
    
    [Test(Description = "Сортировка выбором")]
    [TestCaseSource(nameof(ArrayForTask1))]
    public void SortingСhoiceTest(double[] array, double[] sortArray)
    {
        var actual = _sortingCollection.SortingСhoice(array);
        var expected = sortArray;
        
        Assert.That(expected.SequenceEqual(actual));
    }

    #endregion
    
    #region Тест 2. Быстрая сортировка

    private static readonly object[] ArrayForTask2 = new object[]
    {
        new object[] { new double[] {1, -5.4, 5, 3.9}, new double[] {-5.4, 1, 3.9, 5} },
        new object[] { new double[] {0, -9, 3.0, 2.0}, new double[] {-9, 0, 2.0, 3.0} },
        new object[] { new double[] {0, -1.6, 2.9, 1}, new double[] {-1.6, 0, 1, 2.9} }
    };
    
    [Test(Description = "Быстрая сортировка")]
    [TestCaseSource(nameof(ArrayForTask2))]
    public void QuickSortingTest(double[] array, double[] sortArray)
    {
        var actual = _sortingCollection.QuickSorting(array);
        var expected = sortArray;
        
        Assert.That(expected.SequenceEqual(actual));
    }

    #endregion
}