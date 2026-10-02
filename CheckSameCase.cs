public class Kata {
  public static int SameCase(char a, char b) {
    
    if (char.IsLower(a) && char.IsLower(b) || char.IsUpper(a) && char.IsUpper(b)) return 1;
    
    if (char.IsLower(a) && char.IsUpper(b) || char.IsUpper(a) && char.IsLower(b)) return 0;
    
    return -1;
    
  }
}
