using System;
using System.Diagnostics;

namespace TesteSonarQube.UI
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            if (args == null)
                throw new ArgumentNullException();

            var simularTeclaUsuario = args != null && args.Length > 0 && ProcurarArgumento(args);

            new VisualizadorMensagem().ExibirMensagem(simularTeclaUsuario, out ConsoleKeyInfo consoleKeyInfo);

            Debug.WriteLine("***");
            Debug.WriteLine($"***\r\n*** A tecla pressionada foi {consoleKeyInfo.KeyChar}\r\n***\r\n");
        }

        private static bool ProcurarArgumento(string[] args)
        {
            foreach (string arg in args)
            {
                if (arg.ToLower().Equals("teste"))
                    return true;
            }

            return false;
        }
    }

    public class VisualizadorMensagem
    {
        const string _hello = "hello";
        const string _bye = "bye";

        public string ExibirMensagem(bool simularTeclaUsuario, out ConsoleKeyInfo tecla)
        {
            var mensagem = ObterMensagem(DateTime.Now);
            Console.WriteLine(mensagem);
            tecla = simularTeclaUsuario ? new ConsoleKeyInfo() : Sair();

            return mensagem;
        }

        private ConsoleKeyInfo Sair()
        {
            return Console.ReadKey();
        }

        public string ObterMensagem(DateTime agora)
        { 
            return agora.Hour < 9 || agora.Hour > 18 ? _bye : _hello; 
        }
    }
}
