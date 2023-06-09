using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

ConfigureServices(builder.Services); 

builder.Services.AddScoped<ProductsRepository>();
builder.Services.AddScoped<OrdersRepository>();

var app = builder.Build();

ShopDbInitializer.Seed(app);

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Products}/{action=Index}/{id?}");

app.Run();

void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ShopContext>(options =>
                options.UseSqlServer(@$"Server=.\SQLEXPRESS;Database=ShopDBCourseWork;Trusted_Connection=True;Encrypt=False"));

        }
