using DemoMVVM.Model;
using DemoMVVM.view;
using Record_Book_MVVM.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;

namespace DemoMVVM.ViewModel
{
    public class MainViewModel:Window
    {
        public ObservableCollection<User> Users { get; set; }


        public ICommand ShowWindowCommand { get; set; }



        public MainViewModel()
        {
            Users = UserManager.GetUsers();

            ShowWindowCommand = new RelayCommand(ShowWindow, CanShowWindow);

        }

        private bool CanShowWindow(object obj)
        {
            return true;
        }

        private void ShowWindow(object obj)
        {
            var mainWindow = obj as Window;

            AddUser addUserWin = new AddUser();
            addUserWin.Owner = mainWindow;
            addUserWin.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            addUserWin.Show();
        }


        private string myData;
        public string MyData
        {
            get { return this.myData; }
            set
            {
                this.myData = value;;
                Console.WriteLine(this.myData);
            }
        }
    }
}
