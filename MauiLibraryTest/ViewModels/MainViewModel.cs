namespace MauiLibraryTest.ViewModels;

public partial class MainViewModel : BaseViewModel
{
    MauiLib.TestClass tc = new();

    [ObservableProperty]
    private string data;

    [RelayCommand]
    public void GetData()
    {
        Data = tc.GetData();
    }
}
