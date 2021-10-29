using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
   abstract class GenericConnection
    {
        protected string Username { get; set; }
        protected string Password { get; set; }
        protected string Host { get; set; }
        protected string Port { get; set; }

        public GenericConnection()
        {
            this.Username = "";
            this.Password = "";
            this.Host = "";
            this.Port = "";
        }
    }
}
