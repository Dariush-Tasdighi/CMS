using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder =
	Microsoft.AspNetCore.Builder.WebApplication.CreateBuilder(args);

// Adds services for Razor Pages to the app.
// AddRazorPages() -> using Microsoft.Extensions.DependencyInjection;
builder.Services.AddRazorPages();

builder.Services.AddDbContext<Persistence.DatabaseContext>(options =>
{
	// UseInMemoryDatabase -> using Microsoft.EntityFrameworkCore;
	options.UseInMemoryDatabase("name");
});

var app =
	builder.Build();

// IsDevelopment() -> using Microsoft.Extensions.Hosting;
if (app.Environment.IsDevelopment())
{
	// UseDeveloperExceptionPage() -> using Microsoft.AspNetCore.Builder;
	app.UseDeveloperExceptionPage();
}
else
{
	// UseExceptionHandler() -> using Microsoft.AspNetCore.Builder;
	app.UseExceptionHandler("/Error");

	// The default HSTS value is 30 days.
	// You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	// UseHsts() -> using Microsoft.AspNetCore.Builder;
	app.UseHsts();
}

// UseStatusCodePagesWithRedirects() -> using Microsoft.AspNetCore.Builder;
app.UseStatusCodePagesWithRedirects("/StatusCode/{0}");

// UseHttpsRedirection() -> using Microsoft.AspNetCore.Builder;
app.UseHttpsRedirection();

// UseStaticFiles() -> using Microsoft.AspNetCore.Builder;
app.UseStaticFiles();

// UseRouting() -> using Microsoft.AspNetCore.Builder;
app.UseRouting();

// UseAuthorization() -> using Microsoft.AspNetCore.Builder;
app.UseAuthorization();

// Adds endpoints for Razor Pages to the IEndpointRouteBuilder.
// MapRazorPages() -> using Microsoft.AspNetCore.Builder;
app.MapRazorPages();

app.Run();
