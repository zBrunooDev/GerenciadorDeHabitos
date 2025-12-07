using GerenciadorDeHabitos.Controller;
using GerenciadorDeHabitos.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeHabitos
{
    class Application
    {
        private readonly HabitosController _habitosController;
        private readonly Presentation _presentation;

        public Application()
        {
            _habitosController = new HabitosController();
            _presentation = new Presentation(_habitosController);
        }

        public void Run()
        {
            bool menuRodando = true;

            while (menuRodando)
            {
                int opcao = _presentation.MenuPrincipal();

                switch (opcao)
                {
                    case 1:
                        _presentation.OpcaoUm();
                        break;

                    case 2:
                        _habitosController.ListarHabitos();
                        break;

                    case 3:
                        _presentation.OpcaoTres();
                        break;

                    case 4:
                        _presentation.OpcaoQuatro();
                        break;

                    case 5:
                        _presentation.OpcaoCinco();
                        break;

                    case 0:
                        menuRodando = _presentation.OpcaoZero();
                        break;

                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }
    }
}

