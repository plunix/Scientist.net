﻿using System.Collections.Generic;
using GitHub;
using GitHub.Internals;

public static class TestHelper
{
    public static IEnumerable<IResult> Results =>
        ((InMemoryResultPublisher)Scientist.ResultPublisher).Results;
}
