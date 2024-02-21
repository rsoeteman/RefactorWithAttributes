using Refactoring.Business.Models;
using Refactoring.Business.Services.Definition;
using Refactoring.Business.Services.Definition.Legacy;
using Refactoring.Core.RefactoringAttributes;
using Refactoring.Core.TypeExtensions;

namespace Refactoring.Business.Services;

public class ProductService(ILegacyProductService _legacyProductService) :IProductService
{
    [Refactor("Ensure the legacy products get in our new database and have a proper SKU then remove legacy productService")]
    public Product GetProduct(string sku)
    {
        if (sku.StartsWith("std-"))
        {
            //old product get from the legacy productService.
            return  _legacyProductService.GetProductById(sku.Replace("std-","").ToInt());
        }
        
        //Reference app so we don't get a real product from the database.
        return new Product();
    }
}