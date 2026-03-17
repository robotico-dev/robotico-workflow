namespace Robotico.Workflow;

/// <summary>
/// Represents the current state of a workflow instance. Persisted for durability and resumability.
/// </summary>
/// <typeparam name="TState">State type (e.g. enum or value object).</typeparam>
/// <remarks>
/// Use with an orchestration engine that persists state (e.g. via Robotico.Repository) and advances based on CurrentState.
/// The orchestration layer typically returns Result (Robotico.Result) for operations that advance or persist workflow state.
/// When TState is a reference type, implementations may allow null for "not started"; when TState is a value type, CurrentState is always a value.
/// See docs/design.adoc for workflow vs saga and related packages.
/// </remarks>
public interface IWorkflowState<out TState>
{
    /// <summary>
    /// Current step or state of the workflow.
    /// </summary>
    /// <value>Non-null when TState is a value type; may be null when TState is a reference type if the workflow has not started.</value>
    TState CurrentState { get; }
}
