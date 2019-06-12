using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountOwnerServer.Common.Contracts;
using AccountOwnerServer.Data.Contracts;
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
        public OwnerController(IRepositoryWrapper repository, ILoggerManager logger)
        {
            _repository = repository;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetAllOwners()
        {
            try
            {
                var owners = _repository.Owner.GetAll(0, 1);
                _logger.LogInfo($"Returned all owners from database");
                return Ok(owners);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside GetAll action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}