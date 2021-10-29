using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class ConnectionFactory
    {

        public IConnection GetConnection(string engine) {

            switch (engine)
            {
                case "MYSQL":      return new ConnectionMySQL();
                case "ORACLE":     return new ConnectionOracle();
                case "POSTGRESQL": return new ConnectionPostgreSQL();
                case "SQLSERVER":  return new ConnectionQSLServer();
                default:           return new EmptyConnection();                  
            }
        
        
        }
    }
}
