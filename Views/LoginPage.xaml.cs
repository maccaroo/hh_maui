using hh_maui.ViewModels;

namespace hh_maui.Views;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
        BindingContext = new LoginViewModel(this);
    }
}