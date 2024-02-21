using Refactoring.Business.Models;
using Refactoring.Core.RefactoringAttributes;

namespace Refactoring.Business.Services.Definition.Legacy;

/// <summary>
/// Legacy productService only used for the old product system.
/// </summary>
[DeleteLater("Ensure we delete all legacy before going live with the new product")]
public interface ILegacyProductService
{
    /// <summary>
    /// Gets the product based on the given id.
    /// </summary>
    Product GetProductById(int id);
}