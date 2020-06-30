
using System.Threading.Tasks;

namespace MVVM.Exemplo.Interfaces
{
    public interface INavigationService
    {
        void PushMain<IViewModel, IView>();
        Task PushAsync<IViewModel, IView>(); 
        Task PopAsync();
        Task PopToRootAsync();
    }
}
