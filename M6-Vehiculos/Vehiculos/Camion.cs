using System;
using System.Collections.Generic;
using System.Text;

namespace M6_Vehiculos
{
    class Camion:Vehiculo
    {
        public Camion()
             : base()
        {
            this.Ruedas = 4;
        }

        public override string ToString()
        {
            return $"\n{{Camion: {nameof(Marca)}={Marca}, {nameof(Color)}={Color}, {nameof(Matricula)}={Matricula}, {nameof(Ruedas)}={Ruedas.ToString()}, {nameof(MarcaRuedaT)}={MarcaRuedaT}, {nameof(MarcaRuedaD)}={MarcaRuedaD}, {nameof(DiametroD)}={DiametroD.ToString()}, {nameof(DiametroT)}={DiametroT.ToString()}}}\n";
        }
    }

}
