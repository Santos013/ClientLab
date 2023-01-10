using HelloWord.Interfaces;

namespace HelloWord.Classes
{
    public class Pessoa: IPessoa
    {
      public string? Nome;
      public Endereco? Endereco;
      public float? Rendimento;

        //Implementação da IPessoa
        public float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }
    }
}