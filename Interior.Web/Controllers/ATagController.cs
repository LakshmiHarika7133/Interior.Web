using Interior.Web.Data;
using Interior.Web.Models.Domain;
using Interior.Web.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Interior.Web.Controllers
{
    public class ATagController : Controller
    {
        private readonly InteriorDbContext interiorDbContext;
        public ATagController(InteriorDbContext interiorDbContext)
        {
            this.interiorDbContext = interiorDbContext;
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        [ActionName("Add")]
        public IActionResult Add(AddTagRequest addTagRequest)
        {

            //var name = addTagRequest.Name;
            //var displayName = addTagRequest.DisplayName;
            var tag = new Tag
            {
                Name = addTagRequest.Name,
                TypeName = addTagRequest.TypeName,
                Decors = new List<Decor>()
            };
            interiorDbContext.Tags.Add(tag);
            interiorDbContext.SaveChanges();
            return View("Add");
        }
    }
}
