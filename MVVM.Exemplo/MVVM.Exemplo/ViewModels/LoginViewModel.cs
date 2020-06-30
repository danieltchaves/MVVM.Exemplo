using MVVM.Exemplo.ViewModels.Base;
using MVVM.Exemplo.ViewModels.Interfaces;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVM.Exemplo.ViewModels
{
    public class LoginViewModel : BaseViewModel, ILoginViewModel
    {
        private string _nome;
        public string Nome
        {
            get { return _nome; }
            set
            {
                _nome = value;
                NotifyPropertyChanged();
            }
        }
        private string _sobreNome;
        public string SobreNome
        {
            get { return _sobreNome; }
            set
            {
                _sobreNome = value;
                NotifyPropertyChanged();
            }
        }

        private string _endereco;
        public string Endereco
        {
            get { return _endereco; }
            set
            {
                _endereco = value;
                NotifyPropertyChanged();
            }
        }

        private ICommand _limparCommand;
        public ICommand LimparCommand
        {
            get
            {
                return _limparCommand ?? new Command(() =>
               {
                   Endereco = string.Empty;
               });
            }
            set
            {
                _limparCommand = value;
            }
        }

        public LoginViewModel()
        {
            Nome = "Daniel";
            SobreNome = "Teixeira";
        }
    }
}
