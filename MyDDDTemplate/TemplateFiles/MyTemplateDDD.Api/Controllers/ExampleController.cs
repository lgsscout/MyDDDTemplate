using AutoMapper;
using $safeprojectname$.Controllers.Common;
using $safeprojectname$.Helpers;
using $safeprojectname$.ViewModels;
using $ext_safeprojectname$.Application.Interfaces;
using $ext_safeprojectname$.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace $safeprojectname$.Controllers
{
    public class ExampleController : BaseController
    {
        private readonly IExampleAppService _service;
        private readonly IMapper _mapper;

        public ExampleController(IExampleAppService service,
            IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var Examples = _service.GetAll();
            var ExamplesMapper = _mapper.Map<IEnumerable<ExampleListViewModel>>(Examples);

            return new OkObjectResult(ExamplesMapper);
        }

        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            if (string.IsNullOrEmpty(id)) return BadRequest();
            Guid guid;
            var success = Guid.TryParse(id, out guid);
            var Example = _service.Get(guid);

            var vm = _mapper.Map<ExampleEditViewModel>(Example);
            if (vm == null) return NotFound();

            return new OkObjectResult(vm);
        }

        [HttpPost()]
        public IActionResult Create([FromBody]ExampleEditViewModel vm)
        {
            if (vm == null) return BadRequest();
            //vm.UserName = GetUserName;

            var Example = _mapper.Map<Example>(vm);
            //TODO: Adicionar na Tela.

            var validationResult = _service.Create(Example);
            if (validationResult.IsValid) return new CreatedResult("/Example", Example.ID); //TODO: Link de Retorno.

            return BadRequest(Errors.AddErrosToModelState(validationResult, ModelState));
        }

        [HttpPut()]
        public IActionResult Alter([FromBody]ExampleEditViewModel vm)
        {
            if (vm == null) return BadRequest();
            //vm.UserName = GetUserName;

            var Example = _mapper.Map<Example>(vm);

            var validationResult = _service.Update(Example);
            if (validationResult.IsValid) return new OkObjectResult(Example.ID); //TODO: Link de Retorno.

            return BadRequest(Errors.AddErrosToModelState(validationResult, ModelState));
        }
    }
}