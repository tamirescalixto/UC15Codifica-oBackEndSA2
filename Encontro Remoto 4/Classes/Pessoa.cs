using Encontro_Remoto_4.Interfaces;

namespace Encontro_Remoto_4.Classes

{
    public abstract class Pessoa : IPessoa
    {
        public string? nome { get; set; }

        public float rendimento { get; set; }

        public Endereco? endereco { get; set; }

        public abstract float CalcularImposto(float rendimento);
       
    }
}