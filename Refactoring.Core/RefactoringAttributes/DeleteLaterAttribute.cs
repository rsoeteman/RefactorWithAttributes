namespace Refactoring.Core.RefactoringAttributes;

/// <summary>
/// An attribute to mark code that needs to be deleted later on in the process, but can't be right now because of dependencies.
/// </summary>
[AttributeUsage(AttributeTargets.All)]
public class DeleteLaterAttribute(string message) :Attribute
{
    
}