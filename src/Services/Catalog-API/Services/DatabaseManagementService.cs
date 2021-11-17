using Catalog_API.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog_API.Services
{
    public static class DatabaseManagementService
    {
    public static async void MigrationInitialisation(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
           
            var db = serviceScope.ServiceProvider.GetService<CatalogContext>();
                await db.Database.EnsureCreatedAsync();
                //db.Database.Migrate();
            }
        }
    }

}
