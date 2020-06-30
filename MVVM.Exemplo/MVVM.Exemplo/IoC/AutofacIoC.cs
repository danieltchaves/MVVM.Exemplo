using Autofac;
using MVVM.Exemplo.Interfaces;

namespace MVVM.Exemplo.Ioc
{
    public class AutofacIoC : IAutofac
    {
        private IContainer _container;
        private ContainerBuilder _builder;

        public AutofacIoC()
        {
            _builder = new ContainerBuilder();
        }

        public void RegisterType<T>()
        {
            _builder.RegisterType<T>();
        }

        public void RegisterType<T, IT>() where T : IT
        {
            _builder.RegisterType<T>().As<IT>();
        }

        public T Resolve<T>()
        {
            return _container.Resolve<T>();
        }

        public void Build()
        {
            if (_container == null) _container = _builder.Build();
        }
    }
}
