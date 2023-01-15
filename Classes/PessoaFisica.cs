using HelloWord.Interfaces;

namespace HelloWord.Classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {
        public string? Cpf;
        public string? DataNascimento;

        public bool ValidarDataNascimento(string dataNasc)
        {
            //("02/10/1993")
            //("1993", "10", "02") - (AAAA, MM, DD)
            DateTime dataConvertida;

            if (DateTime.TryParse(dataNasc, out dataConvertida))
            {
                DateTime dataAtual = DateTime.Today;
                double anos = (dataAtual - dataConvertida).TotalDays / 365;

                //Console.WriteLine($"String Convertida em Datetime: {dataConvertida}");
                //Console.WriteLine($"Anos: {anos}");
                if (anos >= 18)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }

            return false;
        }

        // Para rendimentos até R$1.500,00 - isento (desconto 0)
        // Para rendimentos entre R$1.501,00 e R$5.000,00 - desconto de 3%
        // Para rendimentos acima de R$5.000,01 - desconto de 5%
        public override float PagarImposto(float rendimento)
        {
            if (rendimento <= 1500)
            {
                return rendimento;
            }
            else if (rendimento <= 5000)
            {
                return rendimento - ((rendimento / 100) * 3);//3%
            }
            else
            {
                return rendimento - ((rendimento / 100) * 5);//5%
            }
        }
    }


}