using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Builder
{
    interface Ibuilder
    {
        void ConstructorDeMotor();
        void ConstructorDeCarroceria();
        void ConstructorDeLlantas();
    }
}
