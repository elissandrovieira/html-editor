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
    }

    public static void DrawScreen()
    {
      static void Lines(string vertex, string segment)
      {
        Console.Write(vertex);
        for (int i = 0; i <= 50; i++)
          Console.Write(segment);

        Console.Write(vertex);
        Console.Write("\n");
      }

      Lines("+", "-");

      for (int lines = 0; lines <=10; lines++)
      {
        Lines("")
      }

      Console.Write("+");
      for (int i = 0; i <= 50; i++)
        Console.Write("-");

      Console.Write("+");
      
    }
  }
}