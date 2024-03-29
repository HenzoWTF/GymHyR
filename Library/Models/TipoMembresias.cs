﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class TipoMembresias
    {
        [Key]
        public int TipoMembresiaId { get; set; }

        public string? Descripcion { get; set; }

        public int DiasDuracion { get; set; }

        //public Decimal Precio { get; set; }

        [ForeignKey("TipoMembresiaId")]
        public ICollection<Membresias> Membresias { get; set; } = new List<Membresias>();
    }
}
