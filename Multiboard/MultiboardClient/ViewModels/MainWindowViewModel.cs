using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using Microsoft.Toolkit.Mvvm.Input;

namespace MultiboardClient.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            TestBoolCommand = new RelayCommand(SetTestBool);
            ProjectList = new ObservableCollection<ProjectModel>();
            ProjectList.Add(new ProjectModel
            { 
                ID = -1,
                Name = "Test Project", 
                OwnerID = 0, 
                MemberIDs = null, 
                TableIDs = null, 
                CreationDate = DateTime.Today 
            });
            ProjectList.Add(new ProjectModel
            {
                ID = -2,
                Name = "Test Project 2",
                OwnerID = 0,
                MemberIDs = null,
                TableIDs = null,
                CreationDate = DateTime.Today
            });
        }

        private bool testBool;

        public bool TestBool
        {
            get { return testBool; }
            set {
                testBool = value;
                NotifyPropertyChanged("TestBool");
            }
        }

        private string testText;

        public string TestText
        {
            get => testText;
            set {
                testText = value;
                NotifyPropertyChanged("TestText");
            }
        }

        private ObservableCollection<ProjectModel> projectList;

        public ObservableCollection<ProjectModel> ProjectList
        {
            get => projectList;
            set
            {
                projectList = value;
                NotifyPropertyChanged("ProjectList");
            }
        }

        public ICommand TestBoolCommand { get; }

        private void SetTestBool()
        {
            TestBool = !TestBool;

            MessageBox.Show(testText);
        }
    }
}
