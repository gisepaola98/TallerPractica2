using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public abstract class   Liquidacion
    {
        public string TipoAfiliacion { get; set; }
        public string IdentificacionPaciente { get; set; }
        public string NumeroLiquidacion { get; set; }
        public decimal SalarioDevengado { get; set; }
        public decimal ValorServicio { get; set; }
        public DateTime FechaAfiliacion { get; set; }




        public decimal CuotaModerada { get; set; }
        public decimal TopeMaximo { get; set; }
        public decimal Tarifa { get; set; }
        public decimal CuotaReal { get; set; }

        public abstract void ObtenerTarifa();
        public abstract void  ObtenerTope();
        public void LiquidacionCuotaModerada()
        {
             ObtenerTarifa();
             ObtenerTope();
            CuotaModerada = ValorServicio * (Tarifa / 100) + ValorServicio;
            CuotaReal = CuotaModerada;
            LiquidardarCuota();
            
        }

        public void LiquidardarCuota()
        {
            if (CuotaModerada > TopeMaximo)
            {
                CuotaModerada = TopeMaximo;
            }
        }

    }


}
