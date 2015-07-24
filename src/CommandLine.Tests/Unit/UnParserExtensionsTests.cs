﻿// Copyright 2005-2015 Giacomo Stelluti Scala & Contributors. All rights reserved. See doc/License.md in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CommandLine.Tests.Fakes;

using Xunit;
using FluentAssertions;

namespace CommandLine.Tests.Unit
{
    public class UnParserExtensionsTests
    {
        [Theory]        [MemberData("UnParseData")]        public static void UnParsing_instance_returns_command_line(FakeOptions options, string result)        {            new Parser()                .FormatCommandLine(options)                .ShouldBeEquivalentTo(result);        }

        public static IEnumerable<object> UnParseData
        {            get            {
                yield return new object[] { new FakeOptions(), "" };                yield return new object[] { new FakeOptions { BoolValue = true }, "-x" };            }        }
    }
}
