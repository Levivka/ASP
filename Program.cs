internal class Program
{
    private static void Main(string[] args)
    {
        Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(builder => {
            builder.UseStartup<Startup>().UseWebRoot("Views");
        }).Build().Run();
    }
}