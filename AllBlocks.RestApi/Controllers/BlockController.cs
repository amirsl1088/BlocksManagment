using AllBlocks.Services.Blocks.contracts;
using AllBlocks.Services.Blocks.contracts.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AllBlocks.RestApi.Controllers
{
    [Route("api/blocks")]
    [ApiController]
    public class BlockController : ControllerBase
    {
        private readonly BlockService _service;
        public BlockController(BlockService service)
        {
            _service = service;
        }
        [HttpPost]
        public async void Add(AddBlockDto dto)

        {
            await _service.Add(dto);
        }
    }
}
