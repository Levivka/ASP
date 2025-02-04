public class Startup {
public IConfiguration? Configuration { get; }

public Startup(IConfiguration configuration) 
{
    Configuration = configuration;
}

    public void ConfigureServices(IServiceCollection services) 
    {
        services.AddControllers();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment environment) {
        if (environment.IsDevelopment()) {
            app.UseDeveloperExceptionPage();
        }
        else 
        {
            app.UseHsts();
        }

        app.UseCors(builder => {
            builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
        });

        app.UseStaticFiles();

        app.UseRouting();

        app.UseEndpoints(endpoints => 
        {
            endpoints.MapControllers();
        });
    }



}