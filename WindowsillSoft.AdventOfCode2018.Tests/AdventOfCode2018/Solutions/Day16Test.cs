﻿using System;
using System.Collections.Generic;
using System.Text;
using WindowsillSoft.AdventOfCode2018.Inputs;
using WindowsillSoft.AdventOfCode2018.Solutions.Day16;
using Xunit;

namespace WindowsillSoft.AdventOfCode2018.Tests.AdventOfCode2018.Solutions
{
    public class Day16Test
    {
        [Fact]
        public void FullRunPart1()
        {
            var test = new Day16Solver();
            test.Initialize(Day16Input.FullRunInput);
            Assert.Equal(Day16Input.Part1FullRunOutput, test.SolvePart1());
        }

        [Fact]
        public void FullRunPart2()
        {
            var test = new Day16Solver();
            test.Initialize(Day16Input.FullRunInput);
            Assert.Equal(Day16Input.Part2FullRunOutput, test.SolvePart2());
        }
    }
}
