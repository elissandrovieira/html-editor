using System.Text;

namespace HtmlEditor
{
  public static class Editor
  {
    public static void Show()
    {
      Console.Clear();
      Console.BackgroundColor = ConsoleColor.DarkBlue;
      Console.ForegroundColor = ConsoleColor.White;
      Console.Clear();
      Console.WriteLine("EDITOR MODE");
      Console.WriteLine("--------------------------------------------------");
    }

    public static void Start()
    {
      var file = new StringBuilder();

      do
      {
        file.Append(Console.ReadLine)
      }
    }
  }
}