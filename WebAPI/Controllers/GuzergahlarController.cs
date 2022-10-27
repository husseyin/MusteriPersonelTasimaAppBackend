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
    public class GuzergahlarController : ControllerBase
    {
        IGuzergahService _guzergahService;

        public GuzergahlarController(IGuzergahService guzergahService)
        {
            _guzergahService = guzergahService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _guzergahService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Guzergah guzergah)
        {
            var result = _guzergahService.Add(guzergah);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Guzergah guzergah)
        {
            var result = _guzergahService.Delete(guzergah);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("deleteall")]
        public IActionResult DeleteAll(List<Guzergah> guzergahlar)
        {
            var result = _guzergahService.DeleteAll(guzergahlar);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Guzergah guzergah)
        {
            var result = _guzergahService.Update(guzergah);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
