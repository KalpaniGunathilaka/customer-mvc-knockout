using CustomerManagement.Web.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

// Typed HttpClient pointed at the Part 1 API
builder.Services.AddHttpClient<ICustomerApiClient, CustomerApiClient>(client =>
{
    var baseUrl = builder.Configuration["CustomerApi:BaseUrl"]
        ?? throw new InvalidOperationException("CustomerApi:BaseUrl is not configured.");
    client.BaseAddress = new Uri(baseUrl);
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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Customers}/{action=Index}/{id?}");

app.Run();