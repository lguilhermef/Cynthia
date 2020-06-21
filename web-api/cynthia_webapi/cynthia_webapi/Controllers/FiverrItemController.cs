using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using cynthia_webapi.Models.Db;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace cynthia_webapi.Controllers
{
    [Route("api/Fiverr")]
    [ApiController]
    public class FiverrItemController : CynthiaController
    {
        public FiverrItemController(CynthiaDbContext dbContext) : base(dbContext)
        {
        }

        [HttpGet]
        public ActionResult test()
        {
            FiverrItem fiverrItem = new FiverrItem();
            fiverrItem.NvcDescription = "Teste";


            return BadRequest(fiverrItem);
        }
    }
}
