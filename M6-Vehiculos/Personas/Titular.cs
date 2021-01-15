using System;
using System.Collections.Generic;
using System.Text;

namespace M6_Vehiculos
{
    class Titular : Conductor
    {
        bool seguro, garagePropio;

        public Titular() : base()
        {
                this.Seguro = tieneSeguro();
                this.GaragePropio = tieneGarage();
        }

        public bool Seguro { get => seguro; set => seguro = value; }
        public bool GaragePropio { get => garagePropio; set => garagePropio = value; }

        public override string ToString()
        {
            return $"\n{{{nameof(Nombre)}={Nombre}, {nameof(Apellido)}={Apellido},{nameof(FecNacimiento)}={FecNacimiento}, {nameof(Licencia)}={Licencia.ToString()},{nameof(Seguro)}={Seguro.ToString()}, {nameof(GaragePropio)}={GaragePropio.ToString()}, {nameof(TipoLicencia)}={TipoLicencia}, " +
            $"{nameof(FechaCaducidad)}={FechaCaducidad}, {nameof(Id)}={Id}}}\n";
        }

        private bool tieneSeguro()
        {
            Console.Write("El usuario tiene seguro?  [0 = SI] [1 = NO]\n");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool tieneGarage()
        {
            Console.Write("El usuario tiene garage propio?  [0 = SI] [1 = NO]\n");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

       
    }
}
