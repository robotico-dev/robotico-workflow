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
}
