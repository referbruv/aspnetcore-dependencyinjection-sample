using System;
using DiReadersApp.Providers.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace DiReadersApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReadersController : ControllerBase
    {
        private readonly IDataService _data;
        private readonly IServiceProvider _sp;

        public ReadersController(IDataService data, IServiceProvider provider)
        {
            _data = data;
            _sp = provider;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var dService = _sp.GetRequiredService<IDataService>();
            var data = dService.Readers.Get(x => x.Id > 0);
            return Ok(data);
        }

        [HttpGet, Route("{id}")]
        public IActionResult GetSingle(int id)
        {
            var data = _data.Readers.Get(x => x.Id == id);
            return Ok(data);
        }
    }
}