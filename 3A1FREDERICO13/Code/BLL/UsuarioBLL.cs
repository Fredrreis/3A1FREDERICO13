using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using _3A1FREDERICO13.Code.DTO;
using _3A1FREDERICO13.Code.DAL;
using System.Data;

namespace _3A1FREDERICO13.Code.BLL
{
    class UsuarioBLL
    {
        AcessoBD conexao = new AcessoBD();
        string tabela = "usuario";

        public bool RealizarLogin(UsuarioDTO newDto)
        {
            string sql = $"select * from {tabela} where email = '{newDto.Email}' and senha = '{newDto.Senha}';";
            DataTable dt = conexao.ExecutarConsulta(sql);

            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }
    }
}
