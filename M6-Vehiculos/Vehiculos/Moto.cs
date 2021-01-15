using System;
using System.Collections.Generic;
using System.Text;

namespace M6_Vehiculos
{
    class Moto : Vehiculo
    {
        public Moto()
            : base()
        {
            this.Ruedas = 2;
        }

        public override string ToString()
        {
            return $"\n{{Moto: {nameof(Marca)}={Marca}, {nameof(Color)}={Color}, {nameof(Matricula)}={Matricula}, {nameof(Ruedas)}={Ruedas.ToString()}, {nameof(MarcaRuedaT)}=" +
                $"{MarcaRuedaT}, {nameof(MarcaRuedaD)}={MarcaRuedaD}, {nameof(DiametroD)}={DiametroD.ToString()}, {nameof(DiametroT)}={DiametroT.ToString()}}}\n";
        }
    }
}
