namespace HtmlEditor
{
  public static class Menu
  {
    public static void Show()
    {
      Console.Clear();
      Console.BackgroundColor = ConsoleColor.DarkRed;
      Console.ForegroundColor = ConsoleColor.Gray; 

      DrawScreen();
      Write
    }

    public static void DrawScreen()
    {
      Lines("+", "-");

      for (int lines = 0; lines <=10; lines++)
      {
        Lines("|", " ");
      }

      Lines("+", "-");

    }

    public static void WriteOptions()
    {
      Console.SetCursorPosition(3, 2);
      Console.WriteLine("HTML Editor");
    }

    static void Lines(string vertex, string segment)
    {
      Console.Write(vertex);
      for (int i = 0; i <= 50; i++)
        Console.Write(segment);

      Console.Write(vertex);
      Console.Write("\n");
    }
  }
}