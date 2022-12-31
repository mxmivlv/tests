namespace Project_2;

public class SortingCollection
{
    /// <summary>
    /// Сортировка выбором
    /// </summary>
    /// <param name="arr">Входной не сортированный массив</param>
    /// <returns>Сортированный массив</returns>
    public double[] SortingСhoice(double[] arr)
    {
        double tempNumber;

        for (int i = 0; i < arr.Length; i++)
        {
            for (int k = i+1; k < arr.Length; k++)
            {
                if (arr[i] > arr[k])
                {
                    tempNumber = arr[k];
                    
                    arr[k] = arr[i];
                    
                    arr[i] = tempNumber;
                }
            }
        }
        
        return arr;
    }
    
    /// <summary>
    /// Быстрая сортировка
    /// </summary>
    /// <param name="arr">Массив</param>
    /// <param name="minIndex">Минимальный индекс массива</param>
    /// <param name="maxIndex">Максимальный индекс массива</param>
    /// <returns>Отсортированный массив</returns>
    public double[] QuickSorting(double []arr, int? minIndex = null, int? maxIndex = null)
    {
        // Минимальный индекс массива
        int i = minIndex ?? 0;

        // Максимальный индекс
        int j = maxIndex ?? arr.Length - 1;
        
        if (i >= j)
        {
            return arr;
        }
        
        // Временная переменная, нужна для обмена элементами
        double temp = 0;

        // Центральный элемент
        double x = arr[(i + j) / 2];

        while (i < j)
        {
            while (arr[i] < x)
            {
                i++;
            }

            while (arr[j] > x)
            {
                j--;
            }

            if (i <= j)
            {
                temp = arr[i];

                arr[i] = arr[j];

                arr[j] = temp;

                i++;

                j--;
            }
        }

        QuickSorting(arr, minIndex, j);

        QuickSorting(arr, i, maxIndex);

        return arr;
    }
}