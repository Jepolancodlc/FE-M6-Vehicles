using System;
using System.Collections.Generic;
using System.Text;

namespace M6_Vehiculos
{
    class Conductor : Persona
    {
        string id, tipoLicencia,fechaCaducidad;

        public Conductor() : base()
        {
            if (Licencia == false)
            {
                Console.WriteLine("No tiene carnet");
                Environment.Exit(0);
            }
            else
            {
                this.Id = pedirID();
                this.tipoLicencia = pedirLicencia();
                this.fechaCaducidad = pedirFechaCad();

            }

        }


        public string TipoLicencia { get => tipoLicencia; set => tipoLicencia = value; }
        public string FechaCaducidad { get => fechaCaducidad; set => fechaCaducidad = value; }
        public string Id { get => id; set => id = value; }

        private string pedirID()
        {
            Console.Write("Introduzca su ID: ");
            Id = Console.ReadLine();
            return Id;
        }

        private string pedirFechaCad()
        {
            int año, mes, dia;

            Console.WriteLine();
          
            Console.WriteLine("Introduzca DIA de caducidad");
            dia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca MES de caducidad");
            mes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca AÑO de caducidad");
            año = Convert.ToInt32(Console.ReadLine());

            DateTime fechaCad = new DateTime(año, mes, dia);
            string fecha = fechaCad.ToString("dd/MM/yyyy");
            return fecha;
        }

        private string pedirLicencia()
        {
            bool v = false;
            string a = "";
            do
            {
                Console.Write("Introduzca la licencia: ");
                tipoLicencia = Console.ReadLine().ToUpper();
                switch (TipoLicencia)
                {
                  
                    case "A":  //Carnet para moto
                        a = "A"; v = true;
                        break;
                    case "B": //Carnet para coche
                        a = "B"; v = true;
                        break;
                    case "C": //Carnet para camion
                        a = "C"; v = true;
                        break;

                  
                    default:
                        Console.WriteLine("Licencia No Disponible");
                        break;
                }
            } while (!v);

            return a;
        }

        public override string ToString()
        {
            return $"\n{{{nameof(TipoLicencia)}={TipoLicencia}, {nameof(FechaCaducidad)}={FechaCaducidad}, {nameof(Id)}={Id}, {nameof(Nombre)}={Nombre}, {nameof(Apellido)}={Apellido}, {nameof(FecNacimiento)}={FecNacimiento}, {nameof(Licencia)}={Licencia.ToString()}}}\n";
        }
    }
}
