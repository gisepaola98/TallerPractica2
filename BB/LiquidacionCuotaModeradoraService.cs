using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;

namespace BLL

{
    public class LiquidacionCuotaModeradoraService
    {
        LiquidacionCuotaModeradoraRepository liquidacionCuotaModeradoraRepository;

        public LiquidacionCuotaModeradoraService()
        {
            liquidacionCuotaModeradoraRepository = new LiquidacionCuotaModeradoraRepository();
        }

        public string Guardar(Liquidacion liquidacion)
        {
            try
            {
                if (liquidacionCuotaModeradoraRepository.Buscar(liquidacion.NumeroLiquidacion) == null)
                {
                    liquidacionCuotaModeradoraRepository.Guardar(liquidacion);

                    return $"La liquidacion {liquidacion.NumeroLiquidacion} fueron registrados correctamente";


                }
                else
                {
                    return $"La liquidacion {liquidacion.NumeroLiquidacion} ya existe";
                }

            }
            catch (Exception e)
            {

                return $"Lo siento, error: {e.Message} ";
            }

        }

        public string Modificar(Liquidacion liquidacion)
        {
            try
            {

                if (liquidacionCuotaModeradoraRepository.Modificar(liquidacion))
                {
                    return "modificado exitosamente  la liquidacion";
                }
                else
                {
                    return "No hay modificacion para liquidar";
                }
            }
            catch (Exception e)
            {
                return "Error" + e.Message;

            }

        }

        public RespuestaConsultar Consultar()
        {
            RespuestaConsultar respuesta = new RespuestaConsultar();
            try
            {

                respuesta.liquidaciones = liquidacionCuotaModeradoraRepository.Consultar();
                if (respuesta.liquidaciones != null)
                {
                    respuesta.Mensaje = "Se consulta la informacion de liquidaciones";
                }
                else
                {
                    respuesta.Mensaje = "No existen datos para consultar";
                }
            }
            catch (Exception e)
            {

                respuesta.Mensaje = $"error de datos" + e.Message;

            }
            return respuesta;

        }

        public string Eliminar(string NumeroLiquidacion)
        {
            try
            {
                Liquidacion liquidacion = liquidacionCuotaModeradoraRepository.Buscar(NumeroLiquidacion);

                if (liquidacion != null)
                {
                    liquidacionCuotaModeradoraRepository.Eliminar(NumeroLiquidacion);
                    return $"La liquidacion {liquidacion.NumeroLiquidacion} se  elimino satiafactoriamente";
                }
                else
                {
                    return $"Lo datos de {liquidacion.NumeroLiquidacion} no estan registrados";
                }
            }
            catch (Exception e)
            {
                return $"Error: {e.Message}";
            }
        }
        public RespuestaEncontrado Buscar(string NumeroLiquidacion)
        {
            RespuestaEncontrado respuesta = new RespuestaEncontrado();
            try
            {

                respuesta.liquidacion = liquidacionCuotaModeradoraRepository.Buscar(NumeroLiquidacion);
                if (respuesta.liquidacion != null)
                {
                    respuesta.Mensaje = "Se consultaron los datos satisfariamente";
                }
                else
                {
                    respuesta.Mensaje = "La liquidacion  solicitada no existe";
                }
                return respuesta;
            }
            catch (Exception e)
            {

                respuesta.Mensaje = "error de datos" + e.Message;
                return respuesta;
            }
        }
        public IList<Liquidacion> PoFecha(DateTime fecha)
        {
            return liquidacionCuotaModeradoraRepository.PorFecha(fecha);
        }
        public IList<Liquidacion> BuscarPalabra(string numeroLiquidacion)
        {
            return liquidacionCuotaModeradoraRepository.BuscarPalabra(numeroLiquidacion);
        }

