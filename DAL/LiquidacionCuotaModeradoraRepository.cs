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
            escritor.WriteLine($"{liquidacion.NumeroLiquidacion};{liquidacion.IdentificacionPaciente};{liquidacion.TipoAfiliacion}" +
              $";{liquidacion.SalarioDevengado};{liquidacion.Tarifa};{liquidacion.TopeMaximo};{liquidacion.CuotaReal}; {liquidacion.CuotaModerada};{liquidacion.FechaAfiliacion};{liquidacion.ValorServicio}; " );
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
            liquidacion = CrearLiquidacion(Datos);
            liquidacion.NumeroLiquidacion = Datos[0];
            liquidacion.IdentificacionPaciente = Datos[2];
            liquidacion.TipoAfiliacion = Datos[3];
            liquidacion.SalarioDevengado = Convert.ToInt32(Datos[4]);
            liquidacion.Tarifa = Convert.ToInt32(Datos[5]);
            liquidacion.TopeMaximo = Convert.ToDecimal(Datos[6]);
            liquidacion.CuotaReal = Convert.ToDecimal(Datos[7]);
            liquidacion.CuotaModerada = Convert.ToDecimal(Datos[8]);
            liquidacion.FechaAfiliacion = Convert.ToDateTime(Datos[9]);
            liquidacion.ValorServicio = Convert.ToDecimal(Datos[10]);
            return liquidacion;

            }

        private static Liquidacion CrearLiquidacion(string[] Datos)
        {
            Liquidacion liquidacion;
            if (Datos[3].Equals(" Regimen Subsidiado"))
            {
                liquidacion = new RegimenSubsidiado();
            }
            else
            {
                liquidacion = new RegimenContributivo();

            }

            return liquidacion;

        }
        
        public void Eliminar(string numeroLiquidacion)
        {
            liquidaciones.Clear();
            liquidaciones = Consultar();
            FileStream file = new FileStream(ruta, FileMode.Create);
            file.Close();

            foreach (var item in liquidaciones)
            {
                if (item.NumeroLiquidacion != numeroLiquidacion)
                {
                    Guardar(item);

                }
            }
        }


        public bool Modificar(Liquidacion liquidacion)
        {
            bool modificado = false;
            liquidaciones = Consultar();
            FileStream file = new FileStream(ruta, FileMode.Create);
            file.Close();
            foreach (var item in liquidaciones)
            {
                if (item.NumeroLiquidacion != liquidacion.NumeroLiquidacion)
                {
                    Guardar(item);

                }
                else
                {


                    Guardar(liquidacion);
                    modificado = true;
                }


            }
            return modificado;

        }

    
        
        public Liquidacion Buscar(string numeroLiquidacion)
        {
            liquidaciones = Consultar();
             return liquidaciones.Where(l => l.NumeroLiquidacion == numeroLiquidacion).FirstOrDefault();


        }
        public IList<Liquidacion> BuscarPalabra(string numeroLiquidacion)
        {
            liquidaciones = Consultar();
            return liquidaciones= liquidaciones.Where((n)=>! (numeroLiquidacion.Contains(n.NumeroLiquidacion.ToString()))).ToList();


        }

        public int TotalLiquidaciones() 
        {
            liquidaciones = Consultar();
            return liquidaciones.Count();
        }

        public IList<Liquidacion> ListaPorTipo(string tipo) 
        {
            liquidaciones = Consultar();
            return liquidaciones.Where(l => l.TipoAfiliacion.Equals(tipo)).ToList();
        
        }
        public int TotalTipo(string tipo) 
        {
            liquidaciones = Consultar();
            return liquidaciones.Where(l => l.TipoAfiliacion.Equals(tipo)).Count();
        
        }
        public decimal  TotalCuotaTipo(string tipo)
        {
            liquidaciones = Consultar();
            return liquidaciones.Where(l => l.TipoAfiliacion == tipo).Sum(l => l.CuotaModerada);
        }

        public decimal TotalCuotaModeradora() 
        {
            liquidaciones = Consultar();
            return liquidaciones.Sum(l => l.CuotaModerada);
        }

        public List<Liquidacion> PorFecha(DateTime fechaafiliacion) //fecha
        {
            liquidaciones = Consultar();
            return liquidaciones.Where(l => l.FechaAfiliacion.Equals(fechaafiliacion)).ToList();
        }
    }
}
