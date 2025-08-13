using MauiAppBuscaDinamica.Helpers;

namespace MauiAppBuscaDinamica
{
    public partial class App : Application
    {
        static SQLiteDataBaseHelper? _db;
        public static SQLiteDataBaseHelper Db
        {
            get
            {

                if (_db == null)
                {
                    string caminho = Path.Combine(
                        Environment.GetFolderPath(
                            Environment.SpecialFolder.LocalApplicationData),

                        "banco_sqlite_compra.db3");
                    _db = new SQLiteDataBaseHelper(caminho);
                }
                return _db;

            }
        }
        public App()
        {
            InitializeComponent();
            //  MainPage = new AppShell();
            MainPage = new NavigationPage(new View.ListaProduto());

        }

    }
}

