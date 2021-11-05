using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Builder
{
    interface IMotor
    {

        string Especificaciones();
    }

    class MotorBasico : IMotor
    {
        public string Especificaciones()
        {
            return "Motor de 4 cilindros";
        }
    }

    class MotorGrande : IMotor
    {
        public string Especificaciones()
        {
            return "Motor de 8 cilindros";
        }
    }
}
