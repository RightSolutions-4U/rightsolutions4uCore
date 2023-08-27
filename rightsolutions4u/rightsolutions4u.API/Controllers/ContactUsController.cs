using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using rightsolutions4u.common.Models;

namespace rightsolutions4u.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactusController : ControllerBase
    {
        private readonly Rights4uDbContext _context;
        public ContactusController(Rights4uDbContext context)
        {
            _context = context;
        }
        [HttpPost]
        public async Task<ActionResult<Contactus>> PostContactUs([FromBody] Contactus resource, CancellationToken cancellationToken)
        {
            var contactus = new Contactus();
            contactus.Fullname = resource.Fullname;
            contactus.Phoneno = resource.Phoneno;
            contactus.Email = resource.Email;
            contactus.Message = resource.Message;
            contactus.Replied = true;
            contactus.Endate = DateTime.Now;
            contactus.CreatedAt = DateTime.Now;
            contactus.UpdatedAt = DateTime.Now;

            await _context.Contactus.AddAsync(contactus, cancellationToken);
            _context.SaveChanges();
            return Ok(contactus);
        }

    }
}
