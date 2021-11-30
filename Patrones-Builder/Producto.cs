using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Builder
{
    class Producto
    {
        public IMotor Motor { get; set; }
        public ICarroceria Carroceria { get; set; }
        public ILlantas Llantas { get; set; }

        public void ColocarMotor(IMotor pMotor)
        {
            Motor = pMotor;
            Console.WriteLine("se ha colocado el motor:{0}", Motor.Especificaciones());
        }
        public void ColocarLlantas(ILlantas pLlantas)
        {
            Llantas = pLlantas;
            Console.WriteLine("se ha colocado las llantas:{0}", Llantas.informacion());
        }
        public void ColocarCarroceria(ICarroceria pCarroceria)
        {
            Carroceria = pCarroceria;
            Console.WriteLine("se ha colocado la carrocería:{0}", Carroceria.caracteristicas());
        }
        public void MostrarAuto()
        {
            Console.WriteLine("El auto fabricado tiene {0}--{1}--{2}", Motor.Especificaciones(), Llantas.informacion(), Carroceria.caracteristicas());
            Console.WriteLine("================");
        }

    }
}
