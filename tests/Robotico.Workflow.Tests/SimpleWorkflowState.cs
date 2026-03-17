namespace Robotico.Workflow.Tests;

/// <summary>
/// Simple implementation of <see cref="IWorkflowState{TState}"/> for tests.
/// Allows null for reference-type TState (e.g. "not started"); value types are always set.
/// </summary>
public sealed class SimpleWorkflowState<TState> : IWorkflowState<TState>
{
    public SimpleWorkflowState(TState currentState)
    {
        CurrentState = currentState;
    }

    /// <inheritdoc />
    public TState CurrentState { get; }
}
