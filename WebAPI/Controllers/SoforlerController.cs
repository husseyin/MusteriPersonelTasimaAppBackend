using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SoforlerController : ControllerBase
    {
        ISoforService _soforService;

        public SoforlerController(ISoforService soforService)
        {
            _soforService = soforService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _soforService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Sofor sofor)
        {
            var result = _soforService.Add(sofor);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Sofor sofor)
        {
            var result = _soforService.Delete(sofor);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("deleteall")]
        public IActionResult DeleteAll(List<Sofor> soforler)
        {
            var result = _soforService.DeleteAll(soforler);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Sofor sofor)
        {
            var result = _soforService.Update(sofor);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
