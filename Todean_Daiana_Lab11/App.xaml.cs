using Todean_Daiana_Lab11.Data;
using Todean_Daiana_Lab11.Models;

namespace Todean_Daiana_Lab11
{
    public partial class App : Application
    {
        public static ShoppingListDatabase Database { get; private set; }
        public App()
        {
            Database = new ShoppingListDatabase(new RestService());
            MainPage = new NavigationPage(new ListEntryPage());
        }
    }
}