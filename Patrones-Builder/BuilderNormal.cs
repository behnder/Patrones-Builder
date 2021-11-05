using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Builder
{
    class BuilderNormal : Ibuilder
    {
        private Producto auto = new Producto();
        public void ConstructorDeCarroceria()
        {
            auto.ColocarCarroceria(new CarroceriaBasica());
        }

        public void ConstructorDeLlantas()
        {
            auto.ColocarLlantas(new Llantas12());
        }

        public void ConstructorDeMotor()
        {
            auto.ColocarMotor(new MotorBasico());
        }

        public Producto ObtenerProductoTerminado()
        {
            return auto;
        }
    }
}
