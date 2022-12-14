using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OpenSearch.Client;
using SpikeElasticSearch.Opensearch;
using System.Net.Http.Json;
using System.Security.Principal;
using System.Text.Json.Serialization;
using System.Xml;
using static System.Net.Mime.MediaTypeNames;
using Formatting = Newtonsoft.Json.Formatting;

namespace SpikeElasticSearch.Controllers
{
    [ApiController]
    [Microsoft.AspNetCore.Mvc.Route("[controller]")]
    public class OpenSearchClientController : ControllerBase
    {
        private readonly ILogger<OpenSearchClientController> _logger;

        public OpenSearchClientController(ILogger<OpenSearchClientController> logger)
        {
            _logger = logger;
        }


        [HttpPost("SearchResult")]
        public async Task<ActionResult<OpensearchResponseDto>> SearchResult(
            [FromBody] OpensearchRequestDto request)
        {
            // URL
            var nodeAddress = new Uri("https://vpc-chargingnetworkmanager-bskuutvcgy73xjahxqi2d2elly.eu-west-1.es.amazonaws.com");
            var config = new ConnectionSettings(nodeAddress);
            IOpenSearchClient client = new OpenSearchClient(config);

            //var response = await client.Indices.ExistsAsync("log-is4-2022.12");

            var searchRequest = new SearchRequest
            {
                From = 11,
                Size = 10,

                Query = new DateRangeQuery
                {
                    Field = "@timestamp",
                    GreaterThanOrEqualTo = DateMath.Now.Subtract(new DateMathTime("10d")),
                    LessThanOrEqualTo = DateMath.Now,
                    Format = "date_hour_minute_second"
                },

                // || new TermQuery { Field = "fields.ApplicationName", Value = "STS.Identity" }                
                // || new MatchQuery { Field = "fields.ApplicationName", Query = "STS.Identity" },

                // QueryOnQueryString = "fields.ApplicationName:STS.Identity OR fields.RequestContext.Module:driver_contracts",


            };

            ISearchResponse<Response> searchResponse = await client.SearchAsync<Response>(searchRequest);

            var responseDto = JsonConvert.SerializeObject(searchResponse);

            OpensearchResponseDto opensearchResponseDto = new();


            if (searchResponse.IsValid)
            {

                //opensearchResponseDto.documents = JsonConvert.SerializeObject(searchResponse.Documents, Formatting.Indented);
                
                opensearchResponseDto.documents = new();
                foreach (var document in searchResponse.Documents)
                {
                    Document? document1 = new();
                    // document1 = (Document)document;

                    opensearchResponseDto.documents.Add(document1);
                }
              

            }

            /*
            user filter
            organization
            date range filter
            pagging
            default filter
            custom filter
                          
             */



            return Ok(searchResponse);
        }

    }
}

