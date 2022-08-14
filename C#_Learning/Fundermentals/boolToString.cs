//Convert a Boolean to a String
using System;

public class kata
{
  public static string boolean_to_string(bool b)
  {
  //Please don't delete me!
    if (b == true)
      return "True";
    else
      return "False";
  }

    public static string boolean_to_string2(bool b)
    {
        return b?"True":"False";
    }

    public static string boolean_to_string3(bool b) => b.ToString();
}