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
                if(anos >= 18)
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
    }
}