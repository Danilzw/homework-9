//Задача со звездочкой Найти второй максимум в массиве.
//4, 4, 3, 0, 2 => 3
 int FindSecondMax(int[] arr)
    {
        int max1 = arr[0];
        int max2 = arr[0];

        foreach (int num in arr)
        {
            if (num > max1)
            {
                max2 = max1;
                max1 = num;
            }
            else if (num > max2)
            {
                max2 = num;
            }
        }

        return max2;
    }

    
int[] arr = { 5, 2, 8, 7, 3, 9 };
int secondMax = FindSecondMax(arr);
Console.WriteLine(secondMax);



