using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
     public class RegimenContributivo : Liquidacion
    {
        
        public override void ObtenerTarifa()
        {
            if (SalarioDevengado < 2)
            {
               Tarifa=  15;
            }
            else if (SalarioDevengado >= 2 && SalarioDevengado <= 5)
            {
                Tarifa= 20;
            }
            else
            {
                Tarifa = 25;
            }
        }

        public override void  ObtenerTope()
        {
            if (SalarioDevengado < 2)
            {
                Tarifa=250000;
            }
            else if (SalarioDevengado >= 2 && SalarioDevengado <= 5)
            {
                 Tarifa= 90000;
            }
            else
            {
               Tarifa= 1500000;
            }
        }
    }
}

