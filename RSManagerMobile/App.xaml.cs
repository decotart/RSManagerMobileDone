using RSManagerMobile.Models;

namespace RSManagerMobile
{
    public partial class App : Application
    {
        static DataBase dataBase;

        public App()
        {
            InitializeComponent();

            string dbPath = Path.Combine(Environment.GetFolderPath(
                Environment.SpecialFolder.LocalApplicationData), "RSManager.db");

            dataBase = new(dbPath);

            MainPage = new AppShell();
        }

        public static DataBase _db
        {
            get { return dataBase; }
        }
    }
}
