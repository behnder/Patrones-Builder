using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Builder
{
    interface ILlantas
    {

        string informacion();
    }

    class Llantas12 : ILlantas
    {
        public string informacion()
        {
            return "llantas de 12 pulgadas";
        }
    }

    class LlantasSuper : ILlantas
    {
        public string informacion()
        {
            return "Llantas de 18 pulgadas, rines de aluminio";
        }
    }
}
