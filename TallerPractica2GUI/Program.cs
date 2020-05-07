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
            Console.Clear();

            Console.WriteLine($"Numero de liquidacion :{liquidacion.NumeroLiquidacion}\n"
                + $" Numero de identificacion:{liquidacion.IdentificacionPaciente}\n" +
                $"Salario Devengado:{liquidacion.SalarioDevengado}\n" +
                $" Tipo afiliacion :{liquidacion.TipoAfiliacion}\n" +
                $"Valor del servicio : {liquidacion.ValorServicio}\n"
                + $"Tarifa:{liquidacion.Tarifa}\n" +
                $"Tope maximo:{liquidacion.TopeMaximo}\n"
                + $"Couta Moderadora real:{liquidacion.CuotaReal}");

            Console.ReadKey();


        }



    }
}
