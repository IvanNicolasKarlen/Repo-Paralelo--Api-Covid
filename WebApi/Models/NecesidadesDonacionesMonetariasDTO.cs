using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class NecesidadesDonacionesMonetariasDTO
    {

        public int IdNecesidadDonacionMonetaria { get; set; }
        public int IdNecesidad { get; set; }
        public decimal Dinero { get; set; }
        public string CBU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DonacionesMonetariasDTO> DonacionesMonetarias { get; set; }
        public virtual NecesidadesDTO Necesidades { get; set; }

        public NecesidadesDonacionesMonetariasDTO()
        {

        }


        public NecesidadesDonacionesMonetariasDTO(NecesidadesDonacionesMonetarias necesidadesDonacionesMonetariasEF, bool mapearRelacionadas = true)
        {
            DonacionesMonetariasDTO donacionInsumosDTO = new DonacionesMonetariasDTO();

            this.IdNecesidadDonacionMonetaria = necesidadesDonacionesMonetariasEF.IdNecesidadDonacionMonetaria;
            this.IdNecesidad = necesidadesDonacionesMonetariasEF.IdNecesidad;
            this.Dinero = necesidadesDonacionesMonetariasEF.Dinero;
            this.CBU = necesidadesDonacionesMonetariasEF.CBU;

            if (mapearRelacionadas && necesidadesDonacionesMonetariasEF != null)
            {
                this.Necesidades = new NecesidadesDTO(necesidadesDonacionesMonetariasEF.Necesidades);
            }

            if (necesidadesDonacionesMonetariasEF.DonacionesMonetarias.Count > 0)
            {
                this.DonacionesMonetarias = donacionInsumosDTO.MapearDTO(necesidadesDonacionesMonetariasEF.DonacionesMonetarias);
            }

        }



         public static List<NecesidadesDonacionesMonetariasDTO> MapearListaEF(List<NecesidadesDonacionesMonetarias> NecesidadesDonacionesMonetariasEF, bool mapearRelacionadas = true)
        {
            List<NecesidadesDonacionesMonetariasDTO> necesidadesDonacionesMonetariasDTO = new List<NecesidadesDonacionesMonetariasDTO>();

            //mapeamos las necesidades a DTO y las agregamos a la lista que quiero retornar
            foreach (NecesidadesDonacionesMonetarias necesidadDonacionMonetariaEF in NecesidadesDonacionesMonetariasEF)
            {
                necesidadesDonacionesMonetariasDTO.Add(new NecesidadesDonacionesMonetariasDTO(necesidadDonacionMonetariaEF, mapearRelacionadas));
            }

            return necesidadesDonacionesMonetariasDTO;
        }



    }
}