using System;
using System.Collections.Generic;
using System.Text;

namespace M6_Vehicles
{
    class coche2
    {
        string marca, color, matricula;
        int ruedas = 0;
        

        public coche2(string marca, string color, string matricula, int ruedas)
        {
            this.Marca = marca;
            this.Color = color;
            this.Matricula = matricula;
            this.Ruedas = ruedas;
        }

        public string Marca { get => marca; set => marca = value; }
        public string Color { get => color; set => color = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public int Ruedas { get => ruedas; set => ruedas = value; }

        public override string ToString()
        {
            return $"{{{nameof(Marca)}={Marca}, {nameof(Color)}={Color}, {nameof(Matricula)}={Matricula}, {nameof(Ruedas)}={Ruedas.ToString()}}}";
        }
    }
    

}
