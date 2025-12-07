using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using GerenciadorDeHabitos.Controller;
using GerenciadorDeHabitos.View;

namespace GerenciadorDeHabitos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var app = new Application();
            app.Run();
        }
    }
}
