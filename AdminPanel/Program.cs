using ShoppingCart.Business;
using ShoppingCart.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Add appsettings.json to the configuration
builder.Configuration.AddJsonFile("appsettings.json");

// Register the Connection class as a service
builder.Services.AddSingleton<Connection>();
builder.Services.AddScoped<UserRepository>();
builder.Services.AddScoped<UserService>();
var app = builder.Build();

// Test the database connection
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var connection = services.GetRequiredService<Connection>();
    bool isConnected = connection.TestConnection();
    Console.WriteLine($"Database Connection Successful: {isConnected}");
}

// Configure the HTTP request pipeline.
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
