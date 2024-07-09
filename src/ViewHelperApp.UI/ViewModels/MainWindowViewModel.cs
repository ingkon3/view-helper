using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ViewHelperApp.UI.ViewModels;

public class MainWindowViewModel : INotifyPropertyChanged
{
    private string _someText;
    public string SomeText
    {
        get => _someText;
        set
        {
            if (_someText == value)
                return;

            _someText = value;
            OnPropertyChanged();
        }
    }

    /// <summary>Status for Status Bar </summary>
    private string _status = "Done!";

    public string Status
    {
        get { return _status; }
        set
        {
            _status = value;
            OnPropertyChanged();
        }
    }


    public MainWindowViewModel()
    {
        SomeText = "Hello!";
    }

    #region PropertyChanged

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    #endregion
}
