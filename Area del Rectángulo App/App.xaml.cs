using AreaRectanguloApp.Views;

namespace AreaRectanguloApp;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new RectanguloView();
    }
}
