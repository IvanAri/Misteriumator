using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using MisteriumUtils;

namespace MisteriumUtils
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public MainWindowViewModel()
        {
            TestList = new List<DataBaseObj>
            {
                TestObject,
                new DataBaseObj
                {
                    Name = "Магистр сосистр",
                    ObjType = "Class",
                    PropertyList = new List<Property>
                    {
                        new Property
                        {
                            NameAbility = "Чёт там на жесты",
                            PropertyDescription = new List<AbilityLevelProperty>
                            {
                                new AbilityLevelProperty
                                {
                                    Description = "",
                                    Level = 0
                                },
                                new AbilityLevelProperty
                                {
                                    Description = "",
                                    Level = 1
                                },
                                new AbilityLevelProperty
                                {
                                    Description = "",
                                    Level = 2
                                },
                            }
                        },
                        new Property
                        {
                            NameAbility = "Высшая магия",
                            PropertyDescription = new List<AbilityLevelProperty>
                            {
                                new AbilityLevelProperty
                                {
                                    Description = "",
                                    Level = 0
                                },
                                new AbilityLevelProperty
                                {
                                    Description = "",
                                    Level = 1
                                },
                                new AbilityLevelProperty
                                {
                                    Description = "",
                                    Level = 2
                                },
                            }
                        },
                    }
                },
                TestObject,
                TestObject,
            };
        }

        public List<DataBaseObj> TestList { get; set; }

        public DataBaseObj SelectedItem { get; set; }

        public DataBaseObj TestObject { get; set; } = new DataBaseObj
        {
            Name = "Класс Ассасина Йоу",
            ObjType = "Class",
            PropertyList = new List<Property>
            {
                new Property
                {
                    NameAbility = "Дух скрытности",
                    PropertyDescription = new List<AbilityLevelProperty>
                    {
                        new AbilityLevelProperty
                        {
                            Description = "",
                            Level = 0
                        },
                        new AbilityLevelProperty
                        {
                            Description = "",
                            Level = 1
                        },
                        new AbilityLevelProperty
                        {
                            Description = "",
                            Level = 2
                        },
                    }
                },
                new Property
                {
                    NameAbility = "Проворность лососина",
                    PropertyDescription = new List<AbilityLevelProperty>
                    {
                        new AbilityLevelProperty
                        {
                            Description = "",
                            Level = 0
                        },
                        new AbilityLevelProperty
                        {
                            Description = "",
                            Level = 1
                        },
                        new AbilityLevelProperty
                        {
                            Description = "",
                            Level = 2
                        },
                    }
                },
            }
        };

        public string TestString { get; set; } = "lol";
        

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
