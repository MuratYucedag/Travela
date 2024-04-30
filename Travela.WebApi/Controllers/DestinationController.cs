using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Travela.BusinessLayer.Abstract;
using Travela.EntityLayer.Concrete;

namespace Travela.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DestinationController : ControllerBase
    {
        private readonly IDestinationService _destinationService;
        public DestinationController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        [HttpGet]
        public IActionResult DestinationList()
        {
            var values = _destinationService.TGetListAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateDestination(Destination destination)
        {
            _destinationService.TInsert(destination);
            return Ok("Rota başarıyla eklendi");
        }
    }
}
