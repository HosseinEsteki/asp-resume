using Google.Protobuf.WellKnownTypes;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Resome.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddRazorPages();




builder.Services.AddDbContext<ResomeDbContext>(optionsBuilder =>
{
    //optionsBuilder.UseMySQL("User id=root; password=; database=Rezome; host=127.0.0.1");
    optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\Projects\\Visual Studio\\MecaApp\\DataAccess\\Data\\MyDataBase.mdf\";Integrated Security=True;Connect Timeout=30");

});


builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(option =>
{
    option.LoginPath = "/Login";
    option.LogoutPath= "/logout";
    option.ExpireTimeSpan = TimeSpan.FromHours(1);
});
var app = builder.Build();

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

app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();


app.Run();
