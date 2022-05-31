// using System;
// using System.Net;
// using System.Threading.Tasks;
// using Api.Domain.Entities;
// using Api.Domain.Interfaces.Services.Choice;
// using Microsoft.AspNetCore.Mvc;

// namespace Api.Application.Controllers
// {
//     [Route("/[controller]")]
//     [ApiController]
//     public class ChoicesController : ControllerBase
//     {
//         private IChoiceService _service;
//         public ChoicesController(IChoiceService service)
//         {
//             _service = service;
//         }
//         [HttpGet]
//         public async Task<ActionResult> GetAll()
//         {
//             if (!ModelState.IsValid)
//             {
//                 return BadRequest(ModelState);
//             }
//             try
//             {
//                 return Ok(await _service.GetAll());
//             }
//             catch (ArgumentException e)
//             {
//                 return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
//             }
//         }

//         [HttpGet]
//         [Route("{id}", Name = "GetChoiceWithId")]
//         public async Task<ActionResult> Get(Guid id)
//         {
//             if (!ModelState.IsValid)
//             {
//                 return BadRequest(ModelState);
//             }
//             try
//             {
//                 return Ok(await _service.Get(id));
//             }
//             catch (ArgumentException e)
//             {
//                 return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
//             }
//         }
//         [HttpPost]
//         public async Task<ActionResult> Post([FromBody] ChoiceEntity choice)
//         {
//             if (!ModelState.IsValid)
//             {
//                 return BadRequest(ModelState);
//             }
//             try
//             {
//                 var result = await _service.Post(choice);
//                 if (result != null)
//                 {
//                     return Created(new Uri(Url.Link("GetChoiceWithId", new { id = result.Id })), result);
//                 }
//                 else
//                 {
//                     return BadRequest();
//                 }

//             }
//             catch (ArgumentException e)
//             {
//                 return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
//             }
//         }
//         [HttpPut]
//         public async Task<ActionResult> Put([FromBody] ChoiceEntity choice)
//         {
//             if (!ModelState.IsValid)
//             {
//                 return BadRequest(ModelState);
//             }
//             try
//             {
//                 var result = await _service.Put(choice);
//                 if (result != null)
//                 {
//                     return Ok(result);
//                 }
//                 else
//                 {
//                     return BadRequest();
//                 }

//             }
//             catch (ArgumentException e)
//             {
//                 return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
//             }
//         }
//         [HttpDelete("{id}")]
//         public async Task<ActionResult> Delete(Guid id)
//         {
//             if (!ModelState.IsValid)
//             {
//                 return BadRequest(ModelState);
//             }
//             try
//             {
//                 return Ok(await _service.Delete(id));
//             }
//             catch (ArgumentException e)
//             {
//                 return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
//             }
//         }
//     }
// }
