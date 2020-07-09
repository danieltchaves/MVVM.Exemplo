using MVVM.Exemplo.Models;
using MVVM.Exemplo.ViewModels.Interfaces;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVM.Exemplo.ViewModels
{
    public class MainViewModel : BaseViewModel, IMainViewModel
    {
        public ObservableCollection<Usuario> Usuarios { get; set; }

        private ICommand _addCommand;
        public ICommand AddCommand
        {
            get
            {
                return _addCommand ?? (_addCommand = new Command(() =>
                {
                    Usuarios.Add(new Usuario() { Nome = "Usuario", SobreNome = "Teste"});
                }));
            }
        }

        public MainViewModel()
        {
            Usuarios = new ObservableCollection<Usuario>();
        }
    }
}
