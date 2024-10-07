using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SumApi.Interfaces;
using SumApi.Models;
using SumApi.Services;
using SumApi.Validators;

namespace SumApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SomaController : ControllerBase
    {
        private readonly ISomaService _somaService;
        private readonly IValidator<SomaRequest> _validator;

        public SomaController(ISomaService somaService, IValidator<SomaRequest> validator)
        {
            _somaService = somaService;
            _validator = validator;
        }

        [HttpGet("Somar")]
        public ActionResult Somar([FromQuery] SomaRequest request)
        {
            var validate = _validator.Validate(request);

            if (!validate.IsValid)
            {
                return BadRequest(validate.Errors);
            }

            var result = _somaService.Somar(request);
            return Ok(new { result });
        }
    }
}
