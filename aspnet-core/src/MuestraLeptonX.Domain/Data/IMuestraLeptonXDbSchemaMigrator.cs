using System.Threading.Tasks;

namespace MuestraLeptonX.Data;

public interface IMuestraLeptonXDbSchemaMigrator
{
    Task MigrateAsync();
}
