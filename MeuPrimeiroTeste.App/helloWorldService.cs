using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeuPrimeiroTeste.App
{
    public class helloWorldService
    {
        public string GerarSaudacao(string? nome)
        {
            if (string.IsNullOrEmpty(nome))
            {
                return "Hello, World!";
            }
            else
            {
                return $"Hello, {nome}!";
            }
        }
    }
}