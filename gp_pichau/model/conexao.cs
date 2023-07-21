using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gp_pichau.model
{
    internal class conexao
    {
        public static string Conectar()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\renan.lrocha\source\repos\gp_pichau\gp_pichau\model\pecas.mdf;Integrated Security=True";
        }
    }
}
