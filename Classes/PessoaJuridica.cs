using System.Text.RegularExpressions;
using HelloWord.Interfaces;

namespace HelloWord.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public string? RazaoSocial { get; set; }
        public string? Cnpj { get; set; }


        // Tipos de Cnpj:
        //xx.xxx.xxx/0001-xx => 18 caracteres
        // xxxxxxxx0001xx +> 14 caracteres
        public bool ValidarCnpj(string cnpj)
        {
            if (Regex.IsMatch(cnpj,@"(^(\d{14})|(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})$)"))
            {
                if (cnpj.Length == 18)
                {
                    string SubstringCnpj18 = cnpj.Substring(11, 4);

                    if (SubstringCnpj18 == "0001")
                    {
                        return true;
                    }

                    return false;

                }
                    if(cnpj.Substring(8, 4) == "0001")
                    {
                        return true;
                    }
            }
            
            return false;

        }
    }
}