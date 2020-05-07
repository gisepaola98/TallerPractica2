using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entity;

namespace TallerPractica2GUI
{
    public partial class FrmConsultarLiquidaciones : Form
    {
        LiquidacionCuotaModeradoraService liquidacionCuotaService;

        public FrmConsultarLiquidaciones()
        {
            InitializeComponent();
            liquidacionCuotaService = new LiquidacionCuotaModeradoraService();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (cmbConsultartipo.Text.Equals("Ambas"))
            {
                dgtLiquidaciones.DataSource = null;
                RespuestaConsultar respuesta = new RespuestaConsultar();
                RespuestaTotalTipo totalTipo = new RespuestaTotalTipo();
                RepuestaTotalCuotaModeradora totalCuotaModeradora = new RepuestaTotalCuotaModeradora();
                RespuestaTotalCuotaTipo totalCuotaTipo = new RespuestaTotalCuotaTipo();
                RespuestaTotalLiquidacion totalLiquidacion = new RespuestaTotalLiquidacion();
                respuesta = liquidacionCuotaService.Consultar();
                dgtLiquidaciones.DataSource = respuesta.liquidaciones;
                totalLiquidacion = liquidacionCuotaService.TotalLiquidacione();
                txtLiquidaciones.Text = totalLiquidacion.Total.ToString();
                totalTipo = liquidacionCuotaService.TotalTipo("RegimenContributivo");
                txtRegimencontributivo.Text = totalTipo.Total.ToString();
                totalTipo = liquidacionCuotaService.TotalTipo("RegimenSubsidiado");
                txtRegimensubsidiado.Text = totalTipo.Total.ToString();
                totalCuotaModeradora = liquidacionCuotaService.TotalCuotaModeradora();
                txtLiquidaciones.Text = totalCuotaModeradora.Total.ToString();
                totalTipo = liquidacionCuotaService.TotalTipo("RegimenContributivo");
                txtRegimencontributivo.Text = totalTipo.Total.ToString();
                totalTipo = liquidacionCuotaService.TotalTipo("Regimen Subsidiado");
                txtRegimensubsidiado.Text = totalTipo.Total.ToString();
            }
            else if (cmbConsultartipo.Text.Equals(" Regimen Contributivo"))
            {
                dgtLiquidaciones.DataSource = null;
                RespuestaListaPorTipo respuesta = new RespuestaListaPorTipo();
                RespuestaTotalLiquidacion totalLiquidacion = new RespuestaTotalLiquidacion();
                RespuestaTotalTipo totalTipo = new RespuestaTotalTipo();
                RepuestaTotalCuotaModeradora totalCuotaModeradora = new RepuestaTotalCuotaModeradora();
                respuesta = liquidacionCuotaService.TipoAfiliacion("Contributivo");
                MessageBox.Show(respuesta.Mensaje);
                dgtLiquidaciones.DataSource = respuesta.liquidaciones;
                txtLiquidaciones.Text = "0";
                txtRegimensubsidiado.Text = "0";
                totalTipo = liquidacionCuotaService.TotalTipo("Contributivo");
                txtRegimencontributivo.Text = totalTipo.Total.ToString();
                txtLiquidaciones.Text = "0";
                txtRegimensubsidiado.Text = "0";
                totalTipo = liquidacionCuotaService.TotalTipo("Contributivo");
                txtRegimencontributivo.Text = totalTipo.Total.ToString();

            }
            else if (cmbConsultartipo.Text.Equals("Subsidiado"))
            {
                dgtLiquidaciones.DataSource = null;
                RespuestaListaPorTipo respuesta = new RespuestaListaPorTipo();
                RespuestaTotalLiquidacion totalLiquidacion = new RespuestaTotalLiquidacion();
                RespuestaTotalTipo totalTipo = new RespuestaTotalTipo();
                RepuestaTotalCuotaModeradora totalCuotaModeradora = new RepuestaTotalCuotaModeradora();
                respuesta = liquidacionCuotaService.TipoAfiliacion("RegimenSubsidiado");
                MessageBox.Show(respuesta.Mensaje);
                dgtLiquidaciones.DataSource = respuesta.liquidaciones;
                txtLiquidaciones.Text = "0";
                txtRegimencontributivo.Text = "0";
                totalTipo = liquidacionCuotaService.TotalTipo("RegimenSubsidiado");
                txtRegimensubsidiado.Text = totalTipo.Total.ToString();
                txtLiquidaciones.Text = "0";
                txtRegimencontributivo.Text = "0";
                totalTipo = liquidacionCuotaService.TotalTipo("Contributivo");
                txtRegimensubsidiado.Text = totalTipo.Total.ToString();

            }

        }

        private void btnFiltrarfecha_Click(object sender, EventArgs e)
        {

            string Fecha = txtFecha.Text;
            if (txtFecha.Text != "")
            {
                dgtLiquidaciones.DataSource =liquidacionCuotaService.BuscarPalabra(Fecha);
            }
        }
    }
}   
