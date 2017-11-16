using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programa_lojas_Jotão_Eletros
{
    public class Colleague
    {
        private Mediator mediator;
        public Colleague(Mediator mediator)
        {
            this.mediator = mediator;
        }
        public Mediator getMediator()
        {
            return mediator;
        }
    }
}
