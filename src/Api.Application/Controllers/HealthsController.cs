using System;
using System.Net;
using System.Threading.Tasks;
using Api.Domain.Interfaces.Services.Health;
using Microsoft.AspNetCore.Mvc;

namespace Api.Application.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class HealthsController : ControllerBase
    {
        private IHealthService _service;
        public HealthsController(IHealthService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            try
            {
                var result = await _service.Get();
                if (result.Result)
                    return Ok(new { status = result.Status });
                else
                    return StatusCode((int)HttpStatusCode.ServiceUnavailable, new { status = result.Status });
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}
