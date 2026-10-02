public class Kata
{
    public static bool Collinearity(int x1, int y1, int x2, int y2)
    {
      
      var firstVector = x1 * y2;
      var secondVector = x2 * y1;
      
      if (firstVector == secondVector) {
        
        return true;
      }
      
       return false;
    }
}
