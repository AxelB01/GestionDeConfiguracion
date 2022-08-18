using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RegistroEstudiantesWebApi.Models;

namespace RegistroEstudiantesWebApi.Controllers
{
    public class RegistroController : ApiController
    {
        public static List<EstudianteModel> registro;

        public RegistroController()
        {
            if (registro == null)
            {
                registro = new List<EstudianteModel>();
            }
        }

        [HttpGet]
        [ActionName("GetRegistroEstudiantes")]
        public IHttpActionResult GetRegistroEstudiantes()
        {
            var response = registro.Select(a => new
            {
                a.Id,
                a.Name,
            }).ToList();

            return Ok(response);
        }

        [HttpPost]
        [ActionName("InsertRegistroEstudiante")]
        public IHttpActionResult InsertRegistroEstudiante([FromBody] EstudianteFormModel model)
        {
            if (!string.IsNullOrEmpty(model.Name))
            {
                var id = registro.Count + 1;

                var estudiante = new EstudianteModel
                {
                    Id = id,
                    Name = model.Name,
                };

                registro.Add(estudiante);

                return Ok();
            }
            else
            {
                return BadRequest("Debe enviar un nombre válido para el estudiante");
            }
        }
    }
}