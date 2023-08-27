using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using rightsolutions4u.common.Models;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace rightsolutions4u.UI.Controllers
{
    public class ContactController : Controller
    {
        // GET: ContactController
        public ActionResult Index()
        {
            return View();
        }

        // POST: ContactController/Create
        [HttpPost("Create")]
        //[ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(IFormCollection collection)
        {
            try
            {
                Contactus contactus = new Contactus();
                contactus.Fullname = collection["fullName"];
                contactus.Phoneno = collection["phone"];
                contactus.Email = collection["email"];
                contactus.Message = collection["message"];
                StringContent content = new StringContent(JsonConvert.SerializeObject(contactus), Encoding.UTF8, "application/json");

                var client = new HttpClient();
                client.DefaultRequestHeaders.Clear();
                using (var response = await client.PostAsync("https://localhost:7279/api/Contactus", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    
                    var a = JsonConvert.DeserializeObject<Contactus>(apiResponse);
                    if(a.Email!= null)
                    {
                        ViewBag.message = "Thank you. We'll contact you shortly!.";
                        return View("../Shared/Contact");
                    }

                }
                return View("../Shared/Contact");

            }
            catch
            {
                return View();
            }
        }

        
    }
}
