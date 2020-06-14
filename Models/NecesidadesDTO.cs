using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class NecesidadesDTO
    {
        public NecesidadesDTO()
        {
            //this.Denuncias = new HashSet<Denuncias>();
            //this.NecesidadesDonacionesInsumos = new HashSet<NecesidadesDonacionesInsumos>();
            //this.NecesidadesDonacionesMonetarias = new HashSet<NecesidadesDonacionesMonetarias>();
            //this.NecesidadesReferencias = new HashSet<NecesidadesReferencias>();
            //this.NecesidadesValoraciones = new HashSet<NecesidadesValoraciones>();
        }

        public int IdNecesidad { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public System.DateTime FechaCreacion { get; set; }
        public System.DateTime FechaFin { get; set; }
        public string TelefonoContacto { get; set; }
        public int TipoDonacion { get; set; }
        public string Foto { get; set; }
        public int IdUsuarioCreador { get; set; }
        public int Estado { get; set; }
        public Nullable<decimal> Valoracion { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Denuncias> Denuncias { get; set; }
        //public virtual Usuarios Usuarios { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<NecesidadesDonacionesInsumos> NecesidadesDonacionesInsumos { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<NecesidadesDonacionesMonetarias> NecesidadesDonacionesMonetarias { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<NecesidadesReferencias> NecesidadesReferencias { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<NecesidadesValoraciones> NecesidadesValoraciones { get; set; }



        public NecesidadesDTO(Necesidades necesidadesDTO)
        {
            this.Valoracion = necesidadesDTO.Valoracion;
            //this.Usuarios = necesidadesDTO.Usuarios;
            //this.TipoDonacion = necesidadesDTO.TipoDonacion;
            this.TelefonoContacto = necesidadesDTO.TelefonoContacto;
            this.Nombre = necesidadesDTO.Nombre;
            //this.NecesidadesValoraciones = necesidadesDTO.NecesidadesValoraciones;
            //this.NecesidadesReferencias = necesidadesDTO.NecesidadesReferencias;
            //this.NecesidadesDonacionesMonetarias = necesidadesDTO.NecesidadesDonacionesMonetarias;
            // this.NecesidadesDonacionesInsumos = necesidadesDTO.NecesidadesDonacionesInsumos;
            this.IdUsuarioCreador = necesidadesDTO.IdUsuarioCreador;
            this.IdNecesidad = necesidadesDTO.IdNecesidad;
            this.Foto = necesidadesDTO.Foto;
            this.FechaFin = necesidadesDTO.FechaFin;
            this.FechaCreacion = necesidadesDTO.FechaCreacion;
            this.Estado = necesidadesDTO.Estado;
            this.Descripcion = necesidadesDTO.Descripcion;
            // this.Denuncias = necesidadesDTO.Denuncias;
        }


        public Necesidades mapearEF()
        {

            Necesidades necesidadNueva = new Necesidades();

            necesidadNueva.Valoracion = this.Valoracion;
            // necesidadNueva.Usuarios = this.Usuarios;
            // necesidadNueva.TipoDonacion = this.TipoDonacion;
            necesidadNueva.TelefonoContacto = this.TelefonoContacto;
            necesidadNueva.Nombre = this.Nombre;
            //necesidadNueva.NecesidadesValoraciones = this.NecesidadesValoraciones;
            //necesidadNueva.NecesidadesReferencias = this.NecesidadesReferencias;
            //necesidadNueva.NecesidadesDonacionesMonetarias = this.NecesidadesDonacionesMonetarias;
            //necesidadNueva.NecesidadesDonacionesInsumos = this.NecesidadesDonacionesInsumos;
            necesidadNueva.IdUsuarioCreador = this.IdUsuarioCreador;
            necesidadNueva.IdNecesidad = this.IdNecesidad;
            necesidadNueva.Foto = this.Foto;
            necesidadNueva.FechaFin = this.FechaFin;
            necesidadNueva.FechaCreacion = this.FechaCreacion;
            necesidadNueva.Estado = this.Estado;
            necesidadNueva.Descripcion = this.Descripcion;
            //necesidadNueva.Denuncias = this.Denuncias;

            return necesidadNueva;
        }


        public static List<NecesidadesDTO> MapearListaEF(List<Necesidades> necesidades)
        {
            List<NecesidadesDTO> necesidadesDTO = new List<NecesidadesDTO>();

            foreach (var nec in necesidades)
            {

                necesidadesDTO.Add(new NecesidadesDTO(nec));
            }

            return necesidadesDTO;
        }


    }
}