using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeHabitos.Controller
{
    internal class HabitosController
    {


        // Método que realiza o cadastro do hábito.

        static List<HabitosModel> Habitos = new List<HabitosModel>();
        static int Id = 1;
        public void CadastrarHabito()
        {
            Console.WriteLine("Nome do Hábito");
            string nomeHabito = Console.ReadLine();
            foreach (var model in Habitos)
            {
                Console.WriteLine($"[{model.Id}] = {model.Nome} | {(model.Status ? "Feito!" : "Pendente")}");
            }

            Habitos.Add(new HabitosModel
            {
                Id = Id++,
                Nome = nomeHabito,
                Status = false
            });
        }
    }
}
