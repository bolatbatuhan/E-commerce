using CorePackages.DataAccess;
using CorePackages.Entities.Concrete;

namespace DataAccess.Abstract;

public interface IUserDal : IEntityRepository<User>
{
    List<OperationClaim> GetClaims(User user);
}
