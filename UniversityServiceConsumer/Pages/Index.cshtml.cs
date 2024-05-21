using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json.Linq;

public class IndexModel : PageModel
{
    public JArray Universities { get; private set; }

    public async Task OnGet()
    {
        using (var client = new HttpClient())
        {
            var url = "http://universities.hipolabs.com/search?name=bahce";
            var response = await client.GetStringAsync(url);
            Universities = JArray.Parse(response);
        }
    }
}
