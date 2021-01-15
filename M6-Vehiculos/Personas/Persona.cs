using System;
using System.Collections.Generic;
using System.Text;

namespace M6_Vehiculos
{
    class Persona
    {
        private string nombre, apellido, fecNacimiento;
        private bool licencia;

        public Persona()
        {
            
            this.Nombre = pedirNombre();
            this.Apellido = pedirApellido();
            this.FecNacimiento = nacidoEn();
            this.Licencia = tieneLicencia();
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string FecNacimiento { get => fecNacimiento; set => fecNacimiento = value; }
        public bool Licencia { get => licencia; set => licencia = value; }

        public override string ToString()
        {
            return $"\n{{{nameof(Nombre)}={Nombre}, {nameof(Apellido)}={Apellido}, {nameof(FecNacimiento)}={FecNacimiento}, {nameof(Licencia)}={Licencia.ToString()}}}\n";
        }

        private string nacidoEn()
        {
            int año, mes, dia;

           
          
            Console.Write("Introduzca DIA de nacimiento: ");
            dia = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduzca MES de nacimiento: ");
            mes = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduzca AÑO de nacimiento: ");
            año = Convert.ToInt32(Console.ReadLine());

            DateTime fecNacimiento = new DateTime(año, mes, dia);
            string FechaN = fecNacimiento.ToString("dd/MM/yyyy");
            return FechaN;
        }

        private string pedirNombre()
        {
            Console.Write("Introduzca el nombre: ");
            Nombre = Console.ReadLine();
            return Nombre;
        }

        private string pedirApellido()
        {
            Console.Write("Introduzca el apellido: ");
            apellido = Console.ReadLine();
            return apellido;
        }

        private bool tieneLicencia()
        {
            Console.Write("El usuario tiene licencia?  [0 = SI] [1 = NO]\n");
            int  a = Convert.ToInt32(Console.ReadLine());

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
