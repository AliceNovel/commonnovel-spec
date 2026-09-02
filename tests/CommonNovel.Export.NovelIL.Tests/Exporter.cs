using System.Diagnostics.CodeAnalysis;

namespace CommonNovel.Export.NovelIL.Tests;

public class ExporterTest
{
    [Fact]
    public void NIL_Validation()
    {
    }

    [ExcludeFromCodeCoverage]
    public static IEnumerable<object[]> ExporterTestData =>
        new List<object[]>
        {
            new object[] // Ex4.1
            {
                "[Hi!]",
                """
                {
                  "cells": [
                    {
                      "messages": "text"
                    }
                  ]
                }
                """
            },
        };
}
