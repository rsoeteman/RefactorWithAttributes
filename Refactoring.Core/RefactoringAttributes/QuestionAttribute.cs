namespace Refactoring.Core.RefactoringAttributes;

/// <summary>
/// An attribute to mark code where we have questions about that needs to be answered.
/// </summary>
[AttributeUsage(AttributeTargets.All)]
public class QuestionAttribute(string message) :Attribute
{
    
}