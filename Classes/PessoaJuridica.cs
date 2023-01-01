using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloWord.Interfaces;

namespace HelloWord.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public string? RazaoSocial { get; set; }
        public string? Cnpj { get; set; }

        public bool ValidarCnpj(string Cnpj)
        {
            throw new NotImplementedException();
        }
    }
}