        public RespuestaTotalCuotaTipo TotalCuotaTipo( string tipo)
        {
            RespuestaTotalCuotaTipo respuesta = new RespuestaTotalCuotaTipo();


            try
            {

                respuesta.Total = liquidacionCuotaModeradoraRepository.TotalCuotaTipo(tipo);
                if (respuesta.Total == 0)
                {
                    respuesta.Mensaje = "No se puede sumar ";
                }
            }
            catch (Exception e)
            {


                respuesta.Mensaje = " Los totales se sumaron exitosamente" + e.Message;
            }
            return respuesta;

        }

        public RespuestaTotalTipo TotalTipo(string tipo)
        {
            RespuestaTotalTipo respuesta = new RespuestaTotalTipo();


            try
            {

                respuesta.Total = liquidacionCuotaModeradoraRepository.TotalTipo(tipo);
                if (respuesta.Total == 0)
                {
                    respuesta.Mensaje = "No se puede sumar ";
                }
            }
            catch (Exception e)
            {


                respuesta.Mensaje = " Los totales se sumaron exitosamente" + e.Message;
            }
            return respuesta;
        }

        public RespuestaTotalLiquidacion TotalLiquidacione()
        {
            RespuestaTotalLiquidacion respuesta = new RespuestaTotalLiquidacion();
            try
            {

                respuesta.Total = liquidacionCuotaModeradoraRepository.TotalLiquidaciones();

                if (respuesta.Total == 0)
                {
                    respuesta.Mensaje = "Lo siento, no hay numeros totales de liquidacion ";
                }
            }
            catch (Exception e)
            {
                respuesta.Mensaje = "Los numeros de liquidaciones fueron encontrados satisfactoriamente" + e.Message;
            }
            return respuesta;
        }

        public RespuestaListaPorTipo TipoAfiliacion(string tipo)
        {
            RespuestaListaPorTipo respuesta = new RespuestaListaPorTipo();
            try
            {
                respuesta.liquidaciones = liquidacionCuotaModeradoraRepository.ListaPorTipo(tipo);
                if (respuesta.liquidaciones.Count == 0)
                {
                    respuesta.Mensaje = " No se encuentran  datos en el archivo";

                }
                else
                {
                    respuesta.Mensaje = "Los datos fueron verificados exitosamente";
                }

                return respuesta;
            }
            catch (Exception e)
            {

                respuesta.Mensaje = "Error" + e.Message;
                return respuesta;
            }

        }
        public RepuestaTotalCuotaModeradora TotalCuotaModeradora()
        {
            RepuestaTotalCuotaModeradora respuesta = new RepuestaTotalCuotaModeradora();
            try
            {
                respuesta.Total = liquidacionCuotaModeradoraRepository.TotalCuotaModeradora();
                if (respuesta.Total == 0)
                {
                    respuesta.Mensaje = " No se encuentran  datos para sumar";

                }
                else
                {
                    respuesta.Mensaje = "Los totales se sumaron exitosamente";
                }

                return respuesta;
            }
            catch (Exception e)
            {

                respuesta.Mensaje = "Error" + e.Message;
                return respuesta;
            }
        }
    }
    public class RespuestaTotalLiquidacion
    {
        public string Mensaje { get; set; }
        public int Total { get; set; }
    }
    public class RespuestaTotalCuotaTipo
    {
        public string Mensaje { get; set; }
        public decimal Total { get; set; }
    }
    
    public class RespuestaListaPorTipo
    {
        public string Mensaje { get; set; }
        public IList<Liquidacion> liquidaciones { get; set; }
    }
    public class RespuestaConsultar
    {
        public string Mensaje { get; set; }
        public IList<Liquidacion> liquidaciones { get; set; }

    }
    public class RespuestaEncontrado
    {
        public string Mensaje { get; set; }
        public Liquidacion liquidacion { get; set; }
    }
    public class RespuestaTotalTipo
    {
        public string Mensaje { get; set; }
        public decimal Total { get; set; }
    }
    public class RepuestaTotalCuotaModeradora 
    {
        public string Mensaje { get; set; }
        public decimal Total { get; set; }

    }
}








