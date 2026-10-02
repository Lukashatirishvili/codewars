public class Kata
{
    public static int[] Flip(char dir, int[] arr) {
      
      if (dir == 'R') {
        for (int i = 0; i < arr.Length - 1; i++) {
          int min = i;
          for (int j = i + 1; j < arr.Length; j++) {
            if (arr[min] > arr[j]) {
              min = j;
            }
          }
          
          int temp = arr[i];
          arr[i] = arr[min];
          arr[min] = temp;
        }
      }
      
      if (dir == 'L') {
        for (int i = 0; i < arr.Length - 1; i++) {
          int max = i;
          for (int j = i + 1; j < arr.Length; j++) {
            if (arr[max] < arr[j]) {
              max = j;
            }
          }
          
          int temp = arr[i];
          arr[i] = arr[max];
          arr[max] = temp;
        }
      }
      
      return arr;
    }
}
