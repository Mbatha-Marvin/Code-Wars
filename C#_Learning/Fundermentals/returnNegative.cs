/**
 *Return Negative
 *The number can be negative already, in which case no change is required.
 * Zero (0) is not checked for any specific sign. Negative zeros make no mathematical sense.
 */
using System;

public static class Kata
{
  public static int MakeNegative(int number)
  {
    if (number > 0)
      return number * -1;
    else
      return number;
  }
}