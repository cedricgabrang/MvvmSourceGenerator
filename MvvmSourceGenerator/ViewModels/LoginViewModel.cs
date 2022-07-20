using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MvvmSourceGenerator.ViewModels
{
    [INotifyPropertyChanged]
    public partial class LoginViewModel
    {
        [ObservableProperty]
        string _userName;

        [ObservableProperty]
        string _password;

        [RelayCommand]
        void Submit()
        {
            if (string.IsNullOrEmpty(UserName) || string.IsNullOrEmpty(Password)) return;

            Shell.Current.DisplayAlert("Hooray!", "MVVM Source Generators rocks!", "Ok");
        }
    }
}
