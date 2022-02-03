using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace MuestraLeptonX.Data;

/* This is used if database provider does't define
 * IMuestraLeptonXDbSchemaMigrator implementation.
 */
public class NullMuestraLeptonXDbSchemaMigrator : IMuestraLeptonXDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
