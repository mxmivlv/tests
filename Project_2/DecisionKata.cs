namespace Project_2;

public class DecisionKata
{
    /// <summary>
    /// Создание номера телефона из входящего массива
    /// </summary>
    /// <param name="numbers">Массив цифр</param>
    /// <returns>Строка</returns>
    public string CreatePhoneNumber(int[] numbers)
    {
        string numberPhone = "(";

        for (int i = 0; i < numbers.Length; i++)
        {
            if (i == 3)
            {
                numberPhone += ") ";
            }

            if (i == 6)
            {
                numberPhone += "-";
            }

            numberPhone += numbers[i];
        }
            
        return numberPhone;
        
        // Решение с помощью LinQ
        //return string.Format("({0}{1}{2}) {3}{4}{5}-{6}{7}{8}{9}",numbers.Select(x=>x.ToString()).ToArray());
    }
    
    /// <summary>
    /// Вытащить из массива только цифры
    /// </summary>
    /// <param name="listOfItems">Массив объектов</param>
    /// <returns>Массив цифр</returns>
    public IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
    {
        List<int> returnCollection = new List<int>();
        
        for (int i = 0; i < listOfItems.Count; i++)
        {
            if (listOfItems[i].GetType() == typeof(int))
            {
                returnCollection.Add((int)listOfItems[i]);
            }
        }

        return returnCollection;
        
        // Решение с помощью LinQ    
        //return listOfItems.OfType<int>();
    }

    /// <summary>
    /// Из строки нужно каждые две буквы объединить и положить в массив "asdfg"=> 'as' 'df' 'g_'
    /// </summary>
    /// <param name="str">Строка</param>
    /// <returns>Массив строк, состоящих из двух букв</returns>
    public string[] Solution(string str)
    {
        if (str.Length % 2 == 0)
        {
            string[] returnResult = new string[(str.Length / 2)];

            int countIndex = 0;

            for (int i = 0; i < returnResult.Length; i++)
            {
                for (int j = countIndex; j < (countIndex+2); j++)
                {
                    returnResult[i] += str[j];
                }

                countIndex += 2;
            }
            
            return returnResult;
        }
        else
        {
            string[] returnResult = new string[(str.Length / 2)+1];

            int countIndex = 0;

            for (int i = 0; i < returnResult.Length-1; i++)
            {
                for (int j = countIndex; j < (countIndex+2); j++)
                {
                    returnResult[i] += str[j];
                }

                countIndex += 2;
            }

            returnResult[(str.Length / 2)] += str[str.Length-1];

            returnResult[(str.Length / 2)] += '_';
            
            return returnResult;
        }
    }

    /// <summary>
    /// Проверка на валидность IP адреса
    /// </summary>
    /// <param name="ipAddress">IP адрес</param>
    /// <returns>True - если валидный, иначе false</returns>
    public bool IsValidIp(string ipAddress)
    {
        var objects = ipAddress.Split(".");
          
        if (objects.Count() != 4) return false;
            
        foreach (var obj in objects)
        {
            if (!int.TryParse(obj, out int numericObject))
                return false;

            if (numericObject < 0 || numericObject > 255)
                return false;
              
            if (!numericObject.ToString().Equals(obj))
                return false;
        }
          
        return true;
    }
    
}





