using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ConnectionFactory fabric = new ConnectionFactory();

            IConnection oracle = fabric.GetConnection("ORACLE");
            oracle.Connect();
            oracle.Disconnect();

            IConnection mysql = fabric.GetConnection("MYSQL");
            mysql.Connect();
            mysql.Disconnect();

            IConnection postgre = fabric.GetConnection("POSTGRESQL");
            postgre.Connect();
            postgre.Disconnect();

            IConnection sqlServer = fabric.GetConnection("SQLSERVER");
            sqlServer.Connect();
            sqlServer.Disconnect();

            IConnection random = fabric.GetConnection("MUMI");
            random.Connect();
            random.Disconnect();

            Console.ReadKey();
        }
    }
}
