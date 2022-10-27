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
    public class AraclarController : ControllerBase
    {
        IAracService _aracService;

        public AraclarController(IAracService aracService)
        {
            _aracService = aracService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _aracService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Arac arac)
        {
            var result = _aracService.Add(arac);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Arac arac)
        {
            var result = _aracService.Delete(arac);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("deleteall")]
        public IActionResult DeleteAll(List<Arac> araclar)
        {
            var result = _aracService.DeleteAll(araclar);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Arac arac)
        {
            var result = _aracService.Update(arac);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
