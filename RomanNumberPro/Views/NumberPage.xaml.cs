using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RomanNumberPro.Models;

namespace RomanNumberPro.Views;

public partial class NumberPage : ContentPage
{
    public NumberPage()
    {
        InitializeComponent();
        Title = "Number => Roman";
        // ToolbarItem tbi = new ToolbarItem();
        // tbi.Text = "About";
        var tbi = new ToolbarItem { Text = "About" };
        ToolbarItems.Add(tbi);
        this.ToolbarItems.Add(tbi);
        tbi.Clicked += async (_, __) => await Shell.Current.GoToAsync("AboutPage");
    }

    private void ConvertR(object sender, EventArgs e)
    {
        ErrorR.IsVisible = false;
        RResult.Text = "";

        if (!int.TryParse(NEntryNum.Text, out var number))
        {
            ErrorR.Text = "Please enter a valid integer.";
            ErrorR.IsVisible = true;
            return;
        }

        RResult.Text = Converter.NumberToRoman(number);
    }
}