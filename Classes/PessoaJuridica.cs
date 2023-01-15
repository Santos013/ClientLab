using System.Text.RegularExpressions;
using HelloWord.Interfaces;

namespace HelloWord.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public string? RazaoSocial { get; set; }
        public string? Cnpj { get; set; }



        // Validação Cnpj:
        //xx.xxx.xxx/0001-xx => 18 caracteres
        // xxxxxxxx0001xx +> 14 caracteres
        public bool ValidarCnpj(string cnpj)
        {
            if (Regex.IsMatch(cnpj, @"(^(\d{14})|(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})$)"))
            {
                if (cnpj.Length == 18)
                {
                    if (cnpj.Substring(11, 4) == "0001")
                    {
                        return true;
                    }
                }
                else if (cnpj.Length == 14)
                {
                    if (cnpj.Substring(8, 4) == "0001")
                    {
                        return true;
                    }
                }

            }

            return false;
        }

        // Para rendimentos até R$5.000,00- desconto de 6%
        // Para rendimentos entre R$5.001,00 e R$10.000,00 - desconto de 8%
        // Para rendimentos acima de R$10.000,01 - desconto de 10%        
        public override float PagarImposto(float rendimento)
        {
            if (rendimento <= 5000)
            {
                return rendimento - ((rendimento / 100) * 6);
            }
            else if (rendimento <= 10000)
            {
                return rendimento - ((rendimento / 100) * 8);
            }
            else
            {
                return rendimento - ((rendimento / 100) * 10);
            }
        }
    }

}