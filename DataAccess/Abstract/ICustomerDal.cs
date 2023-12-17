using CorePackages.DataAccess;
using Entities.Concrete;


namespace DataAccess.Abstract;

public interface ICustomerDal : IEntityRepository<Customer>
{
}
