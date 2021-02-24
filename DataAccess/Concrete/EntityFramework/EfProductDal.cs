using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
        public List<ProductDetailDto> GetProductDetails()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from p in context.Products
                             join c in context.Categories
                             on p.CategoryId equals c.CategoryId
                             select new ProductDetailDto
                             {
                                 ProductId = p.ProductId,
                                 ProductName = p.ProductName,
                                 CategoryName = c.CategoryName,
                                 UnitsInStock = p.UnitsInStock
                             };
                return result.ToList();
            }
        }
    }
}


//Join atıyoruz, contexteki ürünlerle categorileri join et,
//ürünlere p, categorilere c de, p.CategoryId ile c.CetgoryId eşitse onları join et. yani bu ikisi eşitse ürünler ve categoriler join olsun.
// sonucu select new deki colonlora uydurarak ver. mesela unutsınstock'u productaki unitsinstocktan al gibi.
//return result.ToList(); ve bu şekilde listele sonuçları.