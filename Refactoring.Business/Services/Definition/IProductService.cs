using Refactoring.Business.Models;

namespace Refactoring.Business.Services.Definition;

/// <summary>
/// Gets a products from the database
/// </summary>
public interface IProductService
{
    /// <summary>
    /// Gets the product from the database based on the given sku. 
    /// </summary>
    Product GetProduct(string sku);
}