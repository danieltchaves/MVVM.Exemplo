using MVVM.Exemplo.Interfaces;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace MVVM.Exemplo.ViewModels.Base
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        public INavigationService Navigation = App.AutofacIoC.Resolve<INavigationService>();
        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
