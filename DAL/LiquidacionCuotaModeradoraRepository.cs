using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DAL
{
    public class LiquidacionCuotaModeradoraRepository
    {
        private string ruta = @"Liquidacion.txt";
        private IList<Liquidacion> liquidaciones;

        public LiquidacionCuotaModeradoraRepository()
        {
            liquidaciones = new List<Liquidacion>();
        }



        public string Guardar(Liquidacion liquidacion)
        {
            FileStream file = new FileStream(ruta, FileMode.Append);
            StreamWriter escritor = new StreamWriter(file);
            escritor.WriteLine($"{liquidacion.NumeroLiquidacion};{liquidacion.IdentificacionPaciente};{liquidacion.TipoAfiliacion};{liquidacion.SalarioDevengado}" +
              $";{liquidacion.Tarifa};{liquidacion.TopeMaximo};{liquidacion.CuotaReal};{liquidacion.CuotaModerada}");
            escritor.Close();
            file.Close();
            return "Se ha guardado correctamente la persona";


        }
        public IList<Liquidacion> Consultar()
        {
            liquidaciones = new List<Liquidacion>();

            string Linea = string.Empty;
            FileStream file = new FileStream(ruta, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader escritor = new StreamReader(file);
            while ((Linea = escritor.ReadLine()) != null)
            {
                Liquidacion liquidacion = Mapear(Linea);
                liquidaciones.Add(liquidacion);
            }
            escritor.Close();
            file.Close();

            return liquidaciones;
        }
            public Liquidacion Mapear(string linea)
            {
                Liquidacion liquidacion;
                char delimiter = ';';
                string[] Datos = linea.Split(delimiter);
            if (Datos[2].Equals(" Regimen Subsidiado"))
            {
                liquidacion = new RegimenSubsidiado();
            }
            else
            {
                liquidacion = new RegimenContributivo();

            }

                liquidacion.NumeroLiquidacion = Datos[0];
                liquidacion.IdentificacionPaciente = Datos[1];
                liquidacion.TipoAfiliacion = Datos[2];
                liquidacion.SalarioDevengado = Convert.ToInt32 (Datos[3]);
                liquidacion.Tarifa = Convert.ToInt32(Datos[4]);
                liquidacion.TopeMaximo = Convert.ToDecimal(Datos[5]);
                liquidacion.CuotaReal = Convert.ToDecimal(Datos[6]);
                liquidacion.CuotaModerada = Convert.ToDecimal(Datos[7]);
                return liquidacion;

            }
    }
}
