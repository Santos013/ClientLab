using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloWord.Interfaces;

namespace HelloWord.Classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {
        public string? Cpf;
        public string? DataNascimento;

        public bool ValidarDataNascimento(string dataNasc)
        {
            throw new NotImplementedException();
        }
    }
}