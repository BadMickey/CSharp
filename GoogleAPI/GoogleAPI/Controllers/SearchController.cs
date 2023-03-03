using Google.Apis.Customsearch.v1;
using Google.Apis.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace GoogleAPI.Controllers
{
    public class SearchController : ApiController
    {
        private readonly CustomsearchService customsearchService;

        public SearchController()
        {
            customsearchService = new CustomsearchService(new BaseClientService.Initializer
            {
                ApplicationName = "GoogleAPI",
                ApiKey = "key da api"
            });
        }

        [HttpGet]
        [Route("api/search/{query}")]
        public async Task<IHttpActionResult> Search(string query)
        {
            var searchRequest = customsearchService.Cse.List();


            searchRequest.Cx = "a08a16e5fd98c490c";
            searchRequest.Q = query;

            var searchResponse = await searchRequest.ExecuteAsync();

            if (searchResponse.Items == null || searchResponse.Items.Count == 0)
            {
                return NotFound();
            }

            return Ok(searchResponse.Items);
        }
    }
}
