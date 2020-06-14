﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Enum;

namespace Entidades.Metadata
{
   public class NecesidadesMetadata
    {
        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        public string Descripcion { get; set; }

        [Required]
        [StringLength(30)]
        public string TelefonoContacto { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FechaFin { get; set; }

        [Required]
        [StringLength(100)]
        public string Foto { get; set; }

        [Required]
        public int IdUsuarioCreador { get; set; }

        [Required]
        public TipoDonacion TipoDonacion { get; set; }



        public NecesidadesMetadata()
        {
            this.Denuncias = new HashSet<Denuncias>();
            this.NecesidadesDonacionesInsumos = new HashSet<NecesidadesDonacionesInsumos>();
            this.NecesidadesDonacionesMonetarias = new HashSet<NecesidadesDonacionesMonetarias>();
            this.NecesidadesReferencias = new HashSet<NecesidadesReferencias>();
            this.NecesidadesValoraciones = new HashSet<NecesidadesValoraciones>();
        }

        public int IdNecesidad { get; set; }
        public System.DateTime FechaCreacion { get; set; }
        public int Estado { get; set; }
        public Nullable<decimal> Valoracion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Denuncias> Denuncias { get; set; }
        public virtual Usuarios Usuarios { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NecesidadesDonacionesInsumos> NecesidadesDonacionesInsumos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NecesidadesDonacionesMonetarias> NecesidadesDonacionesMonetarias { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NecesidadesReferencias> NecesidadesReferencias { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NecesidadesValoraciones> NecesidadesValoraciones { get; set; }
    }
}
