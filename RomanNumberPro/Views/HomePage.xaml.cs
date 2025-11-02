using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumberPro.Views;

public partial class HomePage : ContentPage
{
    public HomePage()
    {
        InitializeComponent();
    }

    private async void Roman(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//RomanPage");
    }

    private async void Number(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//NumberPage");
    }

    private async void About(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//AboutPage");
    }

}