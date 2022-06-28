using System.Collections.Generic;

public class Kata
{
    public static List<string> GetPINs(string observed)
    {
        var pins = new List<List<int>>()
        {
          new List<int>(){1, 2, 4},
          new List<int>(){1, 2, 3, 5},
          new List<int>(){2, 3, 6},
          new List<int>(){1, 4, 5, 7},
          new List<int>(){2, 4, 5, 6, 8},
          new List<int>(){3, 5, 6, 9},
          new List<int>(){4, 7, 8},
          new List<int>(){5, 7, 8, 9, 0},
          new List<int>(){6, 8, 9},
          new List<int>(){8, 0},
        };
        var result = new List<string>();
      foreach(var c in observed)
      {
        foreach (var i in pins)
        {
            var numString = i.ToString();
            if(!result.Contains(numString))
                result.Add(numString);
        }
      }

      for (var i = 0; i < result.Count; i++)
      {
        for
      }


      return new List<string>();
    }
}