using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using RazorPageVersion2022.EFDbContext;
using RazorPageVersion2022.Models;
using RazorPageVersion2022.Service.Interfaces;
using RazorPageVersion2022.Service.JsonService;
using RazorPageVersion2022.Service.MockDataService;
using RazorPageVersion2022.Service.SQLService;
using System.Security.Claims;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddSingleton<IItemService, MockItemService>();
builder.Services.AddSingleton<IUserService, MockDataUserService>();
builder.Services.AddTransient<JsonFileService<Item>>();
builder.Services.AddTransient<JsonFileService<User>>();
builder.Services.AddSingleton<DbService>();
builder.Services.AddDbContext<ItemDbContext>();

//builder.Services.AddTransient<IItemService, SQLItemService>();
//builder.Services.AddTransient<IUserService, SQLUserService>();

builder.Services.Configure<CookiePolicyOptions>(options =>
{
    // This lambda determines whether user consent for non-essential cookies is needed for a given request. 
    options.CheckConsentNeeded = context => true;
    options.MinimumSameSitePolicy = SameSiteMode.None;
});

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(cookieOptions =>
{
    cookieOptions.LoginPath = "/Login/LoginPage";
});

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("Administrator", policy =>
        policy.RequireClaim(ClaimTypes.Role, "admin"));
});

builder.Services.AddMvc().AddRazorPagesOptions(options =>
{
    options.Conventions.AuthorizeFolder("/Item");
}).SetCompatibilityVersion(CompatibilityVersion.Version_3_0);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
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
