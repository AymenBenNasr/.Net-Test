using backend_test.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backend_test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreditController : ControllerBase
    {
        
        private readonly ICreditService _creditService;
        public CreditController(ICreditService creditService)
        {
            _creditService = creditService;
        }

        
        [HttpPost]
        public double CalculCapital([FromBody] Credit credit)
        {
            return (double)_creditService.Calcul_Capital(credit); 
        }


    }
}
