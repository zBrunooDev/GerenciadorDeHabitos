using GerenciadorDeHabitos.View;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeHabitos.Controller
{
    public  class HabitosController
    {

        // Método que realiza o cadastro do hábito.
        
        public List<HabitosModel> Habitos = new List<HabitosModel>();
        static int Id = 1;
        public void CadastrarHabito(string nomeHabito)
        {
            Habitos.Add(new HabitosModel
            {
                Id = Id++,
                Nome = nomeHabito,
                Status = false
            });
        }

        // Método que lista os hábitos cadastrados.

        public void ListarHabitos()
        {
            if (Habitos.Count == 0)
            {
                Console.WriteLine("Ainda não há nenhum habito cadastrado.");
            }

            foreach (var habito in Habitos)
            {
                Console.WriteLine($"ID: {habito.Id} - Hábito: {habito.Nome} - Status: {(habito.Status ? "Concluído" : "Pendente")}");
                
            }
            return;
        }

        // Método para Atualizar o status
        public void AtualizarStatus(int id)
        {


            var habito = Habitos.FirstOrDefault(hbt => hbt.Id == id);
            if (habito == null)
            {
                Console.WriteLine("Id não encontrado!");
                return;
            }

            habito.Status = !habito.Status;

            Console.WriteLine($"Status de '{habito.Nome}' alterado para concluido!");

        }

        // Exluir um habito

        public void ExcluirHabito(int id)
        {
            var habito = Habitos.FirstOrDefault(hbt => hbt.Id == id);
            if (habito == null)
            {
                Console.WriteLine("Id não encontrado!");
                return;
            }

            Habitos.Remove(habito);

        }

        public (int qtdConcluido, int qtdPenente, int totalItems, double porcetagem) ResumoDiario()
        {
            int qtdConcluido = Habitos.Count(hbt => hbt.Status == true);
            int qtdPenente = Habitos.Count(hbt => hbt.Status == false);

            int totalItems = Habitos.Count();

            double porcetagem = totalItems == 0 ? 0 : (double)qtdConcluido / totalItems * 100;

            return (qtdConcluido, qtdPenente, totalItems, porcetagem);

        }
    }
}
