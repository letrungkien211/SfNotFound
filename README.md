# SfNotFound
Service Fabric Not Found MiddeWare ASP.NET Core.
This is required so that Reverse Proxy in Service Fabric can distinguish the following two cases 
* Case #1: The service address is correct, but the resource that the user requested does not exist.
* Case #2: The service address is incorrect, and the resource that the user requested might exist on a different node.

More details can be found at https://docs.microsoft.com/en-us/azure/service-fabric/service-fabric-reverseproxy

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

# License
MIT
