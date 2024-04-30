
using GeometricFigures.Models;

namespace GeometricFigures
{
    public class SQL
    {
        GeometricFiguresDbContext _dbContext = new();

        //Запрос на чистом sql
        //SELECT P.Title AS ProductTitle, C.Title AS CategoryTitle
        //FROM Product P
        //LEFT JOIN ProductCategory PC ON P.Id = PC.ProductId
        //LEFT JOIN Category C ON PC.CategoryId = C.Id

        //Запрос на linq

        /// <summary>
        /// Returns all pairs of ProductTitle and CategoryTitle
        /// </summary>
        /// <returns> List<ProductTitleCategoryTitle> </returns>
        public List<ProductTitleCategoryTitle> GetProductsCategories()
        {
            return (from product in _dbContext.Products
                    from category in product.Categories.DefaultIfEmpty()
                    select new ProductTitleCategoryTitle { ProductTitle = product.Title, CategoryTitle = category.Title }).ToList();
        }
    }
}
