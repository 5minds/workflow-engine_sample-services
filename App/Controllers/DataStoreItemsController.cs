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

    public class PostData
    {
        public string value { get; set; }
    }

    [Route("api/[controller]")]
    public class DataStoreItemsController : Controller
    {
        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            IList<DataStoreItem> result = default(IList<DataStoreItem>);

            result = SimpleInMemoryStore.Instance.Data;

            return new JsonResult(result);
        }

        [HttpGet("{tradeId}")]
        public IActionResult Get(int tradeId)
        {
            DataStoreItem result = default(DataStoreItem);

            result = SimpleInMemoryStore.Instance.Data.Where(dataStoreItem => dataStoreItem.Data.TradeId == tradeId).LastOrDefault();

            return new JsonResult(result);
        }
    }
}
