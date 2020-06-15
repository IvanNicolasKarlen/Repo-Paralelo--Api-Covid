using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class NecesidadesDTO
    {


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

        public virtual UsuarioDTO Usuarios { get; set; }

        public List<NecesidadesDonacionesInsumos> NecesidadesDonacionesInsumos { get; set; }

        //public virtual ICollection<Denuncias> Denuncias { get; set; }


        //public virtual ICollection<NecesidadesDonacionesMonetarias> NecesidadesDonacionesMonetarias { get; set; }
        //public virtual ICollection<NecesidadesReferencias> NecesidadesReferencias { get; set; }
        //public virtual ICollection<NecesidadesValoraciones> NecesidadesValoraciones { get; set; }



        public NecesidadesDTO()
        {

        }


        public NecesidadesDTO(Necesidades necesidades, bool mapearDatos = true)
        {
            this.Valoracion = necesidades.Valoracion;
            this.TelefonoContacto = necesidades.TelefonoContacto;
            this.Nombre = necesidades.Nombre;
            this.IdUsuarioCreador = necesidades.IdUsuarioCreador;
            this.IdNecesidad = necesidades.IdNecesidad;
            this.Foto = necesidades.Foto;
            this.FechaFin = necesidades.FechaFin;
            this.FechaCreacion = necesidades.FechaCreacion;
            this.Estado = necesidades.Estado;
            this.Descripcion = necesidades.Descripcion;
            if (mapearDatos && (necesidades.Usuarios != null))
            {
                this.Usuarios = new UsuarioDTO(necesidades.Usuarios);
            }
            if (mapearDatos && (necesidades.NecesidadesDonacionesInsumos.Count > 0))
            {
                foreach (var donacionInsumo in necesidades.NecesidadesDonacionesInsumos)
                {
                    NecesidadesDonacionesInsumosDTO insumosDTO = new NecesidadesDonacionesInsumosDTO(donacionInsumo);
                    if(insumosDTO.MapearEF() != null)
                    {
                        NecesidadesDonacionesInsumos necesidadesDonaciones = new NecesidadesDonacionesInsumos();
                        necesidadesDonaciones = insumosDTO.MapearEF();
                        this.NecesidadesDonacionesInsumos.Add(necesidadesDonaciones);
                    }
                    
                }
               
            }

        }
        // 
        //this.NecesidadesValoraciones = necesidadesDTO.NecesidadesValoraciones;
        //this.NecesidadesReferencias = necesidadesDTO.NecesidadesReferencias;
        //this.NecesidadesDonacionesMonetarias = necesidadesDTO.NecesidadesDonacionesMonetarias;

        //this.Usuarios = necesidadesDTO.Usuarios;
        //this.TipoDonacion = necesidadesDTO.TipoDonacion;
        // this.Denuncias = necesidadesDTO.Denuncias;



        public Necesidades mapearEF()
        {

            Necesidades necesidadNueva = new Necesidades();
            UsuarioDTO usuarioDTO = new UsuarioDTO();
            NecesidadesDonacionesInsumosDTO necesidadesDonacionesInsumosDTO = new NecesidadesDonacionesInsumosDTO();


            necesidadNueva.Valoracion = this.Valoracion;
            necesidadNueva.TelefonoContacto = this.TelefonoContacto;
            necesidadNueva.Nombre = this.Nombre;
            necesidadNueva.IdUsuarioCreador = this.IdUsuarioCreador;
            necesidadNueva.IdNecesidad = this.IdNecesidad;
            necesidadNueva.Foto = this.Foto;
            necesidadNueva.FechaFin = this.FechaFin;
            necesidadNueva.FechaCreacion = this.FechaCreacion;
            necesidadNueva.Estado = this.Estado;
            necesidadNueva.Descripcion = this.Descripcion;
            necesidadNueva.Usuarios = usuarioDTO.MapearEF(); 
            necesidadNueva.NecesidadesDonacionesInsumos.Add(necesidadesDonacionesInsumosDTO.MapearEF()); ;

            //necesidadNueva.NecesidadesValoraciones = this.NecesidadesValoraciones;
            //necesidadNueva.NecesidadesReferencias = this.NecesidadesReferencias;
            //necesidadNueva.NecesidadesDonacionesMonetarias = this.NecesidadesDonacionesMonetarias;


            // necesidadNueva.TipoDonacion = this.TipoDonacion;
            //necesidadNueva.Denuncias = this.Denuncias;

            return necesidadNueva;
        }


        public Usuarios mapearDTOaUsuario(UsuarioDTO usuarioDTO)
        {
            Usuarios usuario = new Usuarios();
            usuario.IdUsuario = usuarioDTO.IdUsuario;
            usuario.Activo = usuarioDTO.Activo;
            usuario.Apellido = usuarioDTO.Apellido;
            usuario.Email = usuarioDTO.Email;
            usuario.FechaCreacion = usuarioDTO.FechaCreacion;
            usuario.FechaNacimiento = usuarioDTO.FechaNacimiento;
            usuario.Foto = usuarioDTO.Foto;
            usuario.Nombre = usuarioDTO.Nombre;
            usuario.Password = usuarioDTO.Password;
            usuario.TipoUsuario = usuarioDTO.TipoUsuario;
            usuario.Token = usuarioDTO.Token;
            usuario.UserName = usuarioDTO.UserName;


            return usuario;
        }


        //public List<NecesidadesDonacionesInsumos> mapearDTOaNecesidadesDonacionesInsumos(List<NecesidadesDonacionesInsumosDTO> insumosDTO)
        //{
        //    List<NecesidadesDonacionesInsumos> donacionesInsumos = new List<NecesidadesDonacionesInsumos>();

        //    foreach (var dto in insumosDTO)
        //    {
        //        foreach (var insumos in donacionesInsumos)
        //        {

        //            insumos.Cantidad = dto.Cantidad;
        //            insumos.DonacionesInsumos = dto.DonacionesInsumos;
        //            insumos.IdNecesidad = dto.IdNecesidad;
        //            insumos.IdNecesidadDonacionInsumo = dto.IdNecesidadDonacionInsumo;
        //            insumos.Necesidades = dto.Necesidades;
        //            insumos.Nombre = dto.Nombre;
        //        }
        //    }
        //    return donacionesInsumos;
        //}






        public static List<NecesidadesDTO> MapearListaEF(List<Necesidades> necesidades, bool mapearDatos = true)
        {
            List<NecesidadesDTO> necesidadesDTO = new List<NecesidadesDTO>();

            foreach (var nec in necesidades)
            {

                necesidadesDTO.Add(new NecesidadesDTO(nec, mapearDatos));
            }

            return necesidadesDTO;
        }


    }
}