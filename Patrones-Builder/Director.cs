using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Builder
{
    class Director
    {

        Ibuilder pConstructor;

        public Director(Ibuilder pConstructor)
        {
            this.pConstructor = pConstructor;
        }

        public void Construye()
        {
            pConstructor.ConstructorDeMotor();
            pConstructor.ConstructorDeLlantas();
            pConstructor.ConstructorDeCarroceria();
        }

        public void CambiarBuilder(Ibuilder pConstructor)
        {
            this.pConstructor = pConstructor;
        }

    }
}
