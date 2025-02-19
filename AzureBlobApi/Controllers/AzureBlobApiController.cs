using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using AzureBlobApi.Models;


namespace AzureBlobApi.Controllers
{
    [Route("api/properties")]
    [ApiController]
    public class PropertiesController : ControllerBase
    {
        private readonly HttpClient _httpClient;
        private readonly string _blobUrl;
        private readonly string _sasToken;

        public PropertiesController(IConfiguration configuration)
        {
            _httpClient = new HttpClient();
            _blobUrl = configuration["AzureBlob:Url"];
            _sasToken = configuration["AzureBlob:SasToken"];
        }

        [HttpGet]
        public async Task<IActionResult> GetProperties()
        {
            try
            {
                string requestUrl = $"{_blobUrl}{_sasToken}";
                var response = await _httpClient.GetAsync(requestUrl);

                if (!response.IsSuccessStatusCode)
                {
                    return StatusCode((int)response.StatusCode, "Failed to fetch data from Blob Storage.");
                }

                var json = await response.Content.ReadAsStringAsync();
                // return Ok(json);
                var properties = JsonSerializer.Deserialize<List<Property>>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                return Ok(properties);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }
    }

}
