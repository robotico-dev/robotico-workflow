namespace Robotico.Workflow;

/// <summary>
/// Represents the current state of a workflow instance. Persisted for durability and resumability.
/// </summary>
/// <typeparam name="TState">State type (e.g. enum or value object).</typeparam>
public interface IWorkflowState<out TState>
{
    /// <summary>
    /// Current step or state of the workflow.
    /// </summary>
    TState CurrentState { get; }
}
