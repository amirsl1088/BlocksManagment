using AllBlocks.Services.Units.contracts;
using AllBlocks.Services.Units.contracts.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AllBlocks.RestApi.Controllers
{
    [Route("api/units")]
    [ApiController]
    public class UnitController : ControllerBase
    {
        private readonly UnitService _service;
        public UnitController(UnitService service)
        {
            _service = service;
        }
        [HttpPost]
        public async void Add(AddUnitDto dto)
        {
            await _service.Add(dto);
        }
    }
}
