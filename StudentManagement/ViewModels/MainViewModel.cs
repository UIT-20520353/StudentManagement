using System.Windows;
using System.Windows.Input;
using StudentManagement.Views;
using System.Windows.Controls;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace StudentManagement.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        #region Properties

        private static MainViewModel s_instance;
        public ICommand cmdLoaded { get; set; }
        public ICommand cmdCloseWindow { get; set; }
        public ICommand cmdMaximizeWindow { get; set; }
        public ICommand cmdMinimizeWindow { get; set; }
        public ICommand cmdButtonAdd { get; set; }
        public ICommand cmdStudentManagement { get; set; }
        public ICommand cmdMouseMoveWindow { get; set; }

        #endregion

        public static MainViewModel Instance
        {
            get { return s_instance ?? (s_instance = new MainViewModel()); }
            private set => s_instance = value; 
        }

        public MainViewModel()
        {
            Instance = this;

            InitCmd();
        }

        private void InitCmd()
        {
            cmdLoaded = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                p.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;

            });

            cmdCloseWindow = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                Application.Current.Shutdown();
            });

            cmdMaximizeWindow = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                if (p.WindowState == WindowState.Maximized)
                    p.WindowState = WindowState.Normal;
                else
                    p.WindowState = WindowState.Maximized;
            });

            cmdMinimizeWindow = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                if (p.WindowState == WindowState.Minimized)
                    p.WindowState = WindowState.Normal;
                else
                    p.WindowState = WindowState.Minimized;
            });

            cmdButtonAdd = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                MyMessageBoxClass.Show("Bạn vừa thêm tài khoản", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
            });

            cmdMouseMoveWindow = new RelayCommand<Window>((p) => { return true; }, (p) => { p.DragMove(); });

            cmdStudentManagement = new RelayCommand<object>((p) => { return true; }, (p) => { StudentManagementView wd = new StudentManagementView(); wd.ShowDialog(); });
        }
    }
}