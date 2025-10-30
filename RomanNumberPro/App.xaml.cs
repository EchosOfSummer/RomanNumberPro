﻿using RomanNumberPro.Views;

namespace RomanNumberPro;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        var shell = new Shell
        {
            Items =
            {
                new Tab
                {
                    Title = "Number to Roman Numerical Converter",
                    Icon = "",
                    Items =
                    {
                        new ShellContent
                        {
                            Route = "NumberPage",
                            ContentTemplate = new DataTemplate(() => new NumberPage())
                        }
                    }
                },
                new Tab
                {
                    Title = "Roman Numerical to Number",
                    Icon = "",
                    Items =
                    {
                        new ShellContent
                        {
                            Route = "RomanPage",
                            ContentTemplate = new DataTemplate(() => new RomanPage())
                        }
                    }
                },
                new Tab
                {
                    Title = "About",
                    Icon = "",
                    Items =
                    {
                        new ShellContent
                        {
                            Route = "AboutPage",
                            ContentTemplate = new DataTemplate(() => new AboutPage())
                        }
                    }
                }
            }
        };
        MainPage = shell;
    }
}