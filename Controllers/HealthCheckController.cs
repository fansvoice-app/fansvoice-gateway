using Microsoft.AspNetCore.Mvc;
using FansVoice.Shared.Models;

namespace FansVoice.Gateway.Controllers;

[ApiController]
[Route("api/v1/health")]
public class HealthCheckController : ControllerBase
{
    [HttpGet]
    public ActionResult<ApiResponse<string>> Get()
    {
        return Ok(ApiResponse<string>.SuccessResult("Gateway is healthy"));
    }
}