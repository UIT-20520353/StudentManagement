using System.Windows;
using System.Windows.Input;

namespace StudentManagement.ViewModels
{
    public class StudentManagementViewModel : BaseViewModel
    {
        private static StudentManagementViewModel s_instance;
        public ICommand cmdLoaded { get; set; }


        public static StudentManagementViewModel Instance
        {
            get { return s_instance ?? (s_instance = new StudentManagementViewModel()); }
            private set => s_instance = value;
        }

        public StudentManagementViewModel()
        {
            Instance = this;

            InitCmd();
        }

        void InitCmd()
        {
            cmdLoaded = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                p.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
            });
        }
    }
}
