using System;
using System.Threading.Tasks;
using TrungNhan.Categories;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace TrungNhan
{
    public class TrungNhanDataSeederContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Category, Guid> _repository;
        public TrungNhanDataSeederContributor(IRepository<Category, Guid> repository)
        {
            _repository = repository;
        }
        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _repository.GetCountAsync() <= 0)
            {
                await _repository.InsertAsync(
                    new Category
                    {
                        Name ="Category 1",
                        Type = CategoryType.OK
                    });
                await _repository.InsertAsync(
                    new Category
                    {
                        Name = "Category 2",
                        Type = CategoryType.NoOK
                    });
            }
        }
    }
}
