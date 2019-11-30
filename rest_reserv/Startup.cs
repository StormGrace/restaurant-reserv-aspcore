using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using rest_reserv.Data;
using rest_reserv.Data.Repository;
using rest_reserv.Data.Repository.Interface;

namespace rest_reserv
{
  public class Startup
  {
    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddCors();

      services.AddAuthentication().AddIdentityServerJwt();

      services.AddDbContext<RestDbContext>(db => db.UseMySql(Configuration["connectionStrings:MySQL"]));

      //Repositories.
      services.AddScoped<IListingRepository, ListingRepository>();
      services.AddScoped<IListingLogRepository, ListingLogRepository>();
      services.AddScoped<IReviewRepository, ReviewRepository>();
      services.AddScoped<IReviewActivityRepository, ReviewActivityRepository>();
      services.AddScoped<IUserRepository, UserRepository>();
      services.AddScoped<IUserLogRepository, UserLogRepository>();
      services.AddScoped<IMessageRepository, MessageRepository>();
      services.AddScoped<IMessageTypeRepository, MessageTypeRepository>();
      services.AddScoped<IInboxRepository, InboxRepository>();
      services.AddScoped<ISavedListingRepository, SavedListingRepository>();
      services.AddScoped<IActivityRepository, ActivityRepository>();
      services.AddScoped<IActivityTypeRepository, ActivityTypeRepository>();
      //

      services.AddIdentityServer().AddSigningCredentials();

      services.AddControllersWithViews();
	  services.AddRazorPages();
	  
      // In production, the Angular files will be served from this directory
      services.AddSpaStaticFiles(configuration =>
      {
        configuration.RootPath = "ClientApp/dist";
      });
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      app.UseCors(
      options => options.WithOrigins("http://localhost:50905/Listing").AllowAnyMethod()
      );

      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
        app.UseDatabaseErrorPage();
      }
      else
      {
        app.UseExceptionHandler("/Error");
        // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
        app.UseHsts();
      }

      app.UseHttpsRedirection();
      app.UseStaticFiles();

      if (!env.IsDevelopment())
      {
        app.UseSpaStaticFiles();
      }

      app.UseRouting();

      app.UseAuthentication();
      app.UseAuthorization();
      app.UseEndpoints(endpoints =>
      {
        endpoints.MapControllerRoute(
                  name: "default",
                  pattern: "{controller}/{action=Index}/{id?}");
      });

      app.UseSpa(spa =>
      {
        spa.Options.SourcePath = "ClientApp";

        if (env.IsDevelopment())
        {
          spa.UseAngularCliServer(npmScript: "start");
        }
      });
    }
  }
}
