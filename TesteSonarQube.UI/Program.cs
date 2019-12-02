using System;

namespace TesteSonarQube.UI
{
    public static class Program
    {
        const string _hello = "hello";
        const string _bye = "bye";

        static void Main(string[] args)
        {
            var agora = DateTime.Now;

            Console.WriteLine(ObterMensagem(agora));
            Console.WriteLine(ObterMensagem2(agora));
            Console.ReadKey();
        }

        public static string ObterMensagem(DateTime agora)
        { 
            return agora.Hour >= 9 && agora.Hour <= 18 ? _hello : _bye; 
        }

        public static string ObterMensagem2(DateTime agora)
        {
            return agora.Hour >= 9 ? _hello : _bye;
        }
    }
}
