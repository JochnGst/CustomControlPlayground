using Prism.Commands;
using Prism.Mvvm;
using System.Diagnostics;

namespace CustomControlPlayground.GUI.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        DelegateCommand TestCommand { get; set; } = new DelegateCommand(()=> 
        {
            Debug.WriteLine("Das ist ein Event");
        });

        public MainWindowViewModel()
        {

        }
    }
}
