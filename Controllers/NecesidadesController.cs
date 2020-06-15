using API.Models;
using DAO;
using DAO.Context;
using Entidades;
using System.Collections.Generic;
using System.Web.Http;

namespace API.Controllers
{
    public class NecesidadesController : ApiController
    {
        NecesidadesDAO necesidadesDAO;

        public NecesidadesController()
        {
            TpDBContext context = new TpDBContext();
            necesidadesDAO = new NecesidadesDAO(context);
        }

        public List<NecesidadesDTO> get()
        {
            int idSession = 2;
            List<Necesidades> listaNecesidades = necesidadesDAO.TraerTodasLasNecesidadesDelUsuario(idSession);

            List<NecesidadesDTO> necesidadesDTO = NecesidadesDTO.MapearListaEF(listaNecesidades);
            return necesidadesDTO;
        }


    }
}
