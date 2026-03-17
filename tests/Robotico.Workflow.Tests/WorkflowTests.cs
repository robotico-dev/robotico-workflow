using Robotico.Workflow;
using Xunit;

namespace Robotico.Workflow.Tests;

public sealed class WorkflowTests
{
    [Fact]
    public void IWorkflowState_contract_exists()
    {
        Assert.True(typeof(IWorkflowState<object>).IsInterface);
    }

    [Fact]
    public void CurrentState_returns_set_value()
    {
        SimpleWorkflowState<int> state = new(42);
        Assert.Equal(42, state.CurrentState);
    }

    [Fact]
    public void CurrentState_works_with_enum()
    {
        SimpleWorkflowState<WorkflowPhase> state = new(WorkflowPhase.Completed);
        Assert.Equal(WorkflowPhase.Completed, state.CurrentState);
    }

    /// <summary>
    /// Law: workflow state round-trip — create with state S, CurrentState returns S.
    /// </summary>
    [Fact]
    public void Workflow_law_state_round_trip()
    {
        const int initial = 99;
        SimpleWorkflowState<int> state = new(initial);
        Assert.Equal(initial, state.CurrentState);
    }

    /// <summary>
    /// Law: workflow state round-trip — parameterized by value and type (int and enum).
    /// </summary>
    [Theory]
    [InlineData(0)]
    [InlineData(42)]
    [InlineData(-1)]
    public void Workflow_law_state_round_trip_int(int value)
    {
        SimpleWorkflowState<int> state = new(value);
        Assert.Equal(value, state.CurrentState);
    }

    [Theory]
    [InlineData(WorkflowPhase.Created)]
    [InlineData(WorkflowPhase.Running)]
    [InlineData(WorkflowPhase.Completed)]
    public void Workflow_law_state_round_trip_enum(WorkflowPhase phase)
    {
        SimpleWorkflowState<WorkflowPhase> state = new(phase);
        Assert.Equal(phase, state.CurrentState);
    }

    /// <summary>
    /// When TState is a reference type, implementations may allow null for "not started" (see IWorkflowState remarks).
    /// </summary>
    [Fact]
    public void CurrentState_reference_type_allows_null_for_not_started()
    {
        SimpleWorkflowState<string?> state = new(null);
        Assert.Null(state.CurrentState);
    }

    [Fact]
    public void CurrentState_reference_type_round_trip_non_null()
    {
        SimpleWorkflowState<string> state = new("Running");
        Assert.Equal("Running", state.CurrentState);
    }
}

public enum WorkflowPhase
{
    Created,
    Running,
    Completed
}
