namespace Project_2;

public class SearchInCollection
{
    /// <summary>
    /// Бинарный поиск
    /// </summary>
    /// <param name="arr">Отсортированный массив</param>
    /// <param name="item">Элемент, который нужно найти</param>
    /// <returns>Индекс элемента, если такого нет в массиве, то возвращает -1</returns>
    public int BinarySearch(double[] arr, double item)
    {
        int firstNumber = 0;
        
        int middleNumber;
        
        int lastNumber = arr.Length-1;
			
        while(firstNumber <= lastNumber)
        {
            middleNumber = (firstNumber + lastNumber) / 2;
			
            if (arr[middleNumber] < item)
            {
                firstNumber = middleNumber+1;
            }

            if (arr[middleNumber] > item)
            {
                lastNumber = middleNumber-1;
            }

            if (arr[middleNumber] == item)
            {
                return middleNumber;
            }
        }

        return -1;
    }
    
    /// <summary>
    /// Нахождение максимального числа в массиве
    /// </summary>
    /// <param name="array">Массив в котором выполняется поиск</param>
    /// <returns>Максимально число</returns>
    public int MaximumNumberInTheArray(int[] array)
    {
        int maximumNumber = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (maximumNumber < array[i])
            {
                maximumNumber = array[i];
            }
        }
        
        return maximumNumber;
    }
    
    /// <summary>
    /// Нахождение минимального числа в массиве
    /// </summary>
    /// <param name="array">Массив для поиска</param>
    /// <returns>Минимальное число</returns>
    public int MinimumNumberInTheArray(int[] array)
    {
        int minimumNumber = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (minimumNumber > array[i])
            {
                minimumNumber = array[i];
            }
        }
        
        return minimumNumber;
    }
    
    /// <summary>
    /// Нахождение среднего значения массива
    /// </summary>
    /// <param name="array">Массив</param>
    /// <returns>Среднее значение</returns>
    public double AverageValueInTheArray(int[] array)
    {
        long count = array.Length;
        
        double tempNumbers = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            tempNumbers += array[i];
        }
        
        return tempNumbers / count;
    }
    
    /// <summary>
    /// Нахождение выгодного заказчика
    /// </summary>
    /// <param name="array">Массив массивов</param>
    /// <returns>Индекс заказчика</returns>
    public int ProfitableClient(int[][] array)
    {
        // Индекс заказчика для возврата
        int indexCustomer = 0;
        // Доходы от заказчиков
        int incomeCustomer = 0;
        // Коллекция в которой собраны все доходы по заказчикам
        List<int> collectionIncomeCustomer = new List<int>();

        for (int i = 0; i < array.Length; i++)
        {
            for (int q = 0; q < array[i].Length; q++)
            {
                incomeCustomer += array[i][q];
            }
            collectionIncomeCustomer.Add(incomeCustomer);
            
            incomeCustomer = 0;
        }

        // Самое маленькое число
        int tempNumberMin = int.MinValue;

        for (int i = 0; i < collectionIncomeCustomer.Count; i++)
        {
            // Сравниваем и ищем самое большое число
            if (tempNumberMin < collectionIncomeCustomer[i])
            {
                tempNumberMin = collectionIncomeCustomer[i];
                
                indexCustomer = i;
            }
        }
        
        return indexCustomer;
    }
    
    /// <summary>
    /// Проверить массив на уникальные записи. Если записи в двух разных массивах не уникальны — вернуть первуть первую сумму,
    /// которая повторяется, если уникальны: -1
    /// </summary>
    /// <param name="report">Массив</param>
    /// <returns>Сумма, которая повторяется. Если все записи уникальны вернуть: -1</returns>
    public int AvoidJailDueToTaxFraud(int[][] report)
    {
        // Перменная для вывода
        int numbersReturn = -1;
        
        // Временная переменная для записи значения и дальнейшего сравнения
        int tempNumbers = 0;

        for (int i = 0; i < report.Length; i++)
        {
            for (int j = 0; j < report[i].Length; j++)
            {
                // Записали данные
                tempNumbers = report[i][j];

                for (int e = 0; e < report.Length; e++)
                {
                    for (int q = 0; q < report[e].Length; q++)
                    {
                        if (tempNumbers == report[e][q] && i != e && j != q)
                        {
                            numbersReturn = tempNumbers;
                            
                            break;
                        }
                    }
                }
            }
        }
        
        return numbersReturn;
    }
}