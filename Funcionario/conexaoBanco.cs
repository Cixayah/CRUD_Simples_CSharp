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
        private const string servidor = "";
        private const string bancoDados = "";
        private const string port = "";
        private const string usuario = "";
        private const string senha = "";

        //String de conexão com o database
        static public string connectDb = $"server={servidor}; user={usuario}; database={bancoDados}; port={port};password={senha}";

    }
}
