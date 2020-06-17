using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class DonacionesMonetariasDTO
    {
        public int IdDonacionMonetaria { get; set; }
        public int IdNecesidadDonacionMonetaria { get; set; }
        public int IdUsuario { get; set; }
        public decimal Dinero { get; set; }
        public string ArchivoTransferencia { get; set; }
        public System.DateTime FechaCreacion { get; set; }

        public virtual NecesidadesDonacionesMonetarias NecesidadesDonacionesMonetarias { get; set; }
        public virtual Usuarios Usuarios { get; set; }




        public DonacionesMonetariasDTO()
        {

        }


        public DonacionesMonetariasDTO(DonacionesMonetarias donacionMonetaria)
        {
            this.IdDonacionMonetaria = donacionMonetaria.IdDonacionMonetaria;
            this.IdNecesidadDonacionMonetaria = donacionMonetaria.IdNecesidadDonacionMonetaria;
            this.IdUsuario = donacionMonetaria.IdUsuario;
            this.Dinero = donacionMonetaria.Dinero;
            this.ArchivoTransferencia = donacionMonetaria.ArchivoTransferencia;
            this.FechaCreacion = donacionMonetaria.FechaCreacion;
            this.NecesidadesDonacionesMonetarias = donacionMonetaria.NecesidadesDonacionesMonetarias;
            this.Usuarios = donacionMonetaria.Usuarios;

        }


        public DonacionesMonetariasDTO MapearEF()
        {
            DonacionesMonetariasDTO donacionDTO = new DonacionesMonetariasDTO();

            donacionDTO.IdDonacionMonetaria = this.IdDonacionMonetaria;
            donacionDTO.IdNecesidadDonacionMonetaria = this.IdNecesidadDonacionMonetaria;
            donacionDTO.Dinero = this.Dinero;
            donacionDTO.IdUsuario = this.IdUsuario;
            donacionDTO.ArchivoTransferencia = this.ArchivoTransferencia;
            donacionDTO.FechaCreacion = this.FechaCreacion;
            donacionDTO.NecesidadesDonacionesMonetarias = this.NecesidadesDonacionesMonetarias;
            donacionDTO.Usuarios = this.Usuarios;

            return donacionDTO;
        }


        public DonacionesMonetariasDTO MapearDTO(DonacionesMonetarias donacion)
        {
            DonacionesMonetariasDTO donacionDTO = new DonacionesMonetariasDTO();

            donacionDTO.IdDonacionMonetaria = donacion.IdDonacionMonetaria;
            donacionDTO.IdNecesidadDonacionMonetaria = donacion.IdNecesidadDonacionMonetaria;
            donacionDTO.Dinero = donacion.Dinero;
            donacionDTO.IdUsuario = donacion.IdUsuario;
            donacionDTO.ArchivoTransferencia = donacion.ArchivoTransferencia;
            donacionDTO.FechaCreacion = donacion.FechaCreacion;
            //donacionDTO.NecesidadesDonacionesInsumos = donacion.NecesidadesDonacionesInsumos;
            //donacionDTO.Usuarios = donacion.Usuarios;

            return donacionDTO;

        }


        public ICollection<DonacionesMonetariasDTO> MapearDTO(ICollection<DonacionesMonetarias> donacionesMonetarias)
        {
            ICollection<DonacionesMonetariasDTO> listaDto = new HashSet<DonacionesMonetariasDTO>();

            foreach (var donMonetarias in donacionesMonetarias)
            {
                //Le paso los objetos DonacionesInsumos EF y obtengo un objeto DTO
                DonacionesMonetariasDTO donacionDTO = MapearDTO(donMonetarias);

                //Objeto para agregar a la lista
                DonacionesMonetariasDTO monetariaDTO = new DonacionesMonetariasDTO();

                monetariaDTO.IdDonacionMonetaria = donacionDTO.IdDonacionMonetaria;
                monetariaDTO.IdNecesidadDonacionMonetaria = donacionDTO.IdNecesidadDonacionMonetaria;
                monetariaDTO.Dinero = donacionDTO.Dinero;
                monetariaDTO.IdUsuario = donacionDTO.IdUsuario;
                monetariaDTO.ArchivoTransferencia = donacionDTO.ArchivoTransferencia;
                monetariaDTO.FechaCreacion = donacionDTO.FechaCreacion;
                //insumosDTO.NecesidadesDonacionesInsumos = this.NecesidadesDonacionesInsumos;
                //insumosDTO.Usuarios = donacionDTO.Usuarios;

                listaDto.Add(monetariaDTO);
            }

            return listaDto;
        }


        public List<DonacionesMonetarias> MapearListEF(ICollection<DonacionesMonetariasDTO> donacionesMonetarias)
        {
            List<DonacionesMonetarias> listaDto = new List<DonacionesMonetarias>();

            foreach (var donMonetarias in donacionesMonetarias)
            {
                DonacionesMonetarias monetariasDTO = new DonacionesMonetarias();

                monetariasDTO.IdDonacionMonetaria = donMonetarias.IdDonacionMonetaria;
                monetariasDTO.IdNecesidadDonacionMonetaria = donMonetarias.IdNecesidadDonacionMonetaria;
                monetariasDTO.Dinero = donMonetarias.Dinero;
                monetariasDTO.IdUsuario = donMonetarias.IdUsuario;
                monetariasDTO.ArchivoTransferencia = donMonetarias.ArchivoTransferencia;
                monetariasDTO.FechaCreacion = donMonetarias.FechaCreacion;
                //insumosDTO.NecesidadesDonacionesInsumos = this.NecesidadesDonacionesInsumos;
                //insumosDTO.Usuarios = donacionDTO.Usuarios;

                listaDto.Add(monetariasDTO);
            }

            return listaDto;
        }




    }
}