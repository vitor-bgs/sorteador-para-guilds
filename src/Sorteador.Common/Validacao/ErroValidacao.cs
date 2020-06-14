namespace Sorteador.Common.Validacao
{
    public class ErroValidacao
    {
        public ErroValidacao(string campo, string mensagemErro)
        {
            Campo = campo;
            MensagemErro = mensagemErro;
        }
        public string Campo { get; private set; }
        public string MensagemErro { get; private set; }
    }
}