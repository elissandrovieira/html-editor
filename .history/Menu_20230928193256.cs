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
      

      Lines("+", "-");

      for (int lines = 0; lines <=10; lines++)
      {
        Lines("|", " ");
      }

      Lines("+", " ");

    }
  }
}