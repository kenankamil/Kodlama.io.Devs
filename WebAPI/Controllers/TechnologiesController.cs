﻿using Application.Features.Technologies.Commands.CreateTechnology;
using Application.Features.Technologies.Queries.GetListTechnology;
using Core.Application.Requests;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TechnologiesController : BaseController
    {
        [HttpPost]
        public async Task<IActionResult> Add(CreateTechnologyCommand createTechnologyCommand)
        {
            var result = await Mediator.Send(createTechnologyCommand);
            return Created("Created", result);
        }

        [HttpGet]
        public async Task<IActionResult> List([FromQuery]PageRequest pageRequest)
        {
            GetListTechnologyQuery getListTechnologyQuery = new GetListTechnologyQuery{ PageRequest = pageRequest};
            var result = await Mediator.Send(getListTechnologyQuery);
            return Ok(result);
        }
    }
}
