namespace Refactoring.Core.RefactoringAttributes;

/// <summary>
/// An attribute to mark code that needs to be refactored later on in the process.
/// </summary>
[AttributeUsage(AttributeTargets.All)]
public class RefactorAttribute(string message) :Attribute
{
}