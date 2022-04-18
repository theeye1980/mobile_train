using mobile_train.ViewModels;
using mobile_train.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace mobile_train
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
