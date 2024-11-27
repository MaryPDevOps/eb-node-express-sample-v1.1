namespace WebAppKeyVaultCode.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public ValuesController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public string Get()
        {
            var value = _configuration["AccNumber"];
            return "Value for Secret [AccNumber] is : " + value;
        }
    }
}
