using ApiDefintionTest.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Json;

namespace ApiDefintionTest.Controllers
{
    [RemoteService(Name = "ApiDefintionTest")]
    [Route("api/app/values")]
    public class ValuesController : AbpController
    {
        [HttpGet]
        [Route("{Id}/{Required}")]
        [Route("{Id}/{Required}/{Optional1}")]
        [Route("{Id}/{Required}/{Optional2}")]
        [Route("{Id}/{Required}/{Optional1}/{Optional2}")]
        public virtual Task<ValueOuputDto> GetAsync(GetValueInput input, [FromServices] IJsonSerializer jsonSerializer)
        {
            var dto = new ValueOuputDto
            {
                Value = jsonSerializer.Serialize(input)
            };

            return Task.FromResult(dto);
        }
    }
}
