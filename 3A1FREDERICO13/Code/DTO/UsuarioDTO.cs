using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3A1FREDERICO13.Code.DTO
{
    class UsuarioDTO
    {
        private int _idUsuario;
        private string _email;
        private string _senha;

        public int IdUsuario { get => _idUsuario; set => _idUsuario = value; }
        public string Email { get => _email; set => _email = value; }
        public string Senha { get => _senha; set => _senha = value; }
    }
}
