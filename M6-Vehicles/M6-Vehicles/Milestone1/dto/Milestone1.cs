using System;
using System.Collections.Generic;
using System.Text;

namespace M6_Vehicles
{
    class Milestone1
    { 
        public void exe1()
        { 
            int ruedas = 0;
            int cocheOmoto=0;

            void comprobarCocheOMoto() {

                bool v = false;
                do
                {
                    Console.WriteLine("Quiere crear un coche o una moto?\n{0 para COCHE} {1 para MOTO} ");
                    cocheOmoto = Convert.ToInt32(Console.ReadLine());

                    if (cocheOmoto > 1)
                    {
                        Console.WriteLine("No Disponible");
                        v = false;
                    }
                    else
                    {
                        v = true;
                    }

                } while (!v);
            }

            comprobarCocheOMoto();
            
            Console.Write("Introduzca la matricula: ");
            string matricula = Console.ReadLine();

            do  //Pide la matricula hasta que esta este correcta
            {
                if (!comprobarMatricula(matricula))
                {
                    Console.WriteLine("-----Matricula incorrecta-------");
                    Console.Write("Introduzca una correcta matricula: ");
                    matricula = Console.ReadLine();
   
                }

            } while (!comprobarMatricula(matricula));
            Console.WriteLine("-----Matricula correcta-----");

            Console.Write("\nIntroduzca la marca: "); 
            string marca = Console.ReadLine();

            Console.Write("\nIntroduzca el color: ");
            string color = Console.ReadLine();

            Console.Write("\nIntroduzca la marca de las ruedas delanteras: ");
            string marcaDelante = Console.ReadLine();

            //Agregar Ruedas delanteras
            Console.Write("\nIntroduzca el diametro de las ruedas delanteras: ");
            double diametroDelante = Convert.ToDouble(Console.ReadLine());
            if (!comprobarDiametro(diametroDelante))
            {
                do //Pide el diametro hasta que este sea correcto
                {
                    Console.Write("\nDiametro delantero fuera de rango, por favor introduzca de nuevo el diametro:");
                    diametroDelante = Convert.ToDouble(Console.ReadLine());

                } while (!comprobarDiametro(diametroDelante));
            }
            cocheORmoto(cocheOmoto);

            //Agregar Ruedas Traseras
            Console.Write("\nIntroduzca la marca de las ruedas traseras: ");
            string marcaDetras = Console.ReadLine();
            Console.Write("\nIntroduzca el diametro de las ruedas traseras: ");
            double diametroDetras = Convert.ToDouble(Console.ReadLine());

            if (!comprobarDiametro(diametroDetras))
            {
                do //Pide el diametro hasta que este sea correcto
                {
                    Console.Write("\nDiametro trasero fuera de rango, por favor introduzca de nuevo el diametro:");
                    diametroDetras = Convert.ToDouble(Console.ReadLine());

                } while (!comprobarDiametro(diametroDetras));
            }
           

            cocheORmoto(cocheOmoto); //Agrega el numero de ruedas

            //Crear objeto
            coche coche = new coche(marca, color, matricula, ruedas);
            Console.WriteLine(coche);
            //Metodos
            int cocheORmoto(int cocheOmoto) //Dependiende si el usuario elige coche o moto se le asignara un numero de ruedas
            {
                if (cocheOmoto == 0)
                {
                    ruedas += 2;
                }
                else
                {
                    ruedas += 1;
                }

                return ruedas; ;
            }

            bool comprobarDiametro(double valor) //Comprueba el diametro de las ruedas
            {
                if (valor >= 0.4 && valor <= 4)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            bool comprobarMatricula(string matricula) //Comrueba la matricula
            {

                char caracter;
                int cuentaNum = 0;
                int cuentaLetra = 0;

                for (int i = 0; i < matricula.Length; i++)
                {
                    caracter = matricula[i];


                    if (char.IsDigit(caracter))
                    {
                        cuentaNum++;
                    }
                    else if (char.IsLetter(caracter))
                    {
                        cuentaLetra++;
                    }
                    else
                    {
                        Console.WriteLine("Caracter inapropiado para la matricula");
                        return false;
                    }
                }

                if (cuentaNum != 4)
                {
                    Console.WriteLine("La Matricula ha de tener 4 numeros");
                    return false;
                }
                else if (cuentaLetra == 0)
                {
                    Console.WriteLine("La matricula ha de poseer al menos una letra");
                    return false;
                }
                else if (cuentaLetra > 3 )
                {
                    Console.WriteLine("La matricula no puede poseer mas de 3 Letras");
                    return false;
                }
                else if (matricula.Length > 7)
                {
                    Console.WriteLine("Formato incorrecto de matricula");
                    return false;
                }
                return true;
            }
        }
    }
}
