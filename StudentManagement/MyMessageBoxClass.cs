using StudentManagement.Views;
using System.Windows;

namespace StudentManagement
{
    public sealed class MyMessageBoxClass
    {
        public static MessageBoxResult Show(string messageBoxText, string caption, MessageBoxButton button, MessageBoxImage icon)
        {
            MyMessageBox msgWindow = new MyMessageBox(messageBoxText, caption, button, icon);
            _ = msgWindow.ShowDialog();

            return msgWindow.Result;
        }

        public static MessageBoxResult Show(string messageBoxText, string caption, MessageBoxButton button)
        {
            MyMessageBox msgWindow = new MyMessageBox(messageBoxText, caption, button);
            _ = msgWindow.ShowDialog();

            return msgWindow.Result;
        }

        public static MessageBoxResult Show(string messageBoxText, string caption)
        {
            MyMessageBox msgWindow = new MyMessageBox(messageBoxText, caption);
            _ = msgWindow.ShowDialog();

            return msgWindow.Result;
        }

        public static MessageBoxResult Show(string messageBoxText)
        {
            MyMessageBox msgWindow = new MyMessageBox(messageBoxText);
            _ = msgWindow.ShowDialog();

            return msgWindow.Result;
        }
    }
}