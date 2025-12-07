using GerenciadorDeHabitos.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeHabitos.View
{
    public class Presentation 
    {
        private HabitosController _controller;

        public Presentation(HabitosController controller)
        {
            _controller = controller;
        }

        public int MenuPrincipal()
        {
            Console.WriteLine("Seja bem-vindo ao Gerenciador de Hábitos!");
            Console.WriteLine($"\nDigite a opção que deseja efetuar:\n ");

            Console.WriteLine("\tOpção 1 - Cadastrar Hábito.");
            Console.WriteLine("\tOpção 2 - Listar os Hábitos.");
            Console.WriteLine("\tOpção 3 - Marcar como concluído.");
            Console.WriteLine("\tOpção 4 - Excluir algum hábito.");
            Console.WriteLine("\tOpção 5 - Resumo diário.");
            Console.WriteLine("\tOpção 0 - Sair do programa.");
            string entrada = Console.ReadLine();

            if (int.TryParse(entrada, out int opcao))
            {
                return opcao;
            }
            else
            {
                Console.WriteLine("\nDigite o valor apenas com numeros!\n");
            }
            return opcao;

        }

        public void OpcaoUm()
        {
            bool rodando = true;
            while (rodando)
            {
                try
                {
                    Console.WriteLine("\nDigite o nome do hábito:");
                    string nomeHabito = Console.ReadLine();
                    _controller.CadastrarHabito(nomeHabito);
                    Console.WriteLine("\nDigite a opção 1 para continuar caso não, digite 0.\n");
                    int opcao = int.Parse(Console.ReadLine());
                    if (opcao == 0)
                    {
                        rodando = false;
                    }
                }

                catch
                {
                    Console.WriteLine("\nDigite uma entrada de número.\n");
                }
            }
        }

        // Opcao 2 já direto da controller

        public void OpcaoTres()
        {
            try
            {
                Console.WriteLine("\nDigite o Id do Hábito para atualizar:\n");
                int idAtt = int.Parse(Console.ReadLine());
                _controller.AtualizarStatus(idAtt);
            }
            catch
            {
                Console.WriteLine("\nDigite uma entrada de número.\n");
            }

        }

        public void OpcaoQuatro()
        {
            Console.WriteLine("\nDigite o Id do Hábito para excluí-lo:\n");
            int idExc = int.Parse(Console.ReadLine());
            _controller.ExcluirHabito(idExc);
            Console.WriteLine($"\nO item foi removido da lista.\n");
        }

        public bool OpcaoZero()
        {
            Console.WriteLine("Saindo do programa!");
            Console.WriteLine("Até amanhã!");
            return false;
        }

        public void OpcaoCinco()
        {
            var resumo = _controller.ResumoDiario();

            Console.WriteLine("Resumo diário:\n");
            Console.WriteLine($"Total de hábitos: {resumo.totalItems}");
            Console.WriteLine($"Concluídos: {resumo.qtdConcluido}");
            Console.WriteLine($"Pendentes: {resumo.qtdPenente}");
            Console.WriteLine($"Percentual concluído: {resumo.porcetagem:F2}%");

        }
      
    }
}
