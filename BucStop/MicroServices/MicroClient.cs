using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace BucStop
{
    public class MicroClient
    {
        private readonly JsonSerializerOptions options = new JsonSerializerOptions()
        {
            PropertyNameCaseInsensitive = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        };

        private readonly HttpClient client;
        private readonly ILogger<MicroClient> _logger;

        public MicroClient(HttpClient client, ILogger<MicroClient> logger)
        {
            this.client = client;
            this._logger = logger;
        }

        public async Task<GameInfo[]> GetGamesAsync()
        {
            try
            {
                var responseMessage = await this.client.GetAsync("/Micro");

                if (responseMessage != null)
                {
                    var stream = await responseMessage.Content.ReadAsStreamAsync();
                    return await JsonSerializer.DeserializeAsync<GameInfo[]>(stream, options);
                }
            }
            catch (HttpRequestException ex)
            {
                _logger.LogError(ex.Message);
            }
            return new GameInfo[] { };

        }
        
        // api gateway changes this to the methid that pulls the js string from the MS, passing a, id int
        public async Task<string> GetTetrisJS()
        {
            try
            {
                var responseMessage = await this.client.GetAsync("/games");

                if (responseMessage.IsSuccessStatusCode)
                {
                    return await responseMessage.Content.ReadAsStringAsync();
                }
            }
            catch (HttpRequestException ex)
            {
                _logger.LogError(ex.Message);
            }
            return string.Empty;

        }
    }
}