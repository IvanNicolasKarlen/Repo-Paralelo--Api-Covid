using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class UsuarioDTO
    {

        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public System.DateTime FechaNacimiento { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Foto { get; set; }
        public int TipoUsuario { get; set; }
        public System.DateTime FechaCreacion { get; set; }
        public bool Activo { get; set; }
        public string Token { get; set; }

        public virtual ICollection<Denuncias> Denuncias { get; set; }
        public virtual ICollection<DonacionesInsumos> DonacionesInsumos { get; set; }
        public virtual ICollection<DonacionesMonetarias> DonacionesMonetarias { get; set; }
        public virtual ICollection<Necesidades> Necesidades { get; set; }
        public virtual ICollection<NecesidadesValoraciones> NecesidadesValoraciones { get; set; }




        public UsuarioDTO()
        {

        }

        public UsuarioDTO(UsuarioDTO usuario)
        {
            this.IdUsuario = usuario.IdUsuario;
            this.Nombre = usuario.Nombre;
            this.Apellido = usuario.Apellido;
            this.FechaNacimiento = usuario.FechaNacimiento;
            this.UserName = usuario.UserName;
            this.Email = usuario.Email;
            this.Password = usuario.Password;
            this.Foto = usuario.Foto;
            this.TipoUsuario = usuario.TipoUsuario;
            this.FechaCreacion = usuario.FechaCreacion;
            this.Activo = usuario.Activo;
            this.Token = usuario.Token;
            //this.Necesidades = NecesidadesDTO.MapearListaEF(usuario.Necesidades.ToList(), false);
        }

        public Usuarios MapearEF()
        {
            Usuarios usuario = new Usuarios();

            usuario.IdUsuario = this.IdUsuario;
            usuario.Nombre = this.Nombre;
            usuario.Apellido = this.Apellido;
            usuario.FechaNacimiento = this.FechaNacimiento;
            usuario.UserName = this.UserName;
            usuario.Email = this.Email;
            usuario.Password = this.Password;
            usuario.Foto = this.Foto;
            usuario.TipoUsuario = this.TipoUsuario;
            usuario.FechaCreacion = this.FechaCreacion;
            usuario.Activo = this.Activo;
            usuario.Token = this.Token;
            return usuario;
        }





    }
}