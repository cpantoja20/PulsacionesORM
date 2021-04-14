using Datos;
using Logica;
using Microsoft.AspNetCore.Mvc;

namespace pulsacionesdotnet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        private readonly PersonaService _personaService;
        public PersonaController(PulsacionesContext context)
        {
            _personaService = new PersonaService(context);
        }
    }
 }