var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.URLShortner_ApiService>("apiservice");

builder.Build().Run();
