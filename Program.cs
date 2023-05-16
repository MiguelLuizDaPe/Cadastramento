using System;

namespace Cadastramento // Note: actual namespace depends on the project name.
{
    internal class Program{
        static void Main(string[] args){
            Cliente c = new Cliente(1, "pedro", "aaa", "sss", "ddd");
            Console.WriteLine(c.nome);
        }
    }
}