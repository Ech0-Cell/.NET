namespace UniversityServiceConsumer;

public void ConfigureServices(IServiceCollection services)
{
    services.AddHttpClient<AOMService>(client =>
    {
        client.BaseAddress = new Uri("https://aom.example.com/");
    });
    services.AddScoped<AOMService>();
}
