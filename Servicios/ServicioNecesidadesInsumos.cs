﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAO;
using Entidades.Metadata;
using DAO.Context;

namespace Servicios
{
    public class ServicioNecesidadesInsumos
    {
        NecesidadesDonacionesInsumosDAO insumosDAO;
        NecesidadesDAO necesidadesDAO;
        ServicioNecesidad servicioNecesidad;

        public ServicioNecesidadesInsumos(TpDBContext context)
        {
             insumosDAO = new NecesidadesDonacionesInsumosDAO(context);
             necesidadesDAO = new NecesidadesDAO(context);
             servicioNecesidad = new ServicioNecesidad(context);
        }

        public void GuardarInsumos(NecesidadesDonacionesInsumosMetadata insumoMeta)
        {
            NecesidadesDonacionesInsumos insumo = new NecesidadesDonacionesInsumos()
            {
                IdNecesidad = insumoMeta.IdNecesidad,
                Necesidades = insumoMeta.Necesidades,
                Nombre = insumoMeta.Nombre,
                Cantidad = insumoMeta.Cantidad
            };
            insumosDAO.Crear(insumo);
        }

        public NecesidadesDonacionesInsumos obtenerPorIdNecesidad(int idNecesidad)
        {   
            //Obtengo mediante el id
            Necesidades necesidadBD = necesidadesDAO.ObtenerPorID(idNecesidad);
            //Se obtienen las donaciones insumos
            NecesidadesDonacionesInsumos necInsumos = insumosDAO.ObtenerPorIDNecesidad(necesidadBD.IdNecesidad);
            return necInsumos;
        }

    }
}
