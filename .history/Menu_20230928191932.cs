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
      Console.Write("+");
      for (int i = 0; i <= 50; i++)
        Console.Write("-");
      Console.Write("+");
      
    }
  }
}