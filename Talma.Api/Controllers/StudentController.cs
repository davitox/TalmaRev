using Microsoft.AspNetCore.Mvc;
using Talma.Core.Entities;
using Talma.Core.Request;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Talma.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Estudiante> Get()
        {
            try
            {
                using (var context = new ModelContext())
                {
                    return context.Estudiantes.ToList();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public Estudiante Get(int id)
        {
            try
            {
                using (var context = new ModelContext())
                {
                    Estudiante _estudiante = context.Estudiantes.Where(x => x.Id == id).FirstOrDefault();

                    return _estudiante;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] StudentRequest estudiante)
        {
            try
            {
                using (var context = new ModelContext())
                {
                    Estudiante _estudiante = new Estudiante();
                    _estudiante.Nombres = estudiante.Nombres;
                    _estudiante.Apellidos = estudiante.Apellidos;
                    _estudiante.NombreCompleto = estudiante.Nombres + ' ' + estudiante.Apellidos;
                    _estudiante.NumDocumentoIdentidad = estudiante.NroDni;
                    _estudiante.CorreoElectronico = estudiante.CorreoElectronico;
                    _estudiante.FechaNacimiento = estudiante.FechaNacimiento;
                    _estudiante.Edad = CalcularEdad(estudiante.FechaNacimiento);
                    _estudiante.FechaHoraRegistro = DateTime.Now;
                    context.Estudiantes.Add(_estudiante);
                    context.SaveChanges();
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] StudentRequest estudiante)
        {
            try
            {


                using (var context = new ModelContext())
                {
                    Estudiante _estudiante = new Estudiante();
                    _estudiante = context.Estudiantes.Where(x => x.Id == id).FirstOrDefault();
                    _estudiante.Nombres = estudiante.Nombres;
                    _estudiante.Apellidos = estudiante.Apellidos;
                    _estudiante.NombreCompleto = estudiante.Nombres + ' ' + estudiante.Apellidos;
                    _estudiante.NumDocumentoIdentidad = estudiante.NroDni;
                    _estudiante.CorreoElectronico = estudiante.CorreoElectronico;
                    _estudiante.FechaNacimiento = estudiante.FechaNacimiento;
                    _estudiante.Edad = CalcularEdad(estudiante.FechaNacimiento);
                    //_estudiante.Edad = estudiante.edad;//DateTime.Now.Year - estudiante.FechaNacimiento.Year
                    //_estudiante.FechaHoraRegistro = DateTime.Now;

                    context.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            try
            {
                using (var context = new ModelContext())
                {
                    Estudiante _estudiante = new Estudiante();
                    _estudiante = context.Estudiantes.Where(x => x.Id == id).FirstOrDefault();
                    context.Estudiantes.Remove(_estudiante);

                    context.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }


        static int CalcularEdad(DateTime fechaNacimiento)
        {
            // Fecha actual
            DateTime fechaActual = DateTime.Today;

            // Calculamos la edad
            int edad = fechaActual.Year - fechaNacimiento.Year;

            // Si no ha cumplido años este año, restamos uno a la edad
            if (fechaNacimiento.Date > fechaActual.AddYears(-edad))
            {
                edad--;
            }

            return edad;
        }
    }
}
