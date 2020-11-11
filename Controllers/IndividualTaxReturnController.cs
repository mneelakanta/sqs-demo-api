using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DemoApi.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class IndividualTaxReturnController : ControllerBase
    {
        private readonly ILogger<IndividualTaxReturnController> _logger;

        public IndividualTaxReturnController(ILogger<IndividualTaxReturnController> logger)
        {
            _logger = logger;
        }

        [HttpGet]   
        public IEnumerable<IndividualTaxReturn> TaxReturns()    
        {
            return new List<IndividualTaxReturn>() { GetIndividualTaxReturn(new Guid("209fff20-8c11-46ec-a3ac-c196041afad8")) };
        }   

        private IndividualTaxReturn GetIndividualTaxReturn(Guid LodgementId)
        {
            return new IndividualTaxReturn() { User = new User() { FirstName = "Pam", LastName = "Smith", Id = new Guid("6cca14e4-4987-417c-bdd5-9f1df2462e19")}, Salary=140000, TotalTaxWithheld=23000, Year=2019, Id= LodgementId };
        }
    }
}
