using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MuestraLeptonX.Data;
using Volo.Abp.DependencyInjection;

namespace MuestraLeptonX.EntityFrameworkCore;

public class EntityFrameworkCoreMuestraLeptonXDbSchemaMigrator
    : IMuestraLeptonXDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreMuestraLeptonXDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the MuestraLeptonXDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<MuestraLeptonXDbContext>()
            .Database
            .MigrateAsync();
    }
}
