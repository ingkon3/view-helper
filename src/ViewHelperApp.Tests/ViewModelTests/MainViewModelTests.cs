using ViewHelperApp.UI.ViewModels;

namespace ViewHelperApp.Tests.ViewModelTests;

public class MainViewModelTests
{
    [Fact]
    public void Test()
    {
        var viewModel = new MainWindowViewModel();
        Assert.NotNull(viewModel);
    }
}
