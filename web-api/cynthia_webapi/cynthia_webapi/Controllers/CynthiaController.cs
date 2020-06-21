using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using cynthia_webapi.Models.Db;
using Microsoft.AspNetCore.Cors;

namespace cynthia_webapi.Controllers
{
    [Route("api/cynthia")]
    [ApiController]
    public abstract class CynthiaController : ControllerBase
    {

        public DbContext db { get; set; }

        public CynthiaController(CynthiaDbContext context)
        {
            this.db = context;
        }
    }
}