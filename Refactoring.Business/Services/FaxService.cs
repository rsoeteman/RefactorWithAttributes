using Refactoring.Business.Services.Definition;
using Refactoring.Core.RefactoringAttributes;

namespace Refactoring.Business.Services;

/// <summary>
/// Service for sending faxes to customers wo don't have email
/// </summary>
[Question("It's 2024 do we really need a fax service?")]
public class FaxService :IFaxService
{
    /// <summary>
    /// Sends a Fax to the given fax number with the given document and returns true if the fax was sent successfully.
    /// </summary>
    public bool SendFax(string faxNumber, string document)
    {
        // This is a reference app just for outlining the refactoring attributes don't expect sending faxes here.
        return true;
    }
}