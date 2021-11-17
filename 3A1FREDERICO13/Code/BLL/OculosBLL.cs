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
    class OculosBLL
    {
        AcessoBD conexao = new AcessoBD();
        string tabela = "oculos";
        public void Inserir(OculosDTO newDto)
        {
            string inserir = $"insert into {tabela} values('{newDto.Id}', '{newDto.Nome}', '{newDto.Cor}', '{newDto.Tipo}', '{newDto.Preco}');";
            conexao.ExecutarComando(inserir);
        }

        public DataTable Listar()
        {
            string sql = $"select * from {tabela} order by idOculos;";
            return conexao.ExecutarConsulta(sql);
        }

        public void Editar(OculosDTO newDto)
        {
            string editar = $"update {tabela} set nome = '{newDto.Nome}', cor = '{newDto.Cor}', tipo = '{newDto.Tipo}', preco = '{newDto.Preco}' where idOculos = '{newDto.Id}';";
            conexao.ExecutarComando(editar);
        }

        public void Excluir(OculosDTO newDto)
        {
            string excluir = $"delete from {tabela} where idOculos = '{newDto.Id}';";
            conexao.ExecutarConsulta(excluir);
        }
    }
}
