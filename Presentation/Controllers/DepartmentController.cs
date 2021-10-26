using Contracts;
using Microsoft.AspNetCore.Mvc;
using Service.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Web.Mvc;
//
//
//using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    class DepartmentController : ControllerBase
    {

        private readonly ICommandService _commandservice;
        public DepartmentController(ICommandService CommandService) => _commandservice = CommandService;


        [HttpPost]
        public  ActionResult<PlatformCreateDto> CreatePlatform(PlatformCreateDto platformCreateDto)
        {
            // var platformModel = _mapper.Map<Platform>(platformCreateDto);
            _commandservice.CreatePlatform(platformCreateDto);
            _commandservice.SaveChanges();
            //  var platformReadDto = _mapper.Map<PlatformReadDto>(platformModel);

            return platformCreateDto;

        }



        [HttpPost]
        public ActionResult<CommandCreateDto> CreateCommand(int platformId, CommandCreateDto commandCreateDto)
        {
            // var platformModel = _mapper.Map<Platform>(platformCreateDto);
            _commandservice.CreateCommand(platformId, commandCreateDto);
            _commandservice.SaveChanges();
            //  var platformReadDto = _mapper.Map<PlatformReadDto>(platformModel);

            return commandCreateDto;

        }



    }
    }
