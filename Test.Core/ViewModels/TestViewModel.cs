using Cirrious.MvvmCross.ViewModels;

namespace Test.Core.ViewModels
{
    public class TestViewModel : MvxViewModel
    {
        private string _myProperty1 = "This is ViewModel1";

        public string MyProperty1
        {
            get { return _myProperty1; }
            set { _myProperty1 = value; RaisePropertyChanged(() => MyProperty1); }
        }
    }
}
