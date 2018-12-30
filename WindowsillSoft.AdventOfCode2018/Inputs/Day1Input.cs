﻿using System;
using WindowsillSoft.AdventOfCode2018.Solutions.Day1;

namespace WindowsillSoft.AdventOfCode2018.Inputs
{
    public static class Day1Input
    {
        public const string Part1Test1Input = @"+1
+1
+1";
        public const string Part1Test1Result = "3";

        public const string Part1Test2Input = @"+1
+1
-2";
        public const string Part1Test2Result = "0";

        public const string Part1Test3Input = @"-1
-2
-3";
        public const string Part1Test3Result = "-6";


        public const string Part2Test1Input = @"+1
-1";
        public const string Part2Test1Result = @"0";

        public const string Part2Test2Input = @"+3
+3
+4
-2
-4";
        public const string Part2Test2Result = "10";

        public const string Part2Test3Input = @"-6
+3
+8
+5
-6";
        public const string Part2Test3Result = "5";

        public const string Part2Test4Input = @"+7
+7
-2
-7
-4";
        public const string Part2Test4Result = "14";


        [FullRunInput(typeof(Day1Solver))]
        public const string FullRunInput = @"+11
+9
+15
-17
+8
+16
+5
+13
+8
-6
+12
-17
-16
+13
+16
-15
-5
+11
+19
+5
-8
+20
+18
+15
-4
-12
+8
+2
+15
+12
-13
-4
-1
-14
-15
-6
-9
-13
+18
+13
+6
-8
-3
-19
+8
+17
+8
+5
-11
+15
-7
+9
-18
-9
+17
-14
-19
+4
-6
+4
+1
-12
+4
-1
-9
+4
+19
+20
+11
+8
+19
-13
+17
+6
+8
-11
+5
+9
-15
+17
-12
+6
-19
-2
+17
-18
+7
-5
+19
+15
+5
-6
+2
+5
+18
+11
+2
+5
-14
+17
+17
+1
+17
-9
-1
+5
-11
+5
-17
+2
+14
+16
-3
+17
+18
+1
-16
+19
-11
-10
+3
+8
+17
+19
-18
+6
-1
-2
+14
-2
+12
+11
+1
-19
-1
+18
+13
-6
-10
-13
+12
-11
+19
+14
+17
-2
-18
-4
+11
-12
-2
-21
+7
-1
-5
-13
-18
-18
-7
+9
+12
+6
-12
+20
-19
+6
-19
+3
-16
+20
-17
-8
+4
+8
-21
+18
-6
-13
+2
+5
-14
-16
-19
-17
+4
-15
-11
-3
+6
+13
+18
-16
-16
-15
-15
-2
+1
-3
+13
+25
+1
+14
-8
-8
-19
+7
+11
+20
+5
-9
+8
+19
-9
+3
+1
+1
-12
+18
+15
-5
+11
-1
+18
-2
-18
-14
-1
-16
+12
+12
-20
+10
+25
-13
-17
-20
-13
+11
-40
-19
+5
-21
-9
-15
-6
+3
+13
-5
-2
+33
+3
-7
+42
+32
-13
+2
+37
-1
-20
+30
+3
+8
+10
+11
-5
-26
+35
+16
-12
+9
+16
+18
-13
-15
+19
+6
+18
+16
+11
+16
-2
-10
+1
-2
+17
+7
-1
+17
+6
+15
+7
-5
-6
+9
-4
-17
-14
-1
-21
-2
+15
+3
+8
-18
-17
-14
+6
-17
+20
+13
+14
-1
-1
+3
-11
+19
+19
+7
-18
-9
+11
-12
+11
+4
+2
+8
-2
+6
-20
+5
+6
-13
-8
+6
+11
+8
+2
+7
+11
-7
+18
+11
+15
-16
-18
+6
+10
+6
+15
+13
+4
+4
+14
+14
-47
+17
-7
-20
-1
+19
+16
-23
-13
-17
+13
-8
+6
-20
+4
+15
+4
+19
+19
-7
-24
-17
-19
-2
+19
-13
+8
-4
-19
-9
+29
+21
-29
+2
+15
+22
+1
+21
-13
-14
+12
-57
-5
-49
-10
-19
-19
-6
+7
+21
-12
-13
-13
+4
-15
+9
+21
-7
+19
+32
+31
-27
-21
+25
-101
+69
-75
+26
-22
-45
-30
+5
-40
-15
-880
-60727
+14
-13
-18
+7
+2
-5
+6
+14
+5
+5
-18
-15
-9
+7
-10
+19
+4
+7
+6
+3
+21
+2
+5
-19
+15
-11
-19
-7
-1
-16
+4
-12
-15
+3
+5
-6
-14
+11
-16
-7
-15
+8
+12
-2
-9
-12
-17
+19
-5
-19
+16
-10
-13
-14
-1
-10
-18
-6
-11
+8
-11
+4
+14
+9
+8
-18
-9
+8
-19
-5
-14
+13
+19
+13
+16
+19
-4
-4
+3
+19
-4
-7
-15
+6
-9
-15
+12
-14
+6
-17
+9
+13
-4
-20
+17
-9
-12
+16
+6
-9
+19
+10
+11
+17
-19
-1
+12
+12
+1
-6
-1
+4
-12
+11
-14
+19
-3
-9
-6
-23
-2
-13
+18
-2
+10
+2
+8
-9
-20
-17
-21
-14
+11
-5
-15
+2
-9
+4
-7
-12
+9
-1
-11
+1
-10
+11
-17
-10
-17
-3
-10
+11
+15
-19
-14
+1
+2
+18
+17
+3
+17
-18
-15
+2
-3
-14
+9
+9
+6
-18
+13
-21
-18
+12
+7
+13
-11
+20
+12
+1
+15
-14
+4
+11
+18
-2
-7
-12
-11
+5
+10
+6
+8
+18
+6
-13
+19
-5
-3
+14
-3
-20
-3
-3
+16
-15
-12
+8
-24
-16
-13
-3
+13
+6
-12
-31
+7
-18
+17
-13
+1
-15
+16
+4
-1
-17
-1
+16
-4
+13
+8
+3
+33
+8
-6
+20
-4
+2
+13
-29
-17
-22
-24
-5
+2
-12
-1
+2
-15
+2
-11
+6
+1
-2
+5
+4
-22
+5
+19
-13
-7
+16
+6
+2
-22
+19
+9
+8
-9
-12
-18
-13
+1
+5
-9
+10
-11
-10
+16
-15
-2
-16
+1
-15
-17
-3
+6
+11
+4
+11
-16
-3
+6
-1
+13
+18
+6
-2
-6
-4
-5
+20
+19
-8
+1
-13
+16
+1
+10
-25
-19
-4
+9
-8
+17
+6
-19
-2
+5
+12
+7
-21
-12
+3
-7
-11
-3
-18
+2
+12
+20
-23
-19
-17
+9
-19
+1
-14
-5
-4
-9
+17
+4
+3
+15
-13
+1
-12
-17
+8
+8
-20
-17
+15
-16
+10
+7
+2
-10
-2
+8
+19
-6
-17
-8
+9
+17
+25
-5
-18
+4
+18
+9
+18
-14
-2
+11
+14
-17
-15
+38
+12
-2
+14
+4
+21
+16
+12
+15
+23
-1
+6
+9
-24
-6
-13
-3
+33
-13
+62
+81
+11
-5
-27
+9
-7
+20
-19
-4
+27
+28
-29
+82
+11
-10
+8
-22
+42
+34
-24
-15
+19
-66
-70
-34
-18
-548
+408
-1249
-60542
+6
-17
-4
+6
-7
+3
+14
+2
+15
-6
-5
+19
-17
-10
+6
-11
+2
-4
+10
-5
-11
-13
-12
-14
-10
-9
+17
+9
+15
+1
-10
-10
+14
+16
-17
-15
+7
-6
-16
-10
+15
-2
-7
-3
-5
-14
-8
-9
+16
+7
+17
-22
+12
-16
+18
+5
+15
+10
+20
+11
-5
+12
-16
+8
-16
+13
+14
-5
-12
-9
-16
-5
+16
-18
+21
-9
-13
-8
-10
+14
+18
-17
-16
+8
-15
+2
-4
+3
-21
+17
-16
+18
+18
-3
-21
+1
-19
-3
-2
-4
-5
-20
-19
+6
-19
+3
-12
+124236";

        public const string Part1FullRunOutput = "430";
        public const string Part2FullRunOutput = "462";
    }
}
