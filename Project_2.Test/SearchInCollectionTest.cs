using Project_2;
using NUnit.Framework;

[TestFixture]
public class SearchInCollectionTest
{
    #region Поле

    private SearchInCollection _searchInCollection;

    #endregion

    #region Метод

    [SetUp]
    public void SearchInCollectionTestSetUp()
    {
        _searchInCollection = new SearchInCollection();
    }
    
    #endregion

    #region Тест 1. Бинарный поиск

    private static readonly object[] ArrayForTask1 = new object[]
    {
        new object[] { new double[] {-5.4, 1, 3.9, 5}, 5, 3 },
        new object[] { new double[] {-9, 0, 2.0, 3.0}, 100, -1 },
        new object[] { new double[] {-1.6, 0, 1, 2.9},-1.6, 0 }
    };
    
    [Test(Description = "Бинарный поиск")]
    [TestCaseSource(nameof(ArrayForTask1))]
    public void BinarySearchTest(double[] array, double item, int indexItem)
    {
        var actual = _searchInCollection.BinarySearch(array, item);
        var expected = indexItem;
        
        Assert.That(actual,Is.EqualTo(expected));
    }

    #endregion

    #region Тест 2. Нахождение максимального числа в массиве

    private static readonly object[] ArrayForTask2 = new object[]
    {
        new object[] { new int[] {1, 100, 200, -300}, 200 },
        new object[] { new int[] {-1, -10, -20, -30}, -1 },
        new object[] { new int[] {1, 1, 1, 1}, 1 }
    };
    
    [Test(Description = "Нахождение максимального числа в массиве")]
    [TestCaseSource(nameof(ArrayForTask2))]
    public void MaximumNumberInTheArrayTest(int[] array, int maxNumber)
    {
        var actual = _searchInCollection.MaximumNumberInTheArray(array);
        var expected = maxNumber;
        
        Assert.That(actual,Is.EqualTo(expected));
    }

    #endregion

    #region Тест 3. Нахождение минимального числа в массиве

    private static readonly object[] ArrayForTask3 = new object[]
    {
        new object[] { new int[] {1, 100, 200, -300}, -300 },
        new object[] { new int[] {-10, -100, -20, -30}, -100 },
        new object[] { new int[] {1, 1, 1, 1}, 1 }
    };
    
    [Test(Description = "Нахождение минимального числа в массиве")]
    [TestCaseSource(nameof(ArrayForTask3))]
    public void MinimumNumberInTheArrayTest(int[] array, int minNumber)
    {
        var actual = _searchInCollection.MinimumNumberInTheArray(array);
        var expected = minNumber;
        
        Assert.That(actual,Is.EqualTo(expected));
    }

    #endregion

    #region Тест 4. Нахождение среднего значения массива

    private static readonly object[] ArrayForTask4 = new object[]
    {
        new object[] { new int[] {1, 1, 5, 5}, 3 },
        new object[] { new int[] {10, 100, -20, 30}, 30 },
        new object[] { new int[] {-1, -5, -51, -1}, -14.5 }
    };
    
    [Test(Description = "Нахождение среднего значения массива")]
    [TestCaseSource(nameof(ArrayForTask4))]
    public void AverageValueInTheArrayTest(int[] array, double averagNumber)
    {
        var actual = _searchInCollection.AverageValueInTheArray(array);
        var expected = averagNumber;
        
        Assert.That(actual,Is.EqualTo(expected));
    }

    #endregion

    #region Тест 5. Нахождение выгодного заказчика

    private static readonly object[] ArrayForTask5 = new object[]
    {
        new object[] { new int[][]
            {
                new int [] {95, 67, 13, 55, 44, 11, 10},
                new int [] {7, 190, 4, 44, 11, 1, 99},
                new int [] {0, 5, -1, 500, 14, 90, 1}
            }, 
            2 
        },
        new object[] { new int[][]
            {
                new int [] {1, 1, 1, 5, 4, -11, 10},
                new int [] {7, 190, 4, 44, 11, 1, 99},
                new int [] {0, 5, -1, -500, 14, 90, 1}
            }, 
            1 
        },
        new object[] { new int[][]
            {
                new int [] {0, 1, 300 },
                new int [] {-190, 190},
                new int [] {0, 5, -1, }
            },
            0
        }
    };
    
    [Test(Description = "Нахождение выгодного заказчика")]
    [TestCaseSource(nameof(ArrayForTask5))]
    public void ProfitableClientTest(int[][] array, int indexCustomer)
    {
        var actual = _searchInCollection.ProfitableClient(array);
        var expected = indexCustomer;
        
        Assert.That(actual,Is.EqualTo(expected));
    }

    #endregion

    #region Тест 6. Избежать уголовного преследования
    
    private static readonly object[] ArrayForTask6 = new object[]
    {
        new object[] { new int[][]
            {
                new int [] {95, 67, 13, 55, 44, 11, 15},
                new int [] {0, 1, 2, 4, 6, 8, 10},
                new int [] {-7, -5, -1, -10, 14, 90}
            }, 
            -1 
        },
        new object[] { new int[][]
            {
                new int [] {95, 67, 13, 55, 44, 11},
                new int [] {0, 1, 2, 4, 6, 8, 95},
                new int [] {-7, -5, -1, -10, 14, 90}
            }, 
            95 
        },
        new object[] { new int[][]
            {
                new int [] {-90, -67, -13, -55, -44, -11, -6},
                new int [] {0, 1, 2, 4, 6, 8, 10},
                new int [] {-7, -5, -1, -10, 14, 90}
            }, 
            -1 
        }
    };
    
    [Test(Description = "Избежать уголовного преследования. Сумма должна повторятся в двух разных массивах, а не в одном")]
    [TestCaseSource(nameof(ArrayForTask6))]
    public void AvoidJailDueToTaxFraudTest(int[][] array, int amountOrIndex)
    {
        var actual = _searchInCollection.AvoidJailDueToTaxFraud(array);
        var expected = amountOrIndex;
        
        Assert.That(actual,Is.EqualTo(expected));
    }

    #endregion
}