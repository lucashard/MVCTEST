using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_TEST.Models
{
    public class Empresa
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        [DisplayName("Razon Social")]
        public string RazonSocial { get; set; }
        public ICollection<Empleado> Empleados { get; set; } 
    }
}

