using System.Linq;
using System.Windows;

using Prism.Services.Dialogs;

namespace DialogServiceExtended.Services
{
    public class DialogServiceExtended : DialogService, IDialogServiceExtended
    {
        public DialogServiceExtended(Prism.Ioc.IContainerExtension containerExtension) : base(containerExtension)
        {
        }

        public void Close()
        {
            Application.Current.Windows.OfType<IDialogWindow>().LastOrDefault()?.Close();
        }
    }
}
