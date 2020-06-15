using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class NecesidadesDonacionesInsumosDTO
    {
        public int IdNecesidadDonacionInsumo { get; set; }
        public int IdNecesidad { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }

        public List<DonacionesInsumos> DonacionesInsumos { get; set; }
        public Necesidades Necesidades { get; set; }



        public NecesidadesDonacionesInsumosDTO()
        {

        }

        public NecesidadesDonacionesInsumosDTO(NecesidadesDonacionesInsumos necesidadesDonaciones)
        {

            this.IdNecesidadDonacionInsumo = necesidadesDonaciones.IdNecesidadDonacionInsumo;
            this.IdNecesidad = necesidadesDonaciones.IdNecesidad;
            this.Nombre = necesidadesDonaciones.Nombre;
            this.Cantidad = necesidadesDonaciones.Cantidad;
            if (necesidadesDonaciones.DonacionesInsumos != null)
            {
                this.DonacionesInsumos = necesidadesDonaciones.DonacionesInsumos;

            }
            this.Necesidades = necesidadesDonaciones.Necesidades;

        }


        public NecesidadesDonacionesInsumos MapearEF()
        {
            NecesidadesDonacionesInsumos necesidadesDonacionesInsumos = new NecesidadesDonacionesInsumos();

            necesidadesDonacionesInsumos.IdNecesidad = this.IdNecesidad;
            necesidadesDonacionesInsumos.IdNecesidadDonacionInsumo = this.IdNecesidadDonacionInsumo;
            necesidadesDonacionesInsumos.Necesidades = this.Necesidades;
            necesidadesDonacionesInsumos.Nombre = this.Nombre;
            necesidadesDonacionesInsumos.Cantidad = this.Cantidad;
            if (this.DonacionesInsumos.Count > 0)
            {
                necesidadesDonacionesInsumos.DonacionesInsumos = this.DonacionesInsumos;
            }
            return necesidadesDonacionesInsumos;
        }


    }
}