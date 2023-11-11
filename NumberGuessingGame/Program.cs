using System;
using System.Windows.Forms;

namespace NumberGuessingGame
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Instantiate your main form
            Main mainForm = new Main();

            // Run the application with the main form
            Application.Run(mainForm);
        }
    }
}