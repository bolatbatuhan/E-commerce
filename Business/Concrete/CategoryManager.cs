using Business.Abstract;
using CorePackages.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;


namespace Business.Concrete;

public class CategoryManager : ICategoryService
{
    ICategoryDal _categorydal;

    public CategoryManager(ICategoryDal categorydal)
    {
        _categorydal = categorydal;
    }

    public IDataResult<List<Category>> GetAll()
    {
        return new SuccessDataResult<List<Category>>(_categorydal.GetAll());
    }

    public IDataResult<Category> GetById(int categoryId)
    {
        return new SuccessDataResult<Category>(_categorydal.Get(c => c.CategoryId == categoryId));
    }
}
