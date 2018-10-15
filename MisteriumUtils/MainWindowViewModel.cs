using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace MisteriumUtils
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public MainWindowViewModel()
        {
            TestObject = new List<TestClass>
            {
                new TestClass
                {
                    TestString1 = "lol11",
                    TestString2 = "lol12"
                },
                new TestClass
                {
                    TestString1 = "lol21",
                    TestString2 = "lol22"
                }
            };
        }

        public string TestString { get; set; } = "lol";

        public List<TestClass> TestObject { get; set; }


        public class TestClass
        {
            public string TestString1 { get; set; }
            public string TestString2 { get; set; }
        }


        #region Команды



        public class Command : ICommand
        {
            private readonly Action _execute;

            /// <summary>
            /// https://stackoverflow.com/a/7353704/1134449
            /// </summary>
            public event EventHandler CanExecuteChanged
            {
                add { CommandManager.RequerySuggested += value; }
                remove { CommandManager.RequerySuggested -= value; }
            }

            public Command(Action execute)
            {
                _execute = execute;
            }

            public bool CanExecute(object parameter)
            {
                return true;
            }

            public void Execute(object parameter)
            {
                _execute();
            }
        }

        protected void OnPropertyChanged(string p)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(p));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
    }
}
