using System;
using Sorteador.Common.Validacao;

namespace Sorteador.Common.Modelos
{
    public abstract class Entidade : BaseValidacaoDominio
    {
        public Guid Id { get; private set; }

        public Entidade()
        {
            if(Id == Guid.Empty)
                Id = Guid.NewGuid();
        }
    }
}