using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RomanNumberPro.Models;

namespace RomanNumberPro.Views;

public partial class RomanPage : ContentPage
{
    private readonly Converter _converter = new();
    public RomanPage()
    {
        InitializeComponent();
        Title = "Roman -> Number";
        
        var tbi = new ToolbarItem { Text = "About" };
        ToolbarItems.Add(tbi);
        
        tbi.Clicked += async (_, __) =>
        {
            if (Shell.Current.CurrentPage is AboutPage) return;
            await Shell.Current.GoToAsync("AboutPage");
        };
    }

    private void ConvertN(object sender, EventArgs e)
    {
        ErrorN.IsVisible = false;
        NResult.Text = "";

        var input = RomanEntry.Text?.Trim() ?? "";
        if (string.IsNullOrEmpty(input))
        {
            ErrorN.Text = "Please enter a Roman numeral.";
            ErrorN.IsVisible = true;
            return;
        }

        var value = _converter.RomanToNumber(input);
        if (value == -1)
        {
            ErrorN.Text = "Invalid characters";
            ErrorN.IsVisible = true;
            return;
        }

        NResult.Text = value.ToString();
    }
}

