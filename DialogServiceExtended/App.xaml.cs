using System.Windows;
using DialogServiceExtended.Dialogs;
using DialogServiceExtended.Services;
using DialogServiceExtended.Views;
using Prism.Ioc;

namespace DialogServiceExtended
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IDialogServiceExtended, Services.DialogServiceExtended>();
            containerRegistry.RegisterDialog<MyDialog, MyDialogViewModel>();
        }
    }
}
