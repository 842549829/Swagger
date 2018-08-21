using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddSingleton<ITest, Test>();
            serviceCollection.AddSingleton<ICoty, Coty>();
            ServiceProvider serviceProvider = serviceCollection.BuildServiceProvider();
            ITest serviceHost = serviceProvider.GetRequiredService<ITest>();
            serviceHost.Add();
        }
    }


    public interface ITest
    {
        void Add();
    }

    public class Test : ITest
    {
        private int ii = 0;

        public Test(ICoty c) :this(c.GetNumber())
        {
        }

        public Test(int i)
        {
            ii = i;
        }

        public void Add()
        {
            Console.WriteLine(ii + 1);
        }
    }

    public interface ICoty : IDisposable
    {
        int GetNumber();
    }

    public class Coty: ICoty
    {
        public int GetNumber()
        {
            return 20;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
