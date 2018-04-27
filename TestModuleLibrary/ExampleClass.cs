using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestModuleLibrary
{
  public static class ExampleClass
  {
    public static string Method1(string strResult = "")
    {
      return string.IsNullOrWhiteSpace(strResult)? "Example result 1" : strResult;
    }

    public static string Method2()
    {
      return "Example result 2";
    }

  }
}
