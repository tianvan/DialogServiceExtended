using System;
using System.Threading.Tasks;
using DialogServiceExtended.Dialogs;
using DialogServiceExtended.Services;

using Prism.Commands;
using Prism.Mvvm;

namespace DialogServiceExtended.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Application";

        private readonly IDialogServiceExtended _dialogServiceExtended;
        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        public MainWindowViewModel(IDialogServiceExtended dialogServiceExtended)
        {
            _dialogServiceExtended = dialogServiceExtended;
        }

        private DelegateCommand _testDialogCommand;
        public DelegateCommand TestDialogCommand =>
            _testDialogCommand ?? (_testDialogCommand = new DelegateCommand(ExecuteTestDialogCommand));

        private async void ExecuteTestDialogCommand()
        {
            _dialogServiceExtended.Show(nameof(MyDialog), default, default);

            await Task.Delay(TimeSpan.FromSeconds(10));

            _dialogServiceExtended.Close();
        }
    }
}
