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
      static void 
      Console.Write("+");
      for (int i = 0; i <= 50; i++)
        Console.Write("-");

      Console.Write("+");
      Console.Write("\n");

      for (int lines = 0; lines <=10; lines++)
      {
        Console.Write("|");
        for (int i = 0; i <= 50; i++)
          Console.Write(" ");

        Console.Write("|");
        Console.Write("\n");
      }

      Console.Write("+");
      for (int i = 0; i <= 50; i++)
        Console.Write("-");

      Console.Write("+");
      
    }
  }
}