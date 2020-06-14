using System.Collections.Generic;

namespace Sorteador.Common.Validacao
{
    public abstract class BaseValidacaoDominio
    {
        public bool ObjetoValido { get; private set; }
        public IList<ErroValidacao> ErrosValidacao { get; private set; }

        protected ResultadoValidacao Validar<T>(T objeto, BaseValidador<T> validador)
        {
            ErrosValidacao = validador.Validar(objeto);
            ObjetoValido = ErrosValidacao.Count == 0;
            return (ObjetoValido ? ResultadoValidacao.Sucesso : ResultadoValidacao.Falha);
        }
    }
}