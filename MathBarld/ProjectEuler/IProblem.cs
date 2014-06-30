using System;
namespace MathBarld.ProjectEuler
{
    public interface IProblem
    {
        int GetAnswer();
        string ProblemDescription { get; }
    }
}
