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
        private readonly IJsonSerializer _jsonSerializer;
        public ValuesController(IJsonSerializer jsonSerializer) => _jsonSerializer = jsonSerializer;
        [HttpGet]
        [Route("{Id}/{Required}")]
        [Route("{Id}/{Required}/{Optional1}")]
        [Route("{Id}/{Required}/{Optional2}")]
        [Route("{Id}/{Required}/{Optional1}/{Optional2}")]
        public virtual Task<ValueOuputDto> GetAsync(GetValueInput input)
        {
            var dto = new ValueOuputDto
            {
                Value = _jsonSerializer.Serialize(input)
            };

            return Task.FromResult(dto);
        }
    }
}
