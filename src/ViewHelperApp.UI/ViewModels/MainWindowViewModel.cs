using System.Windows.Input;
using Autodesk.Revit.UI;
using ViewHelperApp.UI.ViewModels.Base;
using TaskDialog = Autodesk.Revit.UI.TaskDialog;

namespace ViewHelperApp.UI.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public MainWindowViewModel()
    {
        _title += _version;
        SomeText = "Hello!";
    }

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
        get => _status;
        set => Set(ref _status, value);
    }

    /// <summary>Title for MainWindow</summary>
    private string _title = "VIEW HELPER";

    public string Title
    {
        get =>_title;
        set => Set(ref _title, value);
    }

    private string _version = "1.0.0";

    public string Version
    {
        get => _version;
        set => Set(ref _version, value);
    }


    //----------------------------------Methods-----------------------------------



    //----------------------------------Events-----------------------------------

    #region  Close, Hide, Show events for window

    public event EventHandler CloseRequest;
    private void RaiseCloseRequest()
    {
        CloseRequest?.Invoke(this, EventArgs.Empty);
    }
    public event EventHandler HideRequest;
    private void RaiseHideRequest()
    {
        HideRequest?.Invoke(this, EventArgs.Empty);
    }
    public event EventHandler ShowRequest;
    private void RaiseShowRequest()
    {
        ShowRequest?.Invoke(this, EventArgs.Empty);
    }


    
    #endregion

    #region CloseAplication

    public ICommand CloseApplicationCommand { get; }
    private bool CanCloseApplicationCommandExecute(object p) => true;
    private void OnCloseApplicationCommandExecuted(object p)
    {
        //TODO: command for close application
    }

    #endregion

    //----------------------------------Commands----------------------------------

}
