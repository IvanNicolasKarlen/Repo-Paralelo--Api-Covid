using Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class NecesidadesDonacionesInsumosDTO
    {
        public int IdNecesidadDonacionInsumo { get; set; }
        public int IdNecesidad { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
          public virtual ICollection<DonacionInsumosDTO> DonacionesInsumos { get; set; }
        public virtual NecesidadesDTO Necesidades { get; set; }

        public NecesidadesDonacionesInsumosDTO()
        {

        }
        public NecesidadesDonacionesInsumosDTO(NecesidadesDonacionesInsumos necesidadesDonacionesInsumosEF, bool mapearRelacionadas = true)
        {
            DonacionInsumosDTO donacionInsumosDTO = new DonacionInsumosDTO();

            this.IdNecesidadDonacionInsumo = necesidadesDonacionesInsumosEF.IdNecesidadDonacionInsumo;
            this.Nombre = necesidadesDonacionesInsumosEF.Nombre;
            if (mapearRelacionadas && necesidadesDonacionesInsumosEF != null)
            {
                this.Necesidades = new NecesidadesDTO(necesidadesDonacionesInsumosEF.Necesidades);
            }

            if (necesidadesDonacionesInsumosEF.DonacionesInsumos.Count > 0)
            {
                foreach (var donInsumos in necesidadesDonacionesInsumosEF.DonacionesInsumos)
                {
                    this.DonacionesInsumos = donacionInsumosDTO.MapearDTO(necesidadesDonacionesInsumosEF.DonacionesInsumos);
                }

            }

        }


        public NecesidadesDonacionesInsumos MapearEF()
        {
            NecesidadesDonacionesInsumos necesidades = new NecesidadesDonacionesInsumos();
            DonacionInsumosDTO donacionInsumosDTO = new DonacionInsumosDTO();
            necesidades.IdNecesidadDonacionInsumo = this.IdNecesidadDonacionInsumo;
            necesidades.Nombre = this.Nombre;
            if (this.Necesidades != null)
            {
                necesidades.Necesidades = this.Necesidades.MapearEF();
            }
            necesidades.DonacionesInsumos = donacionInsumosDTO.MapearListEF(this.DonacionesInsumos);

            return necesidades;

        }

        public static List<NecesidadesDonacionesInsumos> MapearListaDTO(List<NecesidadesDonacionesInsumosDTO> NecesidadesDonacionesInsumosDTO)
        {
            List<NecesidadesDonacionesInsumos> liNecesidadesDonacionesInsumosNecesidadesEF = new List<NecesidadesDonacionesInsumos>();

            //mapeamos las necesidades a EF y las agregamos a la lista que quiero retornar
            foreach (NecesidadesDonacionesInsumosDTO necesidadDonacionInsumoDTO in NecesidadesDonacionesInsumosDTO)
            {
                liNecesidadesDonacionesInsumosNecesidadesEF.Add(necesidadDonacionInsumoDTO.MapearEF());
            }

            return liNecesidadesDonacionesInsumosNecesidadesEF;
        }

        public static List<NecesidadesDonacionesInsumosDTO> MapearListaEF(List<NecesidadesDonacionesInsumos> NecesidadesDonacionesInsumosEF, bool mapearRelacionadas = true)
        {
            List<NecesidadesDonacionesInsumosDTO> necesidadesDonacionesInsumosDTO = new List<NecesidadesDonacionesInsumosDTO>();

            //mapeamos las necesidades a DTO y las agregamos a la lista que quiero retornar
            foreach (NecesidadesDonacionesInsumos necesidadDonacionInsumoEF in NecesidadesDonacionesInsumosEF)
            {
                necesidadesDonacionesInsumosDTO.Add(new NecesidadesDonacionesInsumosDTO(necesidadDonacionInsumoEF, mapearRelacionadas));
            }

            return necesidadesDonacionesInsumosDTO;
        }
    }
}