using CorePackages.DataAccess;
using Entities.Concrete;


namespace DataAccess.Abstract;

public interface IOrderDal : IEntityRepository<Order>
{
}
