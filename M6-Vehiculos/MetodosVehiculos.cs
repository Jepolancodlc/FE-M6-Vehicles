using System;
using System.Collections.Generic;
using System.Text;

namespace M6_Vehiculos
{
    class MetodosVehiculos
    {
        public void exe()
        {
            
            bool v= false;
            do
            {
                Console.WriteLine("Crear persona? [0 = SI] [1 = NO]");
                int a = Convert.ToInt32(Console.ReadLine());
                if (a == 0)
                {
                    exexe();
                   
                }
                else
                {
                    v = true;
                }
            } while (!v);

        }

        public void exexe()
        {
           
            Titular titular = new Titular();
            Console.WriteLine(titular);
         
            if (titular.TipoLicencia == "A")
            {
                Moto moto = new Moto();
                Console.WriteLine(moto);
            }
            else if (titular.TipoLicencia == "B")
            {
                Coche coche= new Coche();
                Console.WriteLine(coche);
            }
            else if (titular.TipoLicencia == "C")
            {
                Camion camion = new Camion();
                Console.WriteLine(camion);
            }

            Console.Write("El titular sera el conductor?  [0 = SI] [1 = NO]\n");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("Conduzca con cuidado");
            }
            else
            {
                Console.WriteLine("Cree un conductor");
                Conductor conductor = new Conductor();
                Console.WriteLine(conductor);

                if (conductor.TipoLicencia != titular.TipoLicencia)
                {
                    Console.WriteLine("EL conductor no tiene el carnet correspondiente");
                }
                
            }
        }   
    }
}
