using System.Threading.Tasks;

namespace TrungNhan.Data
{
    public interface ITrungNhanDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}