using System;

public class Kata
{
  public static string BatteryBars(int percent)
  {
    
    string five = "[#####]";
    string four = "[####.]";
    string three = "[###..]";
    string two = "[##...]";
    string one = "[#....]";
    string zero = "[.....]";
    
    if ((percent / 20) == 5) {
      return five;
    } else if ((percent / 20) == 4) {
      return four;
    } else if ((percent / 20) == 3) {
      return three;
    } else if ((percent / 20) == 2) {
      return two;
    } else if ((percent / 20) == 1) {
      return one;
    } else  {
      return zero;
    }
    
  }
}
