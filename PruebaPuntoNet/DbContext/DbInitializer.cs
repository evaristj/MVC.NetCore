using PruebaPuntoNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaPuntoNet.DbContext
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            // Asegurarse de que la base de datos esté creada
            context.Database.EnsureCreated();

            // Verificar si ya existen empleados en la base de datos
            if (context.Empleados.Any())
            {
                return; // La base de datos ya tiene datos
            }

            // Crear algunos departamentos de muestra
            var departamentos = new Departamento[]
            {
            new Departamento { Nombre = "Recursos Humanos" },
            new Departamento { Nombre = "Tecnología", },
            new Departamento { Nombre = "Marketing" }
            };

            foreach (var d in departamentos)
            {
                context.Departamentos.Add(d);
            }
            context.SaveChanges();

            // Crear algunos empleados de muestra
            var empleados = new Empleado[]
            {
            new Empleado { Nombre = "Juan", Apellido = "Ynaca", DepartamentoId = departamentos[0].Id },
            new Empleado { Nombre = "María", Apellido = "Guerrera",DepartamentoId = departamentos[1].Id },
            new Empleado { Nombre = "Carlos", Apellido = "Alcaraz",DepartamentoId = departamentos[2].Id },
            new Empleado { Nombre = "Ana", Apellido = "Armas",DepartamentoId = departamentos[1].Id }
            };

            foreach (var e in empleados)
            {
                context.Empleados.Add(e);
            }
            context.SaveChanges();
        }
    }

}
