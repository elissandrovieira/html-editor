using System.Text.RegularExpressions;

namespace HtmlEditor
{
  public class Viewer
  {
    public static void Show(string text)
    {
      Console.Clear();
      Console.BackgroundColor = ConsoleColor.White;
      Console.ForegroundColor = ConsoleColor.Black;
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

      for(var i = 0; i < words.Length; i++)
      {
        Semantic(words, i, strong, "strong");
        Semantic(words, i, em, "em");
      }

    }

    public static void Semantic(string[]? words, int i, Regex? semanticWord, string color)
    {
      
    }
  }
}