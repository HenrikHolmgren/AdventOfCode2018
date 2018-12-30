﻿using System;
using System.Collections.Generic;
using System.Text;
using WindowsillSoft.AdventOfCode2018.Solutions.Day24;

namespace WindowsillSoft.AdventOfCode2018.Inputs
{
    public class Day24Input
    {
        public const string Test1Input = @"Immune System:
17 units each with 5390 hit points (weak to radiation, bludgeoning) with an attack that does 4507 fire damage at initiative 2
989 units each with 1274 hit points (immune to fire; weak to bludgeoning, slashing) with an attack that does 25 slashing damage at initiative 3

Infection:
801 units each with 4706 hit points (weak to radiation) with an attack that does 116 bludgeoning damage at initiative 1
4485 units each with 2961 hit points (immune to radiation; weak to fire, cold) with an attack that does 12 slashing damage at initiative 4";
        public const string Part1Test1Result = "5216";
        public const string Part2Test1Result = "51";

        [FullRunInput(typeof(Day24Solver))]
        public const string FullRunInput = @"Immune System:
457 units each with 4941 hit points with an attack that does 98 slashing damage at initiative 14
35 units each with 3755 hit points (weak to cold; immune to fire, bludgeoning) with an attack that does 1021 bludgeoning damage at initiative 1
6563 units each with 7155 hit points (immune to radiation, bludgeoning) with an attack that does 10 cold damage at initiative 11
5937 units each with 1868 hit points (weak to slashing) with an attack that does 2 fire damage at initiative 2
422 units each with 7279 hit points (immune to radiation, cold) with an attack that does 170 bludgeoning damage at initiative 16
279 units each with 9375 hit points (weak to cold) with an attack that does 333 slashing damage at initiative 10
4346 units each with 3734 hit points (weak to cold; immune to fire, slashing) with an attack that does 8 bludgeoning damage at initiative 9
1564 units each with 1596 hit points with an attack that does 8 bludgeoning damage at initiative 19
361 units each with 1862 hit points (weak to bludgeoning, slashing) with an attack that does 40 bludgeoning damage at initiative 3
427 units each with 8025 hit points (immune to fire, slashing; weak to cold) with an attack that does 139 bludgeoning damage at initiative 7

Infection:
27 units each with 24408 hit points (weak to bludgeoning, fire) with an attack that does 1505 cold damage at initiative 5
137 units each with 29784 hit points (immune to slashing) with an attack that does 423 cold damage at initiative 12
1646 units each with 15822 hit points (weak to slashing, cold; immune to fire) with an attack that does 16 fire damage at initiative 6
1803 units each with 10386 hit points (immune to cold, radiation) with an attack that does 11 bludgeoning damage at initiative 17
2216 units each with 39081 hit points with an attack that does 28 bludgeoning damage at initiative 20
3192 units each with 40190 hit points (weak to radiation, cold; immune to slashing) with an attack that does 22 radiation damage at initiative 15
1578 units each with 69776 hit points with an attack that does 63 cold damage at initiative 4
2950 units each with 40891 hit points (weak to fire) with an attack that does 25 slashing damage at initiative 8
70 units each with 56156 hit points (weak to radiation) with an attack that does 1386 radiation damage at initiative 13
1149 units each with 48840 hit points (weak to slashing) with an attack that does 63 slashing damage at initiative 18";
        public const string Part1FullRunOutput = "14000";
        public const string Part2FullRunOutput = "6149";
    }
}
