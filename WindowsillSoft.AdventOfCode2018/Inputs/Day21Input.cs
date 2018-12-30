﻿using System;
using System.Collections.Generic;
using System.Text;
using WindowsillSoft.AdventOfCode2018.Solutions.Day21;

namespace WindowsillSoft.AdventOfCode2018.Inputs
{
    public class Day21Input
    {
        [FullRunInput(typeof(Day21Solver))]
        public const string FullRunInput = @"#ip 1
seti 123 0 5
bani 5 456 5
eqri 5 72 5
addr 5 1 1
seti 0 0 1
seti 0 7 5
bori 5 65536 4
seti 13159625 6 5
bani 4 255 3
addr 5 3 5
bani 5 16777215 5
muli 5 65899 5
bani 5 16777215 5
gtir 256 4 3
addr 3 1 1
addi 1 1 1
seti 27 9 1
seti 0 0 3
addi 3 1 2
muli 2 256 2
gtrr 2 4 2
addr 2 1 1
addi 1 1 1
seti 25 0 1
addi 3 1 3
seti 17 4 1
setr 3 3 4
seti 7 5 1
eqrr 5 0 3
addr 3 1 1
seti 5 6 1";

        public const string Part1FullRunOutput = "3941014";
        public const string Part2FullRunOutput = "13775890";
    }
}