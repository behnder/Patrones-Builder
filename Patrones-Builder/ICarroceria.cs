using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Builder
{
    interface ICarroceria
    {
        string caracteristicas();
    }

    class CarroceriaBasica : ICarroceria
    {
        public string caracteristicas()
        {
            return "Carroceria de metal";
        }

    }

    class CarroceriaEspecial : ICarroceria
    {
        public string caracteristicas()
        {
            return "Carrocería de fibra de carbono";
        }
    }
}
