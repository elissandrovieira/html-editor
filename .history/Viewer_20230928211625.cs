using System.Text.RegularExpressions;

namespace HtmlEditor
{
  public class Viewer
  {
    public static void Show(string text)
    {
      Console.Clear();
      Console.ForegroundColor = ConsoleColor.White;
      Console.Clear();
      Console.WriteLine("VIEWER MODE");
      Console.WriteLine("--------------------------------------------------");
      Replace(text);
      Console.WriteLine("--------------------------------------------------");
      Console.ReadKey();
      Menu.Show();
    }

    public static void Replace(string text)
    {
      var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
      var em = new Regex(@"<\s*em[^>]*>(.*?)<\s*/\s*em>");
      var words = text.Split(' ');

      

    }

    public static void Semantic(string[]? words, Regex? semanticWord, string color)
    {
      
        }
      }
    }
  }
}