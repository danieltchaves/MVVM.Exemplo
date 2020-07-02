using MVVM.Exemplo.View.Interfaces;
using MVVM.Exemplo.ViewModels.Base;
using MVVM.Exemplo.ViewModels.Interfaces;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVM.Exemplo.ViewModels
{
    public class LoginViewModel : BaseViewModel, ILoginViewModel
    {
        private string _usuario;
        public string Usuario
        {
            get { return _usuario; }
            set
            {
                _usuario = value;
                NotifyPropertyChanged();
            }
        }

        private string _senha;
        public string Senha
        {
            get { return _senha; }
            set
            {
                _senha = value;
                NotifyPropertyChanged();
            }
        }

        private ICommand _entrarCommand;
        public ICommand EntrarCommand
        {
            get
            {
                return _entrarCommand ?? (_entrarCommand = new Command(() =>
               { 
                   Navigation.PushAsync<IMainViewModel, IMainPage>();
               }));
            }
        }

        private ICommand _registrarCommand;
        public ICommand RegistrarCommand
        {
            get
            {
                return _registrarCommand ?? (_registrarCommand = new Command(() =>
                {
                    Navigation.PushAsync<ICadastroUsuarioViewModel, ICadastroUsuarioPage>();
                }));
            }
        }
    }
}
