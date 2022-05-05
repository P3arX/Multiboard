namespace MultiboardClient.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private bool testBool;

        public bool TestBool
        {
            get { return testBool; }
            set {
                testBool = value;
                NofityPropertyChanged("TestBool");
            }
        }
    }
}
