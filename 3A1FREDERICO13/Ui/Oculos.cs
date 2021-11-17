using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using _3A1FREDERICO13.Code.DTO;
using _3A1FREDERICO13.Code.BLL;

namespace _3A1FREDERICO13.Ui
{
    public partial class Oculos : Form
    {
        OculosBLL newbll = new OculosBLL();
        OculosDTO newdto = new OculosDTO();
        public Oculos()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            newdto.Id = int.Parse(txtID.Text);
            newdto.Nome = txtNome.Text;
            newdto.Cor = txtCor.Text;
            newdto.Tipo = txtTipo.Text;
            newdto.Preco = double.Parse(txtPreco.Text);

            newbll.Inserir(newdto);

            MessageBox.Show("Cadastrado com sucesso!", "Óculos", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtID.Clear();
            txtNome.Clear();
            txtCor.Clear();
            txtTipo.Clear();
            txtPreco.Clear();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            newdto.Id = int.Parse(txtID.Text);
            newdto.Nome = txtNome.Text;
            newdto.Cor = txtCor.Text;
            newdto.Tipo = txtTipo.Text;
            newdto.Preco = double.Parse(txtPreco.Text);

            newbll.Editar(newdto);

            MessageBox.Show("Alterado com sucesso!", "Óculos", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dtgListarOculos.DataSource = newbll.Listar();

            txtID.Clear();
            txtNome.Clear();
            txtCor.Clear();
            txtTipo.Clear();
            txtPreco.Clear();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            newdto.Id = int.Parse(txtID.Text);

            newbll.Excluir(newdto);

            MessageBox.Show("Excluído com sucesso!", "Óculos", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dtgListarOculos.DataSource = newbll.Listar();

            txtID.Clear();
            txtNome.Clear();
            txtCor.Clear();
            txtTipo.Clear();
            txtPreco.Clear();
        }

        private void dtgListarOculos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dtgListarOculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void dtgListarOculos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void dtgListarOculos_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dtgListarOculos.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNome.Text = dtgListarOculos.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtCor.Text = dtgListarOculos.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtTipo.Text = dtgListarOculos.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtPreco.Text = dtgListarOculos.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void Oculos_Load(object sender, EventArgs e)
        {
            dtgListarOculos.DataSource = newbll.Listar();
        }
    }
}
