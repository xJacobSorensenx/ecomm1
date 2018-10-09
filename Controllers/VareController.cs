using System.Collections.Generic;
using System.Threading.Tasks;
using ecomm1.Models;
using ecomm1.Repo;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;

namespace ecomm1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VareController : Controller
    {
        IMongoRepo _ctx;
        public VareController(IMongoRepo ctx)
        {
            _ctx = ctx;
        }

        [HttpGet]
        public async Task<IActionResult> Getall() {
            var res = await _ctx.GetAllVare(); 
            return Ok(res);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSpec(string id){
            var res = await _ctx.GetSpecVare(id);
            return Ok(res);
        }

        [HttpPost]
        public IActionResult post([FromBody] vare incData){
            
            if(!ModelState.IsValid){
                return BadRequest();
            }else{
               var res = _ctx.AddVare(incData);
                return Ok(res);
            }
        }
    }
}