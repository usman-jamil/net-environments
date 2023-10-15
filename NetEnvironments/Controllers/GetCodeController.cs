using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace NetEnvironments.Controllers;

[ApiController]
[Route("[controller]")]
public class CodeController : ControllerBase
{
    private readonly Configuration _configuration;
    private readonly ILogger<CodeController> _logger;

    public CodeController(ILogger<CodeController> logger, IOptions<Configuration> configuration)
    {
        _logger = logger;
        _configuration = configuration.Value;
    }

    [HttpGet]
    public ActionResult<string> Get()
    {
        return Ok(_configuration.NotSecretCode);
    }
}