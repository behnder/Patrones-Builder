using System;

namespace Patrones_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
           BuilderNormal builder = new BuilderNormal();
           BuilderDeportivo builderDeportivo = new BuilderDeportivo();

            Director miDirector = new Director(builder);
            miDirector.Construye();

            Producto auto1 = builder.ObtenerProductoTerminado();
            auto1.MostrarAuto();

           
            //miDirector.Construye(builderDeportivo);
            //Producto auto2 = builderDeportivo.ObtenerProductoTerminado();

            miDirector.CambiarBuilder(builderDeportivo);
            miDirector.Construye();
            auto1 = builderDeportivo.ObtenerProductoTerminado();
            auto1.MostrarAuto();

            //auto2.MostrarAuto();

            Console.ReadKey();

        }
    }
}
