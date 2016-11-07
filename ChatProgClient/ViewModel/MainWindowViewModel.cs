using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatProgClient.ViewModel
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region Constructors definition
        /// <summary>
        /// Represents the ViewModel for the MainWindow.xaml View.
        /// </summary>
        public MainWindowViewModel()
        {

        }
        #endregion
    }
}
