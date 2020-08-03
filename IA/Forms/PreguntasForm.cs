using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IA.Forms
{
    public partial class PreguntasForm : Form
    {
        
        public PreguntasForm()
        {
            InitializeComponent();
            
        }
        private List<Encuesta> lstEncuesta = new List<Encuesta>();

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Encuesta encuesta = new Encuesta();

            encuesta.Clima = radFrio.Checked ? encuesta.Clima = radFrio.Text : encuesta.Clima = radCalor.Text;
            encuesta.Cultura = chkCultura.Checked ? encuesta.Cultura = true : encuesta.Cultura = false;
            encuesta.Montañas = chkMontañas.Checked ? encuesta.Montañas = true : encuesta.Montañas = false;
            encuesta.Playa = chkPlaya.Checked ? encuesta.Playa = true : encuesta.Playa = false;
            encuesta.Animales = chkAnimales.Checked ? encuesta.Animales = true : encuesta.Animales = false;
            encuesta.Bosque = chkBosque.Checked ? encuesta.Bosque = true : encuesta.Bosque = false;
            encuesta.Acampar = chkAcampar.Checked ? encuesta.Acampar = true : encuesta.Acampar = false;

            lstEncuesta.Add(encuesta);

            MessageBox.Show(this.DeterminarViaje()).ToString();
            
            this.Limpiar();
            lstEncuesta.Remove(encuesta);
        }

        private Encuesta ObtenerConsulta()
        {
            var consulta = lstEncuesta.FirstOrDefault(x => (x.Clima.Equals("Frio") && x.Montañas)
            || (x.Clima.Equals("Calor") && x.Bosque && x.Acampar)
            || (x.Clima.Equals("Calor") && x.Playa)
            || (x.Clima.Equals("Calor") && x.Cultura && x.Bosque)
            || ((x.Clima.Equals("Calor") || x.Clima.Equals("Frio")) && x.Animales));

            return consulta;
        }
        private readonly string mensaje = "es un lugar recomendado para tí.";
        private string DeterminarViaje()
        {
            if (radFrio.Checked && !chkCultura.Checked && chkMontañas.Checked && !chkPlaya.Checked && !chkAnimales.Checked && !chkBosque.Checked && !chkAcampar.Checked)
            {
                var himalaya = new Encuesta() { Clima = radFrio.Text, Cultura = chkCultura.Checked, Montañas = chkMontañas.Checked, Playa = chkPlaya.Checked, Animales = chkAnimales.Checked, Bosque = chkBosque.Checked, Acampar = chkAcampar.Checked };
                if (this.ObtenerConsulta().Equals(himalaya))
                {
                    return ("Puedes ir a esquiar a las montañas del himalaya..." + mensaje);

                }
            }
            if (radCalor.Checked && !chkCultura.Checked && !chkMontañas.Checked && !chkPlaya.Checked && !chkAnimales.Checked && chkBosque.Checked && chkAcampar.Checked)
            {
                var bosqueChapultepec = new Encuesta() { Clima = radCalor.Text, Cultura = chkCultura.Checked, Montañas = chkMontañas.Checked, Playa = chkPlaya.Checked, Animales = chkAnimales.Checked, Bosque = chkBosque.Checked, Acampar = chkAcampar.Checked };
                if (this.ObtenerConsulta().Equals(bosqueChapultepec))
                {
                    return ("Puedes ir a conocer la fauna del bosque chapultepec..." + mensaje);
                }
            }
            if (radCalor.Checked && !chkCultura.Checked && !chkMontañas.Checked && chkPlaya.Checked && !chkAnimales.Checked && !chkBosque.Checked && !chkAcampar.Checked)
            {
                var cancun = new Encuesta() { Clima = "Calor", Cultura = false, Montañas = false, Playa = true, Animales = false, Bosque = false, Acampar = false };

                if (this.ObtenerConsulta().Equals(cancun))
                {
                    return ("Puedes ir a nadar a cancún..." + mensaje);
                }
            }
            if (radCalor.Checked && chkCultura.Checked && !chkMontañas.Checked && !chkPlaya.Checked && !chkAnimales.Checked && chkBosque.Checked && !chkAcampar.Checked)
            {
                var palenque = new Encuesta() { Clima = radCalor.Text, Cultura = chkCultura.Checked, Montañas = chkMontañas.Checked, Playa = chkPlaya.Checked, Animales = chkAnimales.Checked, Bosque = chkBosque.Checked, Acampar = chkAcampar.Checked };
                if (this.ObtenerConsulta().Equals(palenque))
                {
                    return ("Puedes ir a conocer las piramides de palenque..." + mensaje);
                }
            }
            if (radCalor.Checked && !chkCultura.Checked && !chkMontañas.Checked && !chkPlaya.Checked && chkAnimales.Checked && !chkBosque.Checked && !chkAcampar.Checked)
            {
                var zooNY1 = new Encuesta() { Clima = radCalor.Text, Cultura = chkCultura.Checked, Montañas = chkMontañas.Checked, Playa = chkPlaya.Checked, Animales = chkAnimales.Checked, Bosque = chkBosque.Checked, Acampar = chkAcampar.Checked };
                if (this.ObtenerConsulta().Equals(zooNY1))
                {
                    return ("Puedes ir a ver tus animales favoritos al Zoologico de Nueva York..." + mensaje);
                }
            }
            if (radFrio.Checked && !chkCultura.Checked && !chkMontañas.Checked && !chkPlaya.Checked && chkAnimales.Checked && !chkBosque.Checked && !chkAcampar.Checked)
            {
                var zooNY2 = new Encuesta() { Clima = radFrio.Text, Cultura = chkCultura.Checked, Montañas = chkMontañas.Checked, Playa = chkPlaya.Checked, Animales = chkAnimales.Checked, Bosque = chkBosque.Checked, Acampar = chkAcampar.Checked };
                if (this.ObtenerConsulta().Equals(zooNY2))
                {
                    return ("Puedes ir a ver tus animales favoritos al Zoologico de Nueva York..." + mensaje);
                }             
            }
            return ("Pronto habrá sugerencias para tus gustos...");  
        }
        private void Limpiar()
        {
            chkAcampar.Checked = false;
            chkAnimales.Checked = false;
            chkBosque.Checked = false;
            chkCultura.Checked = false;
            chkMontañas.Checked = false;
            chkPlaya.Checked = false;
            radFrio.Checked = true;
        }
    }
}
