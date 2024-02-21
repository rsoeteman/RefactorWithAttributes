using Refactoring.Core.RefactoringAttributes;

namespace Refactoring.Business.Services.Definition;

/// <summary>
/// Service for sending faxes to customers wo don't have email
/// </summary>
[Question("It's 2024 do we really need a fax service?")]
public interface IFaxService
{
    /// <summary>
    /// Sends a Fax to the given fax number with the given document and returns true if the fax was sent successfully.
    /// </summary>
    bool SendFax(string faxNumber, string document);
}