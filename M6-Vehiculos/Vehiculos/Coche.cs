using System;
using System.Collections.Generic;
using System.Text;

namespace M6_Vehiculos
{
    class Coche : Vehiculo
    {
        public Coche( ) 
            : base()
        {
            this.Ruedas = 4;
        }

        public override string ToString()
        {
            return $"\n{{Coche: {nameof(Marca)}={Marca}, {nameof(Color)}={Color}, {nameof(Matricula)}={Matricula}, {nameof(Ruedas)}={Ruedas.ToString()}, {nameof(MarcaRuedaT)}={MarcaRuedaT}, {nameof(MarcaRuedaD)}={MarcaRuedaD}, {nameof(DiametroD)}={DiametroD.ToString()}, {nameof(DiametroT)}={DiametroT.ToString()}}}\n";
        }
    }
}
