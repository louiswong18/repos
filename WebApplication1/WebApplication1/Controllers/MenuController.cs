using System.Collections.Generic;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    //[RoutePrefix("api/menu")]
    public class MenuController : ApiController
    {
        [HttpGet]
        [Route("api/menu")]
        public IHttpActionResult GetMenu()
        {
            List<MenuItem> menuItems = new List<MenuItem>
            {
                new MenuItem
                {
                    Id = "AspNetMvcApp",
                    Name = "ASP.NET MVC App",
                    Url = "http://localhost:51806",
                    Children = new List<MenuItem>
                    {
                        new MenuItem
                        {
                            Id = "AspNetMvcChild1",
                            Name = "ASP.NET MVC Child 1 - About",
                            Url = "http://localhost:51806/Home/About"
                        },
                        new MenuItem
                        {
                            Id = "AspNetMvcChild2",
                            Name = "ASP.NET MVC Child 2 - Contact",
                            Url = "http://localhost:51806/Home/Contact"
                        }
                    }
                }
            };

            return Ok(menuItems);
        }
    }
}