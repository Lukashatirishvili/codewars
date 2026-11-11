public static class Kata
{
 public static int Pillars(int numPill, int dist, int width)
  {
   
   if (numPill == 1) {
     return 0;
   }
   
    var distanceInMetre = dist * (numPill - 1);
    var pillarWidthSumInCentimeters = (numPill - 2) * width;
   
    return distanceInMetre * 100 + pillarWidthSumInCentimeters;
  }
}
