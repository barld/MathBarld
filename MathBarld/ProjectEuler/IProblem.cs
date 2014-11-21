using System;
namespace MathBarld.ProjectEuler
{
    public interface IProblem
    {
        long GetAnswer();
        string ProblemDescription { get; }
    }
}
