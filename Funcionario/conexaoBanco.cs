using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionario
{
    static class conexaoBanco
    {
        //dados do database
        private const string server = "127.0.0.1";
        private const string database = "studying";
        private const string port = "3306";
        private const string user = "root";
        private const string password = "";

        // Database connection string
        public static string ConnectionString = $"server={server}; user={user}; database={database}; port={port}; password={password}";

    }
}
