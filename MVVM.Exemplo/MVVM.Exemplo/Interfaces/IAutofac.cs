using System;
using System.Collections.Generic;
using System.Text;

namespace MVVM.Exemplo.Interfaces
{
    public interface IAutofac
    {
        void RegisterType<T>();
        void RegisterType<T, IT>() where T : IT;
        //void RegisterType<T>(T obj);
        void Build();
        T Resolve<T>();
    }
}
