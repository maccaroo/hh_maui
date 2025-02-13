namespace hh_maui;

public partial class App : Application
{
    protected override Window CreateWindow(IActivationState? activationState)
    {
        return new Window(new NavigationPage(new Views.LoginPage()));
    }
}