﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
Console.WriteLine("Hello");

//ProductTest();

//CategoryTest();

static void ProductTest()
{
    ProductManager productManager = new ProductManager(new EfProductDal(), new CategoryManager(new EfCategoryDal()));

    foreach (var product in productManager.GetProductDetails().Data)
    {
        Console.WriteLine($"Product name : {product.ProductName} | CategoryName: {product.CategoryName} | " +
            $"UnitStock :  {product.UnitsInStock}");
    }
}

static void CategoryTest()
{
    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
    foreach (var category in categoryManager.GetAll().Data)
    {
        Console.WriteLine(category.CategoryName);
    }
}