using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entity;


    

namespace TallerPractica2GUI
{
    static class Program
    {
        public static LiquidacionCuotaModeradoraService liquidacionService = new LiquidacionCuotaModeradoraService();
        public static List<Liquidacion> liquidaciones = new List<Liquidacion>();

        static void Main()
        {
            int Opcion;

            do
            {


                Console.WriteLine("1. Registrar y liquidar");
                Console.WriteLine("2. Consultar");
                Console.WriteLine("3. Modificar");
                Console.WriteLine("4. Eliminar");
                Console.WriteLine("5. Salir");
                Console.WriteLine("Por favor digite la opcion");
                Opcion = Convert.ToInt32(Console.ReadLine());

                switch (Opcion)
                {
                    case 1:
                        Liquidacion liquidacion;
                        string NumeroLiquidacion, IdentificacionPaciente, TipoAfiliacion;

                        Console.WriteLine("Por favor digite numero de la liquidacion");
                        NumeroLiquidacion = Console.ReadLine();
                        Console.WriteLine("Por favor digite numero de Identificacion del Paciente");
                        IdentificacionPaciente = Console.ReadLine();
                        Console.WriteLine("Por favor digite tipo de afiliacion CONTRIBUTIVO o SUBSIDIADO");
                        TipoAfiliacion = Console.ReadLine();
                        if (TipoAfiliacion == " Regimen Contributivo")
                        {
                            liquidacion = new RegimenContributivo();
                            Console.WriteLine("Por favor digite Salario Devengado;");
                            liquidacion.SalarioDevengado = Convert.ToDecimal(Console.ReadLine());
                        }
                        else
                        {
                            liquidacion = new RegimenSubsidiado();
                        }
                        liquidacion.NumeroLiquidacion = NumeroLiquidacion;
                        liquidacion.IdentificacionPaciente = IdentificacionPaciente;
                        liquidacion.TipoAfiliacion = TipoAfiliacion;

                        Console.WriteLine("Digite Valor del Servicio");
                        liquidacion.ValorServicio = Convert.ToDecimal(Console.ReadLine());

                        liquidacion.LiquidacionCuotaModerada();

                        Console.WriteLine(liquidacionService.Guardar(liquidacion));
                        break;
                    case 2:

                        liquidaciones = liquidacionService.Consultar();
                        foreach (Liquidacion item in liquidaciones)
                        {
                            Console.WriteLine($"Numero : {item.NumeroLiquidacion}");
                            Console.WriteLine($"Identificacion: {item.IdentificacionPaciente}");
                            Console.WriteLine($"Tipo De Afiliacion: {item.}");
                            Console.WriteLine($"Salario Devengado: {item.SalarioDevengado}");
                            Console.WriteLine($"Valor Del Servicio: {item.ValorServicio}");
                            Console.WriteLine($"Tope: {item.TopeMaximo}");
                            Console.WriteLine($"Cuota Moderada: {item.CuotaModerada}");
                            Console.WriteLine($"Tarifa: {item.Tarifa}");

                        }
                        break;
                    case 3:
                        Console.WriteLine("Digite Numero de Liquidacion a Modificar: ");
                        liquidacion = liquidacionService.Buscar(Console.ReadLine());
                        if (liquidacion != null)
                        {
                            Console.WriteLine("Digite el nuevo Valor de Servicio: ");
                            liquidacion.ValorServicio = Convert.ToDecimal(Console.ReadLine());
                            liquidacion.LiquidacionCuotaModerada();
                            liquidacionService.Modificar(liquidacion);
                            Console.WriteLine("Modificado Correctamente...");
                        }
                        else
                        {
                            Console.WriteLine("No se encontro el numero d eliquidacion a modificar");
                        }

                        break;
                    case 4:
                        Console.WriteLine("Digite Numero de Liquidacion que desea Eliminar: ");
                        liquidacion = liquidacionService.Buscar(Console.ReadLine());
                        if (liquidacion != null)
                        {
                            //liquidacionService.Eliminar(liquidacion); Error
                            Console.WriteLine("Opcion no terminada ");
                            Console.ReadKey();
                            break;
                        }
                        break;
                    case 5:
                        Console.WriteLine("Adios");
                        break;
                    default:
                        Console.WriteLine("La opcion digitada no es valida");
                        break;
                }
                Console.ReadKey();
            } while (Opcion != 5);

        }
    }
}
