# SfNotFound
Service Fabric Not Found MiddeWare ASP.NET Core.
This is required so that Reverse Proxy in Service Fabric can distinguish between "Wrong Reverse Proxy Path" or "Path not found in a service". More details can be found at https://docs.microsoft.com/en-us/azure/service-fabric/service-fabric-reverseproxy

# Nuget Package
```PM> Install-Package SfNotFound```

# Usage
```cs
// Startup.cs
...
using SfNotFound;
...

    public void Configure(IApplicationBuilder app)
    {
        ...
        // Better to be the first middleware or at least before Mvc
        app.UseSfNotFoundMiddleWare();
        ...
        app.UseMvc();
    }
```

# Licene
MIT