using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkingHourController : ControllerBase
    {
        private IWorkingHourService _workingHourService;

        public WorkingHourController(IWorkingHourService workingHourService)
        {
            _workingHourService = workingHourService;
        }

        [HttpGet("getAllWorkingHours")]
        public IActionResult GetList()
        {
            var result = _workingHourService.GetList();
            if (result.IsSuccess)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("getByPersonelId")]
        public IActionResult GetByPersonelId(int personalId)
        {
            var result = _workingHourService.GetByPersonelId(personalId);
            if (result.IsSuccess)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("getByProjectId")]
        public IActionResult GetByProjectId(int projectId)
        {
            var result = _workingHourService.GetByProjectId(projectId);
            if (result.IsSuccess)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("getById")]
        public IActionResult GetById(int id)
        {
            var result = _workingHourService.GetById(id);
            if (result.IsSuccess)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("addWorkingHour")]
        public IActionResult Add(WorkingHour workingHour)
        {
            var result = _workingHourService.Add(workingHour);
            if (result.IsSuccess)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("deleteWorkingHour")]
        public IActionResult Delete(WorkingHour workingHour)
        {
            var result = _workingHourService.Delete(workingHour);
            if (result.IsSuccess)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("updateWorkingHour")]
        public IActionResult Update(WorkingHour workingHour)
        {
            var result = _workingHourService.Update(workingHour);
            if (result.IsSuccess)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
    }
}
