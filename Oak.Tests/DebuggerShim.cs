﻿using System.Linq;
using System.Reflection;
using NSpec;
using NSpec.Domain;

//[TestFixture]
public class DebuggerShim
{
    //[Test]
    public void debug()
    {
        var tagOrClassName = "wip";

        var invocation = new RunnerInvocation(Assembly.GetExecutingAssembly().Location, tagOrClassName);

        var contexts = invocation.Run();

        //assert that there aren't any failures
        contexts.Failures().Count().should_be(0);
    }
}
