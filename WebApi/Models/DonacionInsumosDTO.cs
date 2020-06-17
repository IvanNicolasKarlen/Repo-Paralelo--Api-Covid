using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class DonacionInsumosDTO
    {
        public int IdDonacionInsumo { get; set; }
        public int IdNecesidadDonacionInsumo { get; set; }
        public int IdUsuario { get; set; }
        public int Cantidad { get; set; }
        public virtual NecesidadesDonacionesInsumos NecesidadesDonacionesInsumos { get; set; }
        public virtual Usuarios Usuarios { get; set; }



        public DonacionInsumosDTO()
        {

        }


        public DonacionInsumosDTO(DonacionesInsumos donacionesInsumos)
        {
            this.IdDonacionInsumo = donacionesInsumos.IdDonacionInsumo;
            this.Cantidad = donacionesInsumos.Cantidad;
            this.IdNecesidadDonacionInsumo = donacionesInsumos.IdNecesidadDonacionInsumo;
            this.IdUsuario = donacionesInsumos.IdUsuario;
            this.NecesidadesDonacionesInsumos = donacionesInsumos.NecesidadesDonacionesInsumos;
            this.Usuarios = donacionesInsumos.Usuarios;

        }

        public DonacionInsumosDTO MapearEF()
        {
            DonacionInsumosDTO donacionDTO = new DonacionInsumosDTO();

            donacionDTO.IdDonacionInsumo = this.IdDonacionInsumo;
            donacionDTO.Cantidad = this.Cantidad;
            donacionDTO.IdNecesidadDonacionInsumo = IdNecesidadDonacionInsumo;
            donacionDTO.IdUsuario = this.IdUsuario;
            donacionDTO.NecesidadesDonacionesInsumos = this.NecesidadesDonacionesInsumos;
            donacionDTO.Usuarios = this.Usuarios;

            return donacionDTO;

        }


        public DonacionInsumosDTO MapearDTO(DonacionesInsumos donacion)
        {
            DonacionInsumosDTO donacionDTO = new DonacionInsumosDTO();

            donacionDTO.IdDonacionInsumo = donacion.IdDonacionInsumo;
            donacionDTO.Cantidad = donacion.Cantidad;
            donacionDTO.IdNecesidadDonacionInsumo = donacion.IdNecesidadDonacionInsumo;
            donacionDTO.IdUsuario = donacion.IdUsuario;
            //donacionDTO.NecesidadesDonacionesInsumos = donacion.NecesidadesDonacionesInsumos;
            //donacionDTO.Usuarios = donacion.Usuarios;

            return donacionDTO;

        }


        public ICollection<DonacionInsumosDTO> MapearDTO(ICollection<DonacionesInsumos> donacionesInsumos)
        {
            ICollection<DonacionInsumosDTO> listaDto = new HashSet<DonacionInsumosDTO>();

            foreach (var donInsumos in donacionesInsumos)
            {
                //Le paso los objetos DonacionesInsumos EF y obtengo un objeto DTO
               DonacionInsumosDTO donacionDTO = MapearDTO(donInsumos);

                //Objeto para agregar a la lista
                DonacionInsumosDTO insumosDTO = new DonacionInsumosDTO();

                insumosDTO.IdDonacionInsumo = donacionDTO.IdDonacionInsumo;
                insumosDTO.Cantidad = donacionDTO.Cantidad;
                insumosDTO.IdNecesidadDonacionInsumo = donacionDTO.IdNecesidadDonacionInsumo;
                insumosDTO.IdUsuario = donacionDTO.IdUsuario;
               //insumosDTO.NecesidadesDonacionesInsumos = this.NecesidadesDonacionesInsumos;
                //insumosDTO.Usuarios = donacionDTO.Usuarios;

                listaDto.Add(insumosDTO);
            }

            return listaDto;
        }


        public List<DonacionesInsumos> MapearListEF(ICollection<DonacionInsumosDTO> donacionesInsumos)
        {
            List<DonacionesInsumos> listaDto = new List<DonacionesInsumos>();

            foreach (var donInsumos in donacionesInsumos)
            {
                DonacionesInsumos insumosDTO = new DonacionesInsumos();

                insumosDTO.IdDonacionInsumo = this.IdDonacionInsumo;
                insumosDTO.Cantidad = this.Cantidad;
                insumosDTO.IdNecesidadDonacionInsumo = this.IdNecesidadDonacionInsumo;
                insumosDTO.IdUsuario = this.IdUsuario;
                insumosDTO.NecesidadesDonacionesInsumos = this.NecesidadesDonacionesInsumos;
                insumosDTO.Usuarios = this.Usuarios;

                listaDto.Add(insumosDTO);
            }

            return listaDto;
        }


    }
}