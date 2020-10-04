using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCore_MediatR_Example.Application.TestObjects.Queries;

namespace NetCore_MediatR_Example.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestObjectController : ControllerBase
    {
        private IMediator _mediator;
        public TestObjectController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTestObject([FromRoute]GetTestObjectQuery request)
        {
            return Ok(await _mediator.Send(request));
        }
    }
}
