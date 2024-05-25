using System;

namespace ViewHelperApp.Sandbox;

public static class Launcher
{
    [STAThread]
    public static void Main()
    {
        var application = new App();
        application.InitializeComponent();
        application.Run();
    }
}
