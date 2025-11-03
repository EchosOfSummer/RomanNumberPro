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
                    Title = "Number => Roman",
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
                    Title = "Roman => Number",
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


                
// },
// new Tab
// {
//     Title = "About",
//     Icon = "",
//     Items =
//     {
//         new ShellContent
//         {
//             Route = "AboutPage",
//             ContentTemplate = new DataTemplate(() => new NumberPage())
//         }
//     }
// }