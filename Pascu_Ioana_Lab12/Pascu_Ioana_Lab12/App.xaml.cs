using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Pascu_Ioana_Lab12.Data;

namespace Pascu_Ioana_Lab12
{
    public partial class App : Application
    {
        public static ShoppingListDatabase Database { get; private set; }

        public App()
        {
            //InitializeComponent();
            Database = new ShoppingListDatabase(new RestService());
            MainPage = new NavigationPage(new ListEntryPage());
            //MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
