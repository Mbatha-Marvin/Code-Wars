/**
 *Given a year, return the century it is in.
 *
 * For Example:
 *      1705 --> 18
 *      1900 --> 19
 *      1601 --> 17
 *      2000 --> 20
 */

public static class Kata
{
  public static int СenturyFromYear(int year)
  {
    if(year <= 100)
      return 1;
    else
    {
      int cent = year / 100;
      if (year % 100 == 0)
        return cent;
      else
        return cent + 1;
    }
  }
}