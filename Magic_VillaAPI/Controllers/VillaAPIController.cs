using Magic_VillaAPI.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Magic_VillaAPI.Controllers
{
    /* [ApiController]
     * attribute is used to decorate a controller class, indicating that it is an API controller.
     * This attribute provides certain behaviors and conventions specific to API controllers*/
    [ApiController]
    [Route("api/VillaAPI")]
    /*Our api controller has to extends from ControllerBase we prev used : Controller for hnadling Razor views in MVC
     we need to use icrosoft.AspNetCore.Mvc;
    ControllerBase documentaion
     */
    public class VillaAPIController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<VillaDTO> GetVillas()
        {
            IEnumerable<VillaDTO> VillasList = new List<VillaDTO>() { 
            
            new VillaDTO{Id=1, Name="Pool View"},
            new VillaDTO{Id=2,Name="Beach View"}
            };
            return VillasList;
        }
    }
}
