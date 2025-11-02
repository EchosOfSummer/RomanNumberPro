using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumberPro.Views;

public partial class NumberPage : ContentPage
{
    public NumberPage()
    {
        InitializeComponent();
        Title = "Numbers";
        ToolbarItem tbi = new ToolbarItem();
        tbi.Text = "About";
        this.ToolbarItems.Add(tbi);
        tbi.Clicked += delegate
        {
            Navigation.PushAsync(new AboutPage());
        };
    }
}