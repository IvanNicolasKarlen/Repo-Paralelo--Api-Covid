using DAO;
using DAO.Context;
using Entidades;
using Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class NecesidadesController : ApiController
    {
        
        ServicioNecesidad necesidadServicio;
        NecesidadesDAO necesidadesDAO;

        public NecesidadesController()
        {
            TpDBContext ctx = new TpDBContext();
          /*NO VA*/  necesidadesDAO = new NecesidadesDAO(ctx);
            necesidadServicio = new ServicioNecesidad(ctx);
        }
        public List<NecesidadesDTO> Get()
        {

            int idSession = 2;
            List<Necesidades> listaNecesidadesEF = necesidadesDAO.TraerTodasLasNecesidadesDelUsuario(idSession);

            //lista que obtengo de la bd
            // List<Necesidades> listaNecesidadesEF = necesidadServicio.ListarTodasLasNecesidades();

            //devuelve una lista de necesidades DTO
            return NecesidadesDTO.MapearListaEF(listaNecesidadesEF);
        }

    }
}
