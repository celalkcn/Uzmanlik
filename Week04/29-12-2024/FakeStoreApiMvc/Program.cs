using FakeStoreApiMvc.Models;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();
// api settings konfigüre ediliyor
builder.Services.Configure<ApiSettings>(builder.Configuration.GetSection("FakeStoreApi"));


builder.Services.AddHttpClient("FakeStoreApi", (ServiceProvider, client) =>
{
    ApiSettings apiSettings = ServiceProvider.GetRequiredService<IOptions<ApiSettings>>().Value;
    client.BaseAddress = new Uri(apiSettings.BaseUrl);
});



var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
