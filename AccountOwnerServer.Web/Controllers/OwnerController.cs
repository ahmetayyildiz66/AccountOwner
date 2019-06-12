using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountOwnerServer.Business.Contracts;
using AccountOwnerServer.Common.Contracts;
using AccountOwnerServer.Common.ResponseMessages;
using AccountOwnerServer.Data.Contracts;
using AccountOwnerServer.Data.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AccountOwnerServer.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OwnerController : ControllerBase
    {
        private IRepositoryWrapper _repository;
        private ILoggerManager _logger;
        private IOwnerEngine _ownerEngine;
        private readonly IMapper 
        public OwnerController(IRepositoryWrapper repository, ILoggerManager logger, IOwnerEngine ownerEngine)
        {
            _repository = repository;
            _logger = logger;
            _ownerEngine = ownerEngine;
        }

        [HttpGet("{id}")]
        public Task<OwnerResponse> Get(Guid id)
        {
            return _ownerEngine.GetAsync(id);
        }

        //[HttpGet]
        //public IActionResult GetAllOwners()
        //{
        //    try
        //    {
        //        var owners = _repository.Owner.GetAll(0, 1);
        //        _logger.LogInfo($"Returned all owners from database");
        //        return Ok(owners);
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError($"Something went wrong inside GetAll action: {ex.Message}");
        //        return StatusCode(500, "Internal server error");
        //    }
        //}

        //[HttpGet("{id}")]
        //public async Task<Owner> GetOwnerById(Guid id)
        //{
        //    return await _repository.Owner.GetAsync(id);
        //}
    }
}