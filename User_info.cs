using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Portaria
{
    class User_info
    {
        public static string usuario_logado;
        public static List<string> anotacao = new List<string>();        
    }

    class Condominio
    {
        //recebe o codigo do condominio selecionado
        public static string codigo;
        //recebe se tem um condominio selecionado
        public static Boolean condSelecionado;
        public static string condTipo;
        public static Boolean conectado;
        //recebe o nome do condominio selecionado
        public static string condominio;
        //recebe a query sql que sera usada 
        public static string comando;
        //atualiza o grid de condominios
        public static Boolean attGrid;
        //obtem a linha selecionada
        public static int linhaSelecionada;
    }

    class Grid
    {
        public static Boolean attGrid;
        public static int linhaSelecionada;
    }


}
