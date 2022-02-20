using System.Threading;
using System.Net;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EvOil.Business.Services.Abstractions;
using EvOil.Business.DataTransferObjects;

namespace EvOil.WebApi.Controllers
{
    [ApiController]
    [Route("api/")]
    public class OilController : ControllerBase
    {
        private readonly IOilService _oilService;

        public OilController(IOilService oilService)
        {
            _oilService = oilService;
        }
        [HttpPost]
        [Route("oils")]
        public async Task<IActionResult> SetOil(
            [FromBody] OilDto oilDto,
            CancellationToken cancellationToken)
        {
            await _oilService.SetOil(
                oilDto: oilDto,
                cancellationToken: cancellationToken
            );

            return CreatedAtAction(nameof(SetOil), oilDto);
        }
        [HttpGet]
        [Route("oils")]
        public async Task<IActionResult> GetOils(CancellationToken cancellationToken)
        {
            var oils = await _oilService.GetOils(cancellationToken);

            return Ok(oils);

        }

    }
}