
using System.Threading.Tasks;

namespace MVVM.Exemplo.Interfaces
{
    public interface INavigation
    {
        void PushMain<ViewModel, View>();
        Task PushAsync<ViewModel, View>(); 
        Task PopAsync();
        Task PopToRootAsync();
    }
}
