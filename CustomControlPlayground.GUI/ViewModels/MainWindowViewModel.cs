using Prism.Commands;
using Prism.Mvvm;
using System.Diagnostics;

namespace CustomControlPlayground.GUI.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Application Test";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public DelegateCommand TestCommand => new DelegateCommand(()=> 
        {
            Debug.WriteLine("Das ist ein Event");
        });

        public MainWindowViewModel()
        {

        }
    }
}
