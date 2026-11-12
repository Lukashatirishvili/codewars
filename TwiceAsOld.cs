namespace Solution
{
  public class TwiceAsOldSolution
  {
    public static int TwiceAsOld(int dadYears, int sonYears)
    {
      if (sonYears == 0)
        {
            return dadYears;
        }

        if ((sonYears * 2) > dadYears)
        {
            return (sonYears * 2) - dadYears;
        }


        return dadYears - (sonYears * 2);
    }
  }
}
