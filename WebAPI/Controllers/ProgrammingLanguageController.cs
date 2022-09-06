﻿using Application.Features.ProgrammingLanguages.Commands.CreateProgrammingLanguage;
using Application.Features.ProgrammingLanguages.Queries.GetByIdProgrammingLanguage;
using Application.Features.ProgrammingLanguages.Queries.GetListProgrammingLanguage;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProgrammingLanguageController : BaseController
    {
        [HttpPost]
        public async Task<IActionResult> Add(CreateProgrammingLanguageCommand createProgrammingLanguageCommand)
        {
            var result = await Mediator.Send(createProgrammingLanguageCommand);
            return Created("Created", result);
        }
        [HttpGet]
        public async Task<IActionResult> List([FromQuery] GetListProgrammingLanguageQuery getListProgrammingLanguageQuery)
        {
            var result = await Mediator.Send(getListProgrammingLanguageQuery);
            return Ok(result);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> ById([FromRoute] GetByIdProgrammingLanguageQuery getByIdProgrammingLanguageQuery)
        {
            var result = await Mediator.Send(getByIdProgrammingLanguageQuery);
            return Ok(result);
        }
    }
}
