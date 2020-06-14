using System.Collections.Generic;

namespace Sorteador.Common.Validacao
{
    public abstract class BaseValidador<T>
    {
        public abstract IList<ErroValidacao> Validar(T objeto);
    }
}