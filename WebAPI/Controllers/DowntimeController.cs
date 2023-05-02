using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DowntimeController : ControllerBase
    {
        private IDowntimeService _downtimeService;

        public DowntimeController(IDowntimeService downtimeService)
        {
            _downtimeService = downtimeService;
        }

        [HttpGet("getAllDowntimes")]
        public IActionResult GetList()
        {
            var result = _downtimeService.GetList();
            if(result.IsSuccess) 
            { 
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("addDowntime")]
        public IActionResult Add(Downtime downtime)
        {
            var result = _downtimeService.Add(downtime);
            if (result.IsSuccess)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("updateDowntime")]
        public IActionResult Update(Downtime downtime)
        {
            var result = _downtimeService.Update(downtime);
            if (result.IsSuccess)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("deleteDowntime")]
        public IActionResult Delete(Downtime downtime)
        {
            var result = _downtimeService.Delete(downtime);
            if(result.IsSuccess)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
    }
}
