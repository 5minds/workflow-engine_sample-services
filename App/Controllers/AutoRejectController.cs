namespace App.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Primitives;

    using Contracts;
    using SharedDataStore;

    [Route("api/[controller]")]
    [ApiController]
    public class AutoRejectController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromBody] AutoRejectData value)
        {
            var correleationId = default(StringValues);

            this.Request.Headers.TryGetValue("X-CORRELATION-ID", out correleationId);

            DataStoreItem data = new DataStoreItem
            {
                CorrelationId = correleationId.FirstOrDefault(),
                Data = value
            };

            SimpleInMemoryStore.Instance.Data.Add(data);

            return new JsonResult(data);
        }
    }
}
