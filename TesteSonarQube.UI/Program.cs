using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace TesteSonarQube.UI
{
    public static class Program
    {
        public static string Foo { get; set; }

        public static void Main(string[] args)
        {
            List<int> numeros = new List<int>();

            foreach (string item in args)
            {
                numeros.Add(Convert.ToInt32(item));
            }

            var resultado = new Calculadora().Somar(numeros);

            Debug.WriteLine(resultado);

            resultado += 1;

            Debug.WriteLine(resultado);

            Teste.Foo = "bar";

            Debug.WriteLine(Teste.Foo);

            var calculadoraString = new Calculadora().ToString();
        }
    }

    public class Calculadora
    {
        public static string Foo { get; set; }
        public static string Xyz { get; set; }
        public static string Abc { get; set; }
        public static string Qwe { get; set; }
        public static string Zxc { get; set; }
        public static string Oiu { get; set; }
        public static string Lkj { get; set; }
        public static string Mnb { get; set; }
        public static string Abc1 { get; set; }
        public static string Qwe2 { get; set; }
        public static string Zxc3 { get; set; }
        public static string Oiu4 { get; set; }
        public static string Lkj5 { get; set; }
        public static string Mnb6 { get; set; }

        public int Somar(List<int> numeros)
        {
            int a = 0;
            foreach (int item in numeros)
            {
                a += item;
            }

            return a;
        }

        public override string ToString()
        {
            return "";
        }
    }
}
