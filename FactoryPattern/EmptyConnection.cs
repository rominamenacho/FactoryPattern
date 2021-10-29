using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class EmptyConnection : IConnection
    {
        void IConnection.Connect()
        {
            Console.WriteLine("No se especifico proveedor");
        }

        void IConnection.Disconnect()
        {
            Console.WriteLine("No se especifico proveedor");
        }
    }
}
