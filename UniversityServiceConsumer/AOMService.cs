namespace UniversityServiceConsumer;

public class AOMService
{
    private readonly HttpClient _httpClient;

    public AOMService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task CreateSubscriberAsync(Subscriber subscriber)
    {
        HttpResponseMessage response = await _httpClient.PostAsJsonAsync("api/subscribers", subscriber);

        response.EnsureSuccessStatusCode();
    }

    public async Task<List<Balance>> GetRemainingBalancesAsync()
    {
        HttpResponseMessage response = await _httpClient.GetAsync("api/balances");

        response.EnsureSuccessStatusCode();

        List<Balance> balances = await response.Content.ReadAsAsync<List<Balance>>();
        return balances;
    }
}
