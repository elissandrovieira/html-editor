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
      WriteOptions();

      var option = short.Parse(Console.ReadLine());
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
      Console.SetCursorPosition(3, 3);
      Console.WriteLine("--------------------------------------------------");
      Console.SetCursorPosition(3, 4);
      Console.WriteLine("Select a option:");
      Console.SetCursorPosition(3, 6);
      Console.WriteLine("1 - New File");
      Console.SetCursorPosition(3, 7);
      Console.WriteLine("2 - Open File");
      Console.SetCursorPosition(3, 8);
      Console.WriteLine("0 - Exit");
      Console.SetCursorPosition(3,10);
      Console.WriteLine("Option: ");
    }

    public static void HandleMenu

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