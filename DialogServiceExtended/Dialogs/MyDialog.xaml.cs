using System;
using System.Windows.Controls;
using Prism.Services.Dialogs;

namespace DialogServiceExtended.Dialogs
{
    /// <summary>
    /// Interaction logic for MyDialog
    /// </summary>
    public partial class MyDialog : UserControl, IDialogAware
    {
        public MyDialog()
        {
            InitializeComponent();
        }

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
