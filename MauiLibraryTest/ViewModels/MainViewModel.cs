using MauiLibraryTest.Services;

namespace MauiLibraryTest.ViewModels;

public partial class MainViewModel : BaseViewModel
{
    MauiLib.TestClass tc = new();
    CoolService cs = new();

    [ObservableProperty]
    private string data;

    [RelayCommand]
    public void GetData()
    {
        //Data = tc.GetData();
        Data = $"Get data returned {cs.GetData()}";
    }
}
