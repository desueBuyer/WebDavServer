using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebDavServer.Models;

namespace WebDavServer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FolderController : ControllerBase
    {
        WebDavDbContext db;


        private readonly ILogger<FolderController> _logger;

        public FolderController(ILogger<FolderController> logger, WebDavDbContext context)
        {
            _logger = logger;
            db = context;
            Console.WriteLine();
        }

        [HttpGet("user/{id}/folders")]
        public async Task<ActionResult<IEnumerable<Folder>>> Get(int id)
        {
            var folders = await db.Folders.Where(x => x.UserId == id).ToListAsync();

            if (folders.Count == 0)
            {
                return NotFound();
            }
            return folders;
        }
    }
}
