using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Builder
{
    class BuilderDeportivo : Ibuilder
    {
        private Producto auto = new Producto();
        public void ConstructorDeCarroceria()
        {
            auto.ColocarCarroceria(new CarroceriaEspecial());
        }

        public void ConstructorDeLlantas()
        {
            auto.ColocarLlantas(new LlantasSuper());
        }

        public void ConstructorDeMotor()
        {
            auto.ColocarMotor(new MotorGrande());
        }

        public Producto ObtenerProductoTerminado()
        {
            return auto;
        }
    }
}
