using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
     public class RegimenSubsidiado : Liquidacion
    {

        public RegimenSubsidiado()
        {
            SalarioDevengado = 0;
        }

        public override void  ObtenerTarifa()
        {
            Tarifa= 5;
        }

        public override void ObtenerTope()
        {
            Tarifa= 200000;
        }
    }
}
