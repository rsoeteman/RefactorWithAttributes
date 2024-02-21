using Refactoring.Business.Models;
using Refactoring.Business.Services.Definition.Legacy;
using Refactoring.Core.RefactoringAttributes;

namespace Refactoring.Business.Services.Legacy;

/// <summary>
/// Legacy productService only used for the old product system.
/// </summary>
[DeleteLater("Ensure we delete all legacy before going live with the new product")]
public class LegacyProductService :ILegacyProductService
{
    /// <summary>
    /// Gets the product based on the given id.
    /// </summary>
    public Product GetProductById(int id)
    {
        //Reference app so we don't get a real product from the database.
        return new Product();
    }
}