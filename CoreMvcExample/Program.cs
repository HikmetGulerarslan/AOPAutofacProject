using AOPExample.Utilities.Extensions;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using AOP.Business.AutofacContainer;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory()).ConfigureContainer<ContainerBuilder>(builder => { builder.RegisterModule(new AutofacModule()); });

builder.Services.AddMemoryCache();
builder.Services.AddCustomHttpContextAccessor();

var app = builder.Build();

app.UseRouting(); 
app.UseStaticHttpContext();
app.UseEndpoints(endpoints => endpoints.MapDefaultControllerRoute());
app.Run();
