using API.Models;
using DAO;
using DAO.Context;
using Entidades;
using System.Collections.Generic;
using System.Web.Services;

namespace API
{
    /// <summary>
    /// Descripción breve de WebServiceNecesidades
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceNecesidades : System.Web.Services.WebService
    {

        NecesidadesDAO necesidadesDAO;

        public WebServiceNecesidades()
        {
            TpDBContext context = new TpDBContext();
            necesidadesDAO = new NecesidadesDAO(context);
        }

        [WebMethod]
        public List<NecesidadesDTO> get()
        {
            int idSession = 2;
            List<Necesidades> listaNecesidades = necesidadesDAO.TraerTodasLasNecesidadesDelUsuario(idSession);

            List<NecesidadesDTO> necesidadesDTO = NecesidadesDTO.MapearListaEF(listaNecesidades);
            return necesidadesDTO;
        }

    }
}
