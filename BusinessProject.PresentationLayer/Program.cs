using BusinessProject.BusinessLayer.Abstract;
using BusinessProject.BusinessLayer.Concrete;
using BusinessProject.DataAccessLayer.Abstract;
using BusinessProject.DataAccessLayer.Concrete;
using BusinessProject.DataAccessLayer.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<Context>();

builder.Services.AddScoped<IEmployeeDal, EfEmployeeDal>();
builder.Services.AddScoped<IEmployeeService, EmployeeManager>();

builder.Services.AddScoped<IOperationDal, EfOperationDal>();
builder.Services.AddScoped<IOperationService, OperationManager>();

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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Employee}/{action=Index}/{id?}");

app.Run();
