//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CIIPMaestrosERP.SQL.Data.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class MKT_DOCENTE_CURSO
    {
        public int ID { get; set; }
        public int DOC_ID { get; set; }
        public int LAN_ID { get; set; }
        public int MKT_ID { get; set; }
        public Nullable<System.DateTime> DCU_FEC { get; set; }
        public int CUR_ID { get; set; }
        public Nullable<System.DateTime> DCU_FEC_MOD_LAST { get; set; }
        public Nullable<int> DCU_CANT_MOD { get; set; }
        public int LAN_NUM_SEMANA { get; set; }
    
        public virtual MAE_CURSOS MAE_CURSOS { get; set; }
        public virtual MAE_CURSOS_LANZAMIENTOS MAE_CURSOS_LANZAMIENTOS { get; set; }
        public virtual MKT_DOCENTES MKT_DOCENTES { get; set; }
        public virtual SEG_USUARIOS SEG_USUARIOS { get; set; }
    }
}