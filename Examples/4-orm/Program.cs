﻿using Microsoft.AspNetCore.Hosting;
using ViennaNET.WebApi;
using ViennaNET.WebApi.Configurators.Kestrel;
using ViennaNET.WebApi.Configurators.Swagger;
using ViennaNET.WebApi.Configurators.SimpleInjector;
using ViennaNET.WebApi.Configurators.CallContext;
using ViennaNET.WebApi.Configurators.Common;
using ViennaNET.WebApi.Configurators.Diagnostic;

namespace OrmService
{
  internal static class Program
  {
    internal static void Main(string[] args)
    {
      CompanyHostBuilder.Create()
                  .UseKestrel()
                  .UseCommonModules()
                  .UseSwagger()
                  .UseCallContext()
                  .UseSimpleInjector()
                  .UseDiagnosing()
                  .BuildWebHost(args)
                  .Run();
    }
  }
}
