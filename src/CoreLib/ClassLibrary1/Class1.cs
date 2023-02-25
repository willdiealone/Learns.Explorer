using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Explorer.Shared.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {

        #region public_prop

        public string MainDiskName { get; set; }

        #endregion

        #region events

        public event PropertyChangedEventHandler? PropertyChanged;
        #endregion

        #region constr

        public MainViewModel()
        {
            MainDiskName = Environment.SystemDirectory.ToString();
        }

        #endregion

        #region protected_methods

        /// <summary>
        /// Метод который привязывается к свойству и отслеживает изменения
        /// </summary>
        /// <param name="propertyName"></param>
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion


    }
}