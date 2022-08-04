namespace NHLApiHelper;

public class Schedules
{
    private IHttpClientFactory clientFactory;

    public Schedules(IHttpClientFactory clientFactory)
    {
        this.clientFactory = clientFactory;
    }

    /*public async Task<Schedule> Today()
    {
        var request = new HttpRequestMessage(HttpMethod.Get, "https://statsapi.web.nhl.com/api/v1/schedule");
        var client = clientFactory.CreateClient();

        HttpResponseMessage res = await client.SendAsync(request);

        if (res.IsSuccessStatusCode)
        {
            
        }
    }*/
}