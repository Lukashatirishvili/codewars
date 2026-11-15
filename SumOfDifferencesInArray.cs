using System;
public static class Kata
{
    public static int SumOfDifferences(int[] arr)
    {

        if (arr.Length <= 1) return 0;
      

        for (int i = 0; i < arr.Length - 1; i++)
        {
            int max = i;
    
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] > arr[max])
                {
                    max = j;
                }
            }

            int temp = arr[i];
            arr[i] = arr[max];
            arr[max] = temp;
    
        }

        int sum = 0;

      
      for (int i = 0; i < arr.Length - 1; i++)
        {
            sum += arr[i] - (arr[i + 1]);
        }

        return sum;

    }
}
