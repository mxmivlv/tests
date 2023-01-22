using Project_2;
using NUnit.Framework;

[TestFixture]
public class DecisionKataTest
{
    #region Поле

    private DecisionKata _decisionKata;

    #endregion

    #region Метод

    [SetUp]
    public void DecisionKataTestSetUp()
    {
        _decisionKata = new DecisionKata();
    }

    #endregion

    #region Тест 1. Создание номера телефона из входящего массива

    private static readonly object[] ArrayForTask1 = new object[]
    {
        new object[] { new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }, "(123) 456-7890" },
        new object[] { new int[] { 2, 2, 3, 4, 5, 6, 7, 8, 9, 0 }, "(223) 456-7890" },
        new object[] { new int[] { 3, 2, 3, 4, 5, 6, 7, 8, 9, 0 }, "(323) 456-7890" }
    };
    
    [Test(Description = "Создание номера телефона из входящего массива")]
    [TestCaseSource(nameof(ArrayForTask1))]
    public void CreatePhoneNumberTest(int[] array, string createPhone)
    {
        var actual = _decisionKata.CreatePhoneNumber(array);
        
        var expected = createPhone;
        
        Assert.That(actual,Is.EqualTo(expected));
    }

    #endregion

    #region Тест 2. Вытащить из массива только цифры

    private static readonly object[] ArrayForTask2 = new object[]
    {
        new object[] { new List<object> { 1, 2, "q", -90, "e", 6, "rrr", 8.7, "t", 0 }, new List<int> {1, 2, -90, 6, 0} },
        new object[] { new List<object> { 1, "q", -90, "e", "rrr", 8.7, "t", 0 }, new List<int> {1, -90, 0} },
        new object[] { new List<object> { "q", -90, "e", "rrr", "t", 0 }, new List<int> {-90, 0 } }
    };

    [Test(Description = "Вытащить из массива только цифры")]
    [TestCaseSource(nameof(ArrayForTask2))]
    public void GetIntegersFromListTest(List<object> listObj, List<int> listInt )
    {
        var actual = _decisionKata.GetIntegersFromList(listObj);
        
        var expected = listInt;

        Assert.That(expected.SequenceEqual(actual));
    }
    
    #endregion

    #region Тест 3. Из строки нужно каждые две буквы объединить и положить в массив

    private static readonly object[] ArrayForTask3 = new object[]
    {
        new object[] { "магазин", new string[] {"ма", "га", "зи", "н_"} },
        new object[] { "монополия", new string[] {"мо", "но", "по", "ли", "я_"} },
        new object[] { "софт", new string[] {"со", "фт"} }
    };
    
    [Test(Description = "Из строки нужно каждые две буквы объединить и положить в массив")]
    [TestCaseSource(nameof(ArrayForTask3))]
    public void SolutionTest(string str, string[] array)
    {
        var actual = _decisionKata.Solution(str);
        
        var expected = array;
        
        Assert.That(expected.SequenceEqual(actual));
    }

    #endregion

    #region Тест 4. Валидность IP

    private static readonly object[] ArrayForTask4 = new object[]
    {
        new object[] { "0.0.0.0", true },
        new object[] { "12.255.56.1", true },
        new object[] { "137.255.156.100", true },
        new object[] { "", false },
        new object[] { "abc.def.ghi.jkl", false },
        new object[] { "123.456.789.0", false },
        new object[] { "12.34.56", false },
        new object[] { "12.34.56.00", false },
        new object[] { "12.34.56.7.8", false },
        new object[] { "12.34.256.78", false },
        new object[] { "1234.34.56", false },
        new object[] { "pr12.34.56.78", false },
        new object[] { "12.34.56.78sf", false },
        new object[] { "12.34.56 .1", false },
        new object[] { "12.34.56.-1", false },
        new object[] { "123.045.067.089", false },
    };
    
    [Test(Description = "Валидность IP")]
    [TestCaseSource(nameof(ArrayForTask4))]
    public void IsValidIpTest(string ipAddress, bool isValidIp)
    {
        var actual = _decisionKata.IsValidIp(ipAddress);
        
        var expected = isValidIp;
        
        Assert.That(actual,Is.EqualTo(expected));
    }

    #endregion
}