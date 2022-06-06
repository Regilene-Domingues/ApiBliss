using System;
using System.Net;
using System.Threading.Tasks;
using Api.Domain.Interfaces.Services.Question;
using Microsoft.AspNetCore.Mvc;

namespace Api.Application.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class QuestionsController : ControllerBase
    {
        private IQuestionService _service;
        public QuestionsController(IQuestionService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<ActionResult> GetAll(int? page)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var Result = await _service.GetAll(page);
                return Ok(Result);
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }
        [HttpGet]
        [Route("{id}", Name = "GetQuestionWithId")]
        public async Task<ActionResult> Get(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                return Ok(await _service.Get(id));
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        // [HttpPost]
        // public async Task<ActionResult> Post([FromBody] QuestionEntity question)
        // {
        //     if (!ModelState.IsValid)
        //     {
        //         return BadRequest(ModelState);
        //     }
        //     try
        //     {
        //         var result = await _service.Post(question);
        //         if (result != null)
        //         {
        //             return Created(new Uri(Url.Link("GetQuestionWithId", new { id = result.Id })), result);
        //         }
        //         else
        //         {
        //             return BadRequest();
        //         }

        //     }
        //     catch (ArgumentException e)
        //     {
        //         return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
        //     }
        // }
        // [HttpPut]
        // public async Task<ActionResult> Put([FromBody] QuestionEntity question)
        // {
        //     if (!ModelState.IsValid)
        //     {
        //         return BadRequest(ModelState);
        //     }
        //     try
        //     {
        //         var result = await _service.Put(question);
        //         if (result != null)
        //         {
        //             return Ok(result);
        //         }
        //         else
        //         {
        //             return BadRequest();
        //         }

        //     }
        //     catch (ArgumentException e)
        //     {
        //         return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
        //     }
        // }
        // [HttpDelete("{id}")]
        // public async Task<ActionResult> Delete(Guid id)
        // {
        //     if (!ModelState.IsValid)
        //     {
        //         return BadRequest(ModelState);
        //     }
        //     try
        //     {
        //         return Ok(await _service.Delete(id));
        //     }
        //     catch (ArgumentException e)
        //     {
        //         return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
        //     }
        // }
    }
}
