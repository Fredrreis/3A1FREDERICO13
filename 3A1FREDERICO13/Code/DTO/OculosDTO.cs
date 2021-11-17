using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3A1FREDERICO13.Code.DTO
{
    class OculosDTO
    {
        private int _id;
        private string _nome;
        private string _cor;
        private string _tipo;
        private double _preco;

        public int Id { get => _id; set => _id = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Cor { get => _cor; set => _cor = value; }
        public string Tipo { get => _tipo; set => _tipo = value; }
        public double Preco { get => _preco; set => _preco = value; }
    }
}
