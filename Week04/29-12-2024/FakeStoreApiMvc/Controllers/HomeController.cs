using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FakeStoreApiMvc.Models;
using Newtonsoft.Json;

namespace FakeStoreApiMvc.Controllers;

public class HomeController : Controller
{
    private readonly HttpClient _httpClient;

    public HomeController(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<IActionResult> Index()
    {

        List<Product>? response;
        using (HttpClient httpClient = new())
        {
            HttpResponseMessage responseMessage = await httpClient.GetAsync("products");
            string contentResponse = await responseMessage.Content.ReadAsStringAsync();
            response = JsonConvert.DeserializeObject<List<Product>>(contentResponse);



        }

        return View(response);
    }

}
