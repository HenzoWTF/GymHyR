using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Visitas
    {
        [Key]
        public int VisitaId { get; set; }

        public int MembresiaId { get; set; }

    }
}
