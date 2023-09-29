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

      for(var i = 0; i < words.Length; i++)
      {
        Semantic(words, i, );
      }

    }

    public static void Semantic(string[]? words, int i, Regex? semanticWord, string color)
    {
      if(semanticWord.IsMatch(words[i]))
        {
          switch(color)
          {
            case "strong": Console.ForegroundColor = ConsoleColor.Red; break;
            case "em": Console.ForegroundColor = ConsoleColor.Yellow; break;
          }
          Console.Write(
            words[i].Substring(
              words[i].IndexOf('>') + 1,
              (
                (words[i].LastIndexOf('<') -1) - words[i].IndexOf('>')
              )
            )
          );
          Console.Write(" ");
        } else {
          Console.ForegroundColor = ConsoleColor.White;
          Console.Write(words[i]);
          Console.Write(" ");
        }
    }
  }
}