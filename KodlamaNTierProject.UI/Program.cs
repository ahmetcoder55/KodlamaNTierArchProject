using KodlamaNTierProject.Business.Concrete.Extensions;
using KodlamaNTierProject.DataAccess.Concrete.Extensions;

var builder = WebApplication.CreateBuilder(args);


builder.Services.ConfigureDatabase(builder.Configuration);
builder.Services.ConfigureDataAccess();
builder.Services.ConfigureBusiness();
builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
