using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ChatProgClient.ViewModel
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region Members definition
        private ICommand _submitCommand;
        public ICommand SubmitCommand
        {
            get
            {
                if (_submitCommand == null)
                {
                    _submitCommand = new AsyncDelegateCommand(text => { this.EvaluateQuery(text.ToString()); });
                }
                return _submitCommand;
            }
        }
        #endregion

        #region Constructors definition
        /// <summary>
        /// Represents the ViewModel for the MainWindow.xaml View.
        /// </summary>
        public MainWindowViewModel()
        {

        }
        #endregion

        #region Methods definition
        private void EvaluateQuery(string text)
        {

        }

        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            // Uses null-conditional operator to invoke the event handler if it is not null.
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));

            return;
        }
        #endregion
    }
}
