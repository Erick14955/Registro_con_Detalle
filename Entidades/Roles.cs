﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_con_Detalle.Entidades
{
    public class Roles
    {
        [Key]
        public int RolID { get; set; }
        public string DescripcionRol { get; set; }
        public bool EsActivo { get; set; }

        [ForeignKey("RolID")]
        public virtual List<RolesDetalle> Detalle {get; set;}

        public Roles()
        {
            RolID = 0;
            DescripcionRol = string.Empty;
            EsActivo = false;

            Detalle = new List<RolesDetalle>();
        }
    }
}
