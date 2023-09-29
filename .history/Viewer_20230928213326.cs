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
      Console.ForegroundColor = ConsoleColor.;

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
        if(strong.IsMatch(words[i]))
        {
          SemanticColors("strong", words, i);
        } else if (em.IsMatch(words[i]))
        {
          SemanticColors("em", words, i);
          
        } else {
          Console.ForegroundColor = ConsoleColor.Black;
          Console.Write(words[i]);
          Console.Write(" ");
        }
      }
    }

    public static void SemanticColors(string semanticWord, string[]? words, int i)
    {
      switch(semanticWord)
      {
        case "strong": Console.ForegroundColor = ConsoleColor.Red; break;
        case "em": Console.ForegroundColor = ConsoleColor.Blue; break;
        default: Console.ForegroundColor = ConsoleColor.Black; break;
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
    }
  }
}