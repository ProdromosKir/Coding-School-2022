using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session15.EF.Repositories
{
    public interface IEntityRepo<TEntity>
    {
        List<TEntity> GetAll();
        TEntity? GetById(Guid id);
        Task Create(TEntity entity);    
        Task Update(TEntity entity,Guid id);
        Task Delete(Guid id);
    }
}
