using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BLL;

namespace TallerPractica2GUI
{
    public partial class Form1 : Form

    {
        LiquidacionCuotaModeradoraService liquidacionCuotaModeradoraService;
        public Form1()
        {
            InitializeComponent();
            liquidacionCuotaModeradoraService = new LiquidacionCuotaModeradoraService();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            Liquidacion liquidacion;
            string Numeroliquidacion, Tipodeafiliacion, Identificacionpaciente;
            Numeroliquidacion = txtnumerodeliquidacion.Text;
            Identificacionpaciente = txtidentificaciondelpaciente.Text;
            Tipodeafiliacion = cmbtipodeafilacion.Text;
            if (Tipodeafiliacion.Equals("Regimen Contributivo"))
            {
                liquidacion = new RegimenContributivo();
                liquidacion.SalarioDevengado = Convert.ToDecimal(txtSalariodevengado.Text);
            }
            else
            {
                liquidacion = new RegimenSubsidiado();
            }
            liquidacion.FechaAfiliacion = Convert.ToDateTime(txtFechadeAfiliacion.Text);
            liquidacion.ValorServicio = Convert.ToDecimal(txtValorservicio.Text);
            liquidacion.IdentificacionPaciente = Identificacionpaciente;
            liquidacion.NumeroLiquidacion = Numeroliquidacion;
            liquidacion.TipoAfiliacion = Tipodeafiliacion;
            liquidacion.LiquidardarCuota();
            liquidacion.SalarioDevengado = liquidacion.SalarioDevengado;

            txtTopemaximo.Text = liquidacion.TopeMaximo.ToString();
            txtCuotamoderadora.Text = liquidacion.CuotaModerada.ToString();
            txtCuotamoderadorareal.Text = liquidacion.CuotaReal.ToString();
            txtTarifa.Text = liquidacion.Tarifa.ToString();
            string mensaje = liquidacionCuotaModeradoraService.Guardar(liquidacion);
            MessageBox.Show(mensaje, "Mensaje de Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpiar();
        }
        public void Limpiar()
        {
            txtnumerodeliquidacion.Text = " ";
            txtFechadeAfiliacion.Text = "";
            txtidentificaciondelpaciente.Text = "";
            txtSalariodevengado.Text = "";
            txtTarifa.Text = "";
            txtCuotamoderadora.Text = "";
            txtCuotamoderadorareal.Text = "";
            txtValorservicio.Text = "";
            txtTopemaximo.Text = "";



        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string Numeroliquidacion = txtnumerodeliquidacion.Text;
            if (Numeroliquidacion != "")
            {
                RespuestaEncontrado respuesta = new RespuestaEncontrado();
                respuesta = liquidacionCuotaModeradoraService.Buscar(Numeroliquidacion);
                if (respuesta.liquidacion != null)
                {
                    txtidentificaciondelpaciente.Text = respuesta.liquidacion.IdentificacionPaciente;
                    cmbtipodeafilacion.Text = respuesta.liquidacion.TipoAfiliacion;
                    txtidentificaciondelpaciente.Text = respuesta.liquidacion.SalarioDevengado.ToString();
                    txtValorservicio.Text = respuesta.liquidacion.ValorServicio.ToString();
                    txtTarifa.Text = respuesta.liquidacion.Tarifa.ToString();
                    txtTopemaximo.Text = respuesta.liquidacion.TopeMaximo.ToString();
                    txtCuotamoderadorareal.Text = respuesta.liquidacion.CuotaReal.ToString();
                    txtCuotamoderadora.Text = respuesta.liquidacion.CuotaModerada.ToString();
                }
                else
                {
                    MessageBox.Show(respuesta.Mensaje);
                }
            }
           
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string Numeroliquidacion = txtnumerodeliquidacion.Text;
            if (Numeroliquidacion != "")
            {
                RespuestaEncontrado respuesta = new RespuestaEncontrado();
                respuesta = liquidacionCuotaModeradoraService.Buscar(Numeroliquidacion);
                if (respuesta.liquidacion != null)
                {
                    txtidentificaciondelpaciente.Text = respuesta.liquidacion.IdentificacionPaciente;
                    cmbtipodeafilacion.Text = respuesta.liquidacion.TipoAfiliacion;
                    txtSalariodevengado.Text = respuesta.liquidacion.SalarioDevengado.ToString();
                    txtValorservicio.Text = respuesta.liquidacion.ValorServicio.ToString();
                    txtTarifa.Text = respuesta.liquidacion.Tarifa.ToString();
                    txtTopemaximo.Text = respuesta.liquidacion.TopeMaximo.ToString();
                    txtCuotamoderadorareal.Text = respuesta.liquidacion.CuotaReal.ToString();
                    txtCuotamoderadora.Text = respuesta.liquidacion.CuotaModerada.ToString();
                    string mensaje = liquidacionCuotaModeradoraService.Eliminar(Numeroliquidacion);
                    MessageBox.Show(mensaje, "Mensaje de Eliminacion", MessageBoxButtons.OKCancel);
                    Limpiar();
                }


                else
                {
                    MessageBox.Show(respuesta.Mensaje);
                }
            }
        }
                
         private void btnConsultar_Click(object sender, EventArgs e)
        {
            FrmConsultarLiquidaciones frmConsultarLiquidaciones = new FrmConsultarLiquidaciones();
            frmConsultarLiquidaciones.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string numeroLiquidacion = txtnumerodeliquidacion.Text;
            if (numeroLiquidacion != "")
            {
                RespuestaEncontrado respuesta = new RespuestaEncontrado();
                respuesta =liquidacionCuotaModeradoraService.Buscar(numeroLiquidacion);
                if (respuesta.liquidacion != null)
                {
                    respuesta.liquidacion.ValorServicio = Convert.ToInt32(txtValorservicio.Text);
                    txtValorservicio.Text = respuesta.liquidacion.ValorServicio.ToString();

                    respuesta.liquidacion.LiquidardarCuota();
                    txtTarifa.Text = respuesta.liquidacion.Tarifa.ToString();
                    txtTopemaximo.Text = respuesta.liquidacion.TopeMaximo.ToString();
                    txtCuotamoderadorareal.Text = respuesta.liquidacion.CuotaReal.ToString();
                    txtCuotamoderadora.Text = respuesta.liquidacion.CuotaModerada.ToString();
                    string mensaje =liquidacionCuotaModeradoraService.Modificar(respuesta.liquidacion);
                        MessageBox.Show(mensaje, "Mensaje de Modificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                    }
                }


            }
        }
    }

     
