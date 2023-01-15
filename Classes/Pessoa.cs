using HelloWord.Interfaces;

namespace HelloWord.Classes
{
    public abstract class Pessoa: IPessoa
    {
      public string? Nome;
      public Endereco? Endereco;
      public float? Rendimento;

        //Implementação da IPessoa
        public abstract float PagarImposto(float rendimento);
    }
}