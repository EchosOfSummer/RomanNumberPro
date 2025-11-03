using RomanNumberPro.Views;

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
                    Title = "*Welcome*",
                    Icon = "",
                    Items =
                    {
                        new ShellContent
                        {
                            Route = "HomePage",
                            ContentTemplate = new DataTemplate(() => new HomePage())
                        }}},
                new Tab
                {
                    Title = "*N => R*",
                    Icon = "",
                    Items =
                    {
                        new ShellContent
                        {
                            Route = "NumberPage",
                            ContentTemplate = new DataTemplate(() => new NumberPage())
                        }}},
                new Tab
                {
                    Title = "R => N",
                    Icon = "",
                    Items =
                    {
                        new ShellContent
                        {
                            Route = "RomanPage",
                            ContentTemplate = new DataTemplate(() => new RomanPage())
                        }}}}};
        Routing.RegisterRoute("AboutPage", typeof(AboutPage));
        MainPage = shell;
    }
}
