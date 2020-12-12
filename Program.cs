using MSAccessApp.Forms;
using MSAccessApp.Persistence;
using System;
using System.Windows.Forms;

namespace MSAccessApp
{
    static class Program
    {
        public class FormProvider
        {
            public static StartMenu MainMenu
            {
                get
                {
                    if (_mainMenu == null)
                    {
                        _mainMenu = new StartMenu(DatabaseProvider.Get());
                    }
                    return _mainMenu;
                }
            }
            private static StartMenu _mainMenu;
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            var dbProvider = DatabaseProvider.Get();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(FormProvider.MainMenu);
        }

    }
}
