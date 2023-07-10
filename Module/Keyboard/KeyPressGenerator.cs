namespace TextGenerator.Module.Keyboard;

public static class KeyPressGenerator
{
    public static void GenerateText()
    {
        string text = System.IO.File.ReadAllText($"{Directory.GetCurrentDirectory()}\\input.txt");
        Random random = new Random();
        while (true)
        {
            
            int delay = random.Next(1000, 5000); // delay between keystrokes in milliseconds
            foreach (char key in text)
            {
                try
                {
                    Thread.Sleep(delay); // wait for the next keystroke
                    SendKeys.SendWait(key.ToString()); // send the keypress
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
