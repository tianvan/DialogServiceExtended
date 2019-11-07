using System;
using Prism.Services.Dialogs;

namespace DialogServiceExtended.Dialogs
{
    public class MyDialogViewModel : IDialogAware
    {
        public string Title { get; }

        public event Action<IDialogResult> RequestClose;

        public bool CanCloseDialog()
        {
            return true;
        }

        public void OnDialogClosed()
        {

        }

        public void OnDialogOpened(IDialogParameters parameters)
        {
        }
    }
}
