using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskTime.Data.Services;

namespace TaskTime.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StateController : ControllerBase
    {
        private StateService _stateservice;
        public StateController(StateService stateservice)
        {
            _stateservice = stateservice;   
        }
        [HttpGet("get-all-states")]
        public IActionResult GetAllStates()
        {
            var allstates = _stateservice.GetAllStates();
            return Ok(allstates);
        }
    }
}
