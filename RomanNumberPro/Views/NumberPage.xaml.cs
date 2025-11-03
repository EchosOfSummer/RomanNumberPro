using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RomanNumberPro.Models;

namespace RomanNumberPro.Views;

public partial class NumberPage : ContentPage
{
    private readonly Converter _converter = new();
    public NumberPage()
    {
        InitializeComponent();
        var tbi = new ToolbarItem { Text = "About" };
        ToolbarItems.Add(tbi);
        // this.ToolbarItems.Add(tbi);
        tbi.Clicked += async (_, __) =>
        {
            if (Shell.Current.CurrentPage is AboutPage) return;
            await Shell.Current.GoToAsync("AboutPage");
        };
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

        RResult.Text = _converter.NumberToRoman(number);
    }
}