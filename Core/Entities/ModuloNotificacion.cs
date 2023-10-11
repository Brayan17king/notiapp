using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Threading.Tasks;

namespace Core.Entities;
    public class ModuloNotificacion : BaseEntity
    {
        public string AsuntoNotificacion { get; set; }
        public string TextoNotificacion { get; set; }
        public int IdRadicados { get; set; }
        public Radicado Radicados { get; set; }
        public int IdFormato { get; set; }
        public Formato Formatos { get; set; }
        public int IdHiloRespuestaNotificacion { get; set; }
        public HiloRespuestaNotificacion HiloRespuestaNotificaciones { get; set; }
        public int IdTipoNotificacion { get; set; }
        public TipoNotificacion TipoNotificaciones { get; set; }
        public int IdEstadoNotificacion { get; set; }
        public EstadoNotificacion EstadoNotificaciones { get; set; }
        public int IdTipoRequerimiento { get; set; }
        public TipoRequerimiento TipoRequerimientos { get; set; }
    }
