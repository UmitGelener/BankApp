using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using System.IO;
using Udemy.BankApp.Web.Data.Context;
using Udemy.BankApp.Web.Data.Mapping;
using Udemy.BankApp.Web.Data.UnitOfWork;

namespace Udemy.BankApp.Web
{
	public class Startup
	{
		// This method gets called by the runtime. Use this method to add services to the container.
		// For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddDbContext<BankContext>(opt =>
			{
				opt.UseSqlServer("Server=DESKTOP-CHBBTJD;Database=BankDb;Trusted_Connection=True;Connect Timeout=30;MultipleActiveResultSets=True;");
			});
			services.AddScoped<IUow, Uow>();
			//services.AddScoped<IApplicationUserRepository, ApplicationUserRepository>();
			services.AddScoped<IUserMapper, UserMapper>();
			//services.AddScoped<IAccountRepository, AccountRepository>();
			services.AddScoped<IAccountMapper, AccountMapper>();
			//services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
			services.AddControllersWithViews();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			app.UseStaticFiles();
			app.UseStaticFiles(
				new StaticFileOptions
			{
				FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(),"node_modules")),
				RequestPath = "/node_modules"
			});
			app.UseRouting();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapDefaultControllerRoute();
			});
		}
	}
}
