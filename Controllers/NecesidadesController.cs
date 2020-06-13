﻿using ApiHistorialNecesidades.Models;
using DAO;
using DAO.Context;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiHistorialNecesidades.Controllers
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

            List<NecesidadesDTO> necesidadesDTO = NecesidadesDTO.mapeoListaADTO(listaNecesidades);
            return necesidadesDTO;
        }

        
    }
}
