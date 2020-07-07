using MVVM.Exemplo.ViewModels.Base;
using MVVM.Exemplo.ViewModels.Interfaces;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVM.Exemplo.ViewModels
{
    public class MainViewModel : BaseViewModel, IMainViewModel
    {
        private ICommand _tapCommand;
        public ICommand TapCommand
        {
            get
            {
                return _tapCommand ?? (_tapCommand = new Command(() =>
                {

                }));
            }
        }
    }
}
