using MVVM.Exemplo.ViewModels.Base;
using MVVM.Exemplo.ViewModels.Interfaces;
using System.Reflection;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVM.Exemplo.ViewModels
{
    public class CadastroUsuarioViewModel : BaseViewModel, ICadastroUsuarioViewModel
    {
        private string _titulo;
        public string Titulo
        {
            get { return _titulo; }
            set 
            {
                _titulo = value;
                NotifyPropertyChanged();
            }
        }

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

        private string _sobrenome;
        public string Sobrenome
        {
            get { return _sobrenome; }
            set
            {
                _sobrenome = value;
                NotifyPropertyChanged();
            }
        }

        private string _cep;
        public string Cep
        {
            get { return _cep; }
            set 
            {
                _cep = value;
                NotifyPropertyChanged();
            }
        }

        private ICommand _limparCepCommand;
        public ICommand LimparCepCommand
        {
            get
            {
                return _limparCepCommand ?? (_limparCepCommand = new Command(() =>
                {
                    Cep = "";
                }));
            }
        }

        public CadastroUsuarioViewModel()
        {
            Titulo = "Cadastro";
        }
    }
}
