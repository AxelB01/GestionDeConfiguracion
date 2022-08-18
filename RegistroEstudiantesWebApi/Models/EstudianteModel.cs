using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegistroEstudiantesWebApi.Models
{
    public class EstudianteModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class EstudianteFormModel
    {
        public string Name { get; set; } 
    }
}