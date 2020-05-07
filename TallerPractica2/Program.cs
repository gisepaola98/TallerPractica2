using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using Entity;



namespace TallerPractica2
{
    class Program
    {
        public static LiquidacionCuotaModeradoraService liquidacionService = new LiquidacionCuotaModeradoraService();
        public static List<Liquidacion> Listaliquidaciones = new List<Liquidacion>();

        ////static void Main(string[] args)
        //{
        //    int Opcion;

        //    do
        //    {


        //        Console.WriteLine("1. liquidar");
        //        Console.WriteLine("2. ConsultarLiquidaciones");
        //        Console.WriteLine("3. Modificar");
        //        Console.WriteLine("4. Eliminar");
        //        Console.WriteLine("5. Salir");
        //        Console.WriteLine("Por favor digite la opcion");
        //        Opcion = Convert.ToInt32(Console.ReadLine());
        //    }//
        
    } 
}
