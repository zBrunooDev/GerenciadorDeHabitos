using GerenciadorDeHabitos;
using GerenciadorDeHabitos.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop
{
    public partial class FmrCadastrarHabito: Form
    {

        private readonly HabitosController _controller;
        public FmrCadastrarHabito()
        {
            InitializeComponent();
            _controller = new HabitosController();
        }

        private void btnCadastrarHabito_Click(object sender, EventArgs e)
        {
            try
            {
                HabitosModel habitos = new HabitosModel();
                habitos.Id = habitos.Id++;
                habitos.Status = false;
                habitos.Nome = txtCadastrarHabito.Text;

                _controller.CadastrarHabito(txtCadastrarHabito.Text);

                MessageBox.Show("Cadastro concluido com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
