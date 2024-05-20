using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaPuntoNet.Models
{
    public class Departamento
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<Empleado> Empleados { get; set; }
    }
}
