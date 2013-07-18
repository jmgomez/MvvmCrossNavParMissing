using System.Windows.Input;
using Cirrious.MvvmCross.ViewModels;

namespace PortableClassLibrary2.ViewModels
{
    public class FirstViewModel 
		: MvxViewModel
    {
		private string _hello = "Hello MvvmCross";
        public string Hello
		{ 
			get { return _hello; }
			set { _hello = value; RaisePropertyChanged(() => Hello); }
		}

        public ICommand GoToSecondCommand { get { return new MvxCommand(GoToSecond); } }

        private void GoToSecond(){
            ShowViewModel<SecondViewModel>(new { param = "hello" });
        }
    }
}
