using NUnit.Framework;

[TestFixture]
public class MethodKataTest
{
    #region Поле

    private MethodKata methodKata;

    #endregion

    #region Конструктор

    [SetUp]
    public void ArrayMaxTestSetUp()
    {
        methodKata = new MethodKata();
    }

    #endregion

    #region Тест 1

    private static readonly object[] ArrayForTask1 = new object[]
    {
        new object[] { new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }, "(123) 456-7890" },
        new object[] { new int[] { 2, 2, 3, 4, 5, 6, 7, 8, 9, 0 }, "(223) 456-7890" },
        new object[] { new int[] { 3, 2, 3, 4, 5, 6, 7, 8, 9, 0 }, "(323) 456-7890" }
    };
    
    [Test(Description = "Способы создания номера телефона из входящего массива")]
    [TestCaseSource(nameof(ArrayForTask1))]
    public void CreatePhoneNumberTest(int[] array, string createPhone)
    {
        var actual = methodKata.CreatePhoneNumber(array);
        
        var expected = createPhone;
        
        Assert.That(actual,Is.EqualTo(expected));
    }

    #endregion

    #region Тест 2

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
        var actual = methodKata.GetIntegersFromList(listObj);
        
        var expected = listInt;

        Assert.That(expected.SequenceEqual(actual));
    }
    
    #endregion

    #region Тест 3

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
        var actual = methodKata.Solution(str);
        
        var expected = array;
        
        Assert.That(expected.SequenceEqual(actual));
    }

    #endregion
    
}