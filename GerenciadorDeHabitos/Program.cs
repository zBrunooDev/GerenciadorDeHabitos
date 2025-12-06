using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GerenciadorDeHabitos.Controller;

namespace GerenciadorDeHabitos
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            HabitosController cadastroHabito = new HabitosController();

            cadastroHabito.CadastrarHabito();

        }

    }
}
