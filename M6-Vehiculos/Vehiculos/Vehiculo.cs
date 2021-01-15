using System;
using System.Collections.Generic;
using System.Text;

namespace M6_Vehiculos
{
    class Vehiculo
    {
        private string marca, color, matricula, marcaRuedaT, marcaRuedaD;
        private double diametroD, diametroT;
        private int ruedas = 4;
       

        public Vehiculo()
        {
            this.Marca = pedirMarca();
            this.Color = pedircolor();
            this.Matricula = pedirMatricula();
            this.MarcaRuedaT = pedirMarcaT();
            this.MarcaRuedaD = pedirMarcaD();
            this.DiametroD = diametroDel() ;
            this.DiametroT = diametroTras();
        }

        public string Marca { get => marca; set => marca = value; }
        public string Color { get => color; set => color = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public int Ruedas { get => ruedas; set => ruedas = value; }
        public string MarcaRuedaT { get => marcaRuedaT; set => marcaRuedaT = value; }
        public string MarcaRuedaD { get => marcaRuedaD; set => marcaRuedaD = value; }
        public double DiametroD { get => diametroD; set => diametroD = value; }
        public double DiametroT { get => diametroT; set => diametroT = value; }

        public override string ToString()
        {
          
            return $"\n{{{nameof(Marca)}={Marca}, {nameof(Color)}={Color}, {nameof(Matricula)}={Matricula}, {nameof(Ruedas)}={Ruedas.ToString()}, {nameof(MarcaRuedaT)}={MarcaRuedaT}, {nameof(MarcaRuedaD)}={MarcaRuedaD}, {nameof(DiametroD)}={DiametroD.ToString()}, {nameof(DiametroT)}={DiametroT.ToString()}}}\n";
        }

        public string pedirMatricula()
        {
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

            return matricula;
        }

        private bool comprobarMatricula(string matricula) //Comrueba la matricula
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
            else if (cuentaLetra > 3)
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

        private string pedirMarca()
        {
            Console.WriteLine("------CREACION DEL VEHICULO");
            Console.Write("Introduzca la marca: ");
            String marca = Console.ReadLine();

            return marca;
        }

        private string pedircolor()
        {
            Console.Write("Introduzca el color: ");
            String color = Console.ReadLine();

            return color;
        }

        private string pedirMarcaD()
        {
            Console.Write("Introduzca la marca de las ruedas delanteras: ");
            string marcaD = Console.ReadLine();

            return marcaD;
        }

        private string pedirMarcaT()
        {
            Console.Write("Introduzca la marca de las ruedas delanteras: ");
            string marcaT = Console.ReadLine();

            return marcaT;
        }

        private double diametroDel()
        {
            Console.Write("Introduzca el diametro de las ruedas delanteras: ");
            double diametroDelante = Convert.ToDouble(Console.ReadLine());
            if (!comprobarDiametro(diametroDelante))
            {
                do 
                {
                    Console.Write("Diametro delantero fuera de rango, por favor introduzca de nuevo el diametro:");
                    diametroDelante = Convert.ToDouble(Console.ReadLine());

                } while (!comprobarDiametro(diametroDelante));
            }
            return diametroDelante;
        }

        private double diametroTras()
        {
        
            Console.Write("Introduzca el diametro de las ruedas traseras: ");
            double diametroDetras = Convert.ToDouble(Console.ReadLine());

            if (!comprobarDiametro(diametroDetras))
            {
                do //Pide el diametro hasta que este sea correcto
                {
                    Console.Write("Diametro trasero fuera de rango, por favor introduzca de nuevo el diametro:");
                    diametroDetras = Convert.ToDouble(Console.ReadLine());

                } while (!comprobarDiametro(diametroDetras));
            }

            return  diametroDetras;
        }
        private bool comprobarDiametro(double valor) //Comprueba el diametro de las ruedas
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
    }
}
