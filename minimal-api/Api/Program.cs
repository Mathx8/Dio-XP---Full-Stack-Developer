using Microsoft.AspNetCore.Hosting;
using minimal_api.Dominio.DTOs;

IHostBuilder CreateHostBuilder(string[] args){
  return Host.CreateDefaultBuilder(args)
    .ConfigureWebHostDefaults(webBuilder =>
    {
        webBuilder.UseStartup<IStartup>();
    });
}

CreateHostBuilder(args).Build().Run();