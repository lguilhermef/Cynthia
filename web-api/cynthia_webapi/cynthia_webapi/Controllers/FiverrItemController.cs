using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using cynthia_webapi.Models.Db;
using Microsoft.AspNetCore.Cors;

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

            FiverrItem fi2 = new FiverrItem();
            fi2.NvcDescription = "Prenda Lili! OLÁ MENINOS!!";
            fi2.Id = 1;

            FiverrItem fi3 = new FiverrItem();
            fi3.NvcDescription = "A emitir a partir do mui nobre Adivinho";
            fi3.Id = 2;



            List<FiverrItem> lstFiverrItems = new List<FiverrItem>();
            lstFiverrItems.Add(fiverrItem);
            lstFiverrItems.Add(fi2);
            lstFiverrItems.Add(fi3);

            return Ok(lstFiverrItems);
        }
    }
}
