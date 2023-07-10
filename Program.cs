using TextGenerator.Module.Keyboard;
namespace TextGenerator
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            KeyPressGenerator.GenerateText();
        }
    }
}