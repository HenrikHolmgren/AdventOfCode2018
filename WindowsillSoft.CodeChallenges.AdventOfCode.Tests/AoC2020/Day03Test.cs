﻿using NUnit.Framework;
using WindowsillSoft.CodeChallenges.AdventOfCode._2020;

namespace WindowsillSoft.CodeChallenges.AdventOfCode.Tests.AoC2020
{
    public class Day03Test : TestBase<Day03>
    {
        [Test,
            TestCase("..##.......\n#...#...#..\n.#....#..#.\n..#.#...#.#\n.#...##..#.\n..#.##.....\n.#.#.#....#\n.#........#\n#.##...#...\n#...##....#\n.#..#...#.#", "7")]
        public void Part1(string input, string result)
        {
            var solver = GetSolver(input);

            Assert.That(solver.ExecutePart1(), Is.EqualTo(result));
        }

        [Test,
            TestCase("..##.......\n#...#...#..\n.#....#..#.\n..#.#...#.#\n.#...##..#.\n..#.##.....\n.#.#.#....#\n.#........#\n#.##...#...\n#...##....#\n.#..#...#.#", "336")]
        public void Part2(string input, string result)
        {
            var solver = GetSolver(input);

            Assert.That(solver.ExecutePart2(), Is.EqualTo(result));
        }
        [Test]
        public void FullRun()
        {
            var solver = GetSolver(".........#..##..#..#........#..\n#...#..#..#...##.....##.##.#...\n....#..............#....#....#.\n#.#..#.....#...#.##..#.#.#.....\n........#..#.#..#.......#......\n.#........#.#..###.#....#.#.#..\n........#........#.......#.....\n...##..#.#.#........##.........\n#.#.##..###............#...#...\n............#....#.......###.##\n....##....##..#........#......#\n............#.#..........#.....\n#.#....#....##...#.....#.....#.\n......#.#.#...#.....###....#..#\n...........##..#.........#..#.#\n..#..#.................#..#..#.\n.#....###...#.......#.........#\n#.#.#.#...#......#.......#...#.\n.......#.#.#...#..............#\n...##.......#..##.#.......##...\n#.#.##....#..##..##..###...###.\n.#......##.##.#....#.##........\n..###.............##..##..#....\n.....#.#...........#..##..##...\n.###.#.#......#.....#........##\n...#.......#...##..#..#..#.....\n..............#.#..##.##..##..#\n#..#.#......#............#.....\n........#..#....#..............\n...#...#..............#.#####..\n...##......#........#.#...#....\n..##......#............#..#..#.\n....#.........#.#.#.....###.#..\n#....#........#........#....#.#\n.....#...#..##.....##...#.....#\n#...#.#.#...##..##.###.#.#.....\n......#.#..........#...#.##....\n..............##...#..#.......#\n........##.....#.....#.#....#..\n..............#..#..#...#.....#\n##......##.......##...#.#....#.\n.....#.............#.#.........\n#.........##..#..#.........##..\n..#..#.....#####.........##.#..\n.......##.#......#........#....\n#.................#.#...#....#.\n...#........#.###.##.##.....#..\n#.....##..#...##.#.#......#....\n.....#..#.#..........##..#.##..\n..###.............#..#..#...#..\n...###..#...#.....##..........#\n#.......#.#...#....#..##..#..#.\n.#..#.........#..............#.\n..######.....#....##......#....\n#..##...#......#..#.#....#.....\n.#...................#.#.....#.\n..#...#.#..#.#......#..#...#..#\n..##..##.#.##.........#.#.#....\n...#...#...........#..##.##...#\n#...#....#....#....#..#.##..#..\n..#.##....#....###..#..........\n#.#..##.#.#...##.#..#.##..#.#..\n#......##...#.#..........#..#..\n#.#...#..#...#.#.#..#........#.\n#.#.##.#..#...#..#.#.##........\n.....#......#........#..#......\n...#....#.#....#...............\n....#..###..#....#..#....#....#\n.#........###..........##.##.#.\n#.#......##....##...##.#......#\n#..##.##...#...........##.#.#..\n.#.....#.#...#.................\n##..........#..#....#.....#...#\n....#.#..........##..#.....#.##\n#.#..#..#..##..........#.......\n..#.#.###......................\n......##..##.....#..##.##....#.\n...#.......#.##....#......#....\n...#...#........#...#.#...#..##\n##...#....#.#...#.#.##..##...#.\n...#.....#...#...#....###.#..#.\n..#.#..#........#......#..##..#\n...#......#...#.#.##...##.#.#.#\n....#.#....#....#.....#.....##.\n.....#.#..##.#....##....##.....\n.#...###..#.....#............#.\n#..#.#.#..#..#...#....#...#....\n#.....#..#...#................#\n..........#..#.......#......#.#\n...#..#......#...#......#......\n.#.#.....#.#.#.#......#..#..#..\n.....#.........#.#.#.....##.#..\n.....#.#.....#..#..#..#.....###\n##....#......##....##.#....#.#.\n#####........#..........##.....\n.#...##...#...#.......#....#...\n#.#.##...##...##..##........#..\n#.#..............#.#...#...###.\n...#.....##..#.........#....#.#\n#.#....#....#..##.#..#...#.....\n..#....#.#..#...#...##.....#...\n....#...#......................\n..#...#.......#..#...##....#...\n.#........#...#.....##.##...#..\n#......#..............#..#..#..\n...........#.#..#.#.#....#....#\n.##..##.......#...#..#.....#..#\n...#.........#.........###..#..\n...#.##....#....#.....#.....#..\n.#.#.#.........#.#.#....#....#.\n...#..........##..#....#.#.....\n...#....##................#....\n#....##..#..#........##...#....\n#...#...##.#............#....#.\n##..#....#...#...............#.\n..........#.#...#..##..#.#.....\n..##...##..#....#.#......#.....\n.......#......#.#.....#.....##.\n#...###.....##..##....#.#....#.\n.###......#.....#.#............\n#.....#.....####.##....#..#....\n......###.............#......##\n.........##.......##..#..#..#..\n.#.......#....#...#...#.#......\n#...#..#...#........#...##..#..\n.#....#........#.........##..#.\n..............##.#...##..#.##.#\n.#....#...#....#......#..#.....\n#....##.#...#.#.....###..#....#\n#.......##.#..###..............\n#..#..#..#......#.#..#...#..#.#\n.......#.#.#..#..#...#..#......\n.#..#......#.....#......##..##.\n....#....#.......#.......#.#.##\n.......#.#................#...#\n#.#.....#.......#.#........#...\n.....#....##...#......#.....##.\n.#......#.#...#..#....#....#.##\n##...#.###.#....#..#....#.#...#\n....#.##..##.#.............#...\n#..#.............##.......#.#..\n##.#..#..#.#...........###...##\n.#.#.....#......###........#...\n#.#...#.#....##......#.#....#..\n#.........#..........#.........\n.......#....#...#..#.....#...##\n.......................#...#..#\n.###...........##...#........##\n#.#....######.#........#..##.#.\n..#.##.#...#.#.......#.##.##..#\n#.............###..#.##.#......\n...#..##......#...#..###.....#.\n..........#.....#..#...##..#...\n..##..........#.#..#.....#...#.\n...#.......#.....##.........#..\n#..#.#...#..#...###...#...#.#..\n#.##....#..#.#.......#..#..#...\n..#.##.#......#.#......#....#..\n..........#...##.....###.......\n...#...##..#......#...##.......\n....#........#.#.......#..###..\n.....#.#..........##.#..#..#.#.\n.............##.....#.#..##....\n...#...............##...#......\n....#......#..#....#...##..#...\n.##.#....#.#.....#.#.........#.\n.....#.###....#..###..#.#.....#\n.#.........##.........##...#...\n..#.....###....##..........#..#\n........#..#.#.#..#.......#..##\n..#.#..#.#............#.##.#..#\n.#....#.....#..#...#.......##..\n.#...........#.#..#..###.###...\n..#.....#..#........#.#........\n.#........##........#..#.##....\n......#.....##........##..#....\n.#..................##....#.#..\n.#..#.#..#.#...#........#......\n...#..##.#......#..#..........#\n....#.##...#....##.............\n#....#.##....##.###..#..#..#...\n..........#..#...##.##....#..#.\n.###.#.....#...#...#...#.......\n............#...............#.#\n#....#...#......#....#.#.#.#.##\n...#..........#.#.#.....###....\n#.#...##...#..#.....###...#....\n......#...#..#..#..#.##...##...\n...#..#.#....#...#.#.........##\n##....#..###.#.##.....##.......\n..#.#...#..##.......#.#.......#\n##......#...........#......#...\n.......#..###....###..##.#...##\n.........#.....#..#.......##..#\n.......#.##..#....#...#.#...#..\n#..#.#..................##.#..#\n...#..#..#.....#..#........#...\n...#.#..###..#.....##...#....#.\n..#..#......#...........#...#..\n#...##.##..###.......##........\n.#.....#..#....#.....#.##....#.\n#..#........#.#....#..#...#.###\n..#...#.#.#.....#.....#..#.....\n.##.............#.#......##...#\n.#....#####............#.....##\n#.###.......#.#...##.....#.....\n......#.##..#...#..#..##.#..##.\n......#.#...##.....#...#....##.\n....#............#...#...#....#\n.........##.#.#....#....#....##\n.#...##.#...#.......#.##....#.#\n#....#.#...#.#...#.#.#...#.....\n.#.#.........##..#..#..........\n.#.........#.#.....#..#.#..###.\n....##.#.#..........#..####....\n....#..#.#.#...#...#..#....#...\n..#.#...#...##.......#.#.#..#..\n...##...#......#.....#.#...#..#\n......#.###.#.......##...#...#.\n.....#.#.#......##..........###\n##.#.#.#..#....#...............\n.#.#.##.......#....#.#.....#..#\n.........#...#.#..#.......#....\n....#.####.#......#...#...##...\n#..#..#..#..#....#...##.....##.\n......####.#..##..#.....##.....\n##.#.........#........#..#.#...\n.#.#....#....#.......#.#....##.\n....#....#.......##..#.....#...\n.#......#..#....#.#............\n#..#.#.##.....#..#.#.#.#.#.##..\n.#.....#.....#...#..#.#...#.#..\n.#.#.##............#.#.#.#.#.#.\n.##..........#.....#...###.....\n#.#...#...#................#.#.\n##...#.##.....#.....#.#.##.....\n####.....##..........#......#..\n#.............#..............#.\n.###....#.#...#..#..#..#.......\n..#.#.....#...#..#..####.......\n...#.#..#........#..##..#..#.##\n.#........#..........#.#...##..\n.#.......#.#.#..#...#..#.#...##\n.#.....##......##..............\n......#..#.#.##...##.#.....#...\n.........#.#...##.....##....#.#\n.....##...#........#..#.#..#.#.\n.#.##..#.....##...#...###.#.#..\n...##...#...#..#.#..#..........\n##..............#...#...#.#..#.\n......#..#......#..#.....#...#.\n.......#...#..#....#.....#.....\n..##.....##..#.#........#......\n.###.#...#.....................\n..#...#.................#...#..\n#..#.##...####.............#...\n.##....#..####.......#.........\n#..#...###...#...#..#..##......\n....#.##.#.#.........#.....#..#\n.....#...#.....#.#.#.##.#...##.\n.............#........#.....#..\n...##.###.#....##.......#..#...\n#..#....#....#.#............#..\n.........#.##........##.....#..\n.........#.#.#..#..#.......#...\n.......#.#..#.......#.....#.#..\n##.#.....##...##.....#.#.......\n.#.#.#......##.##.#.........#..\n..#.##..###.....###.........##.\n.#......#..#..##...#.#...##.#.#\n......#.#............#.....#...\n###.#..#..#..#..#.##...#.......\n.#.#.##..###....#......##..###.\n#...#.#.#..#..#..##.#.##....#..\n..#...#...####...#......####.##\n..##.#.####........#..#......#.\n.#..#.......#...#.#.........#..\n........#.#....#..#####..#.....\n.#...........#..#..#..#...#....\n....#....#...#.................\n....##..#....##....#..#....#.##\n....#.##.....###...#...##.##...\n......##.#..##.#.#.#....#.#.#..\n##.#...###....#.#..#.#.###....#\n......###..#..#..........##...#\n..........#.##...##..#....##.#.\n.#...#.#..#.#.#..#.....#.......\n.#....#..#.#..#.#...##.#.#.....\n.##.....#...#..##.#........#...\n....#......#.........#....#..##\n.#..#.#.#.#..#..#.#.........#..\n.........#.....#...#....#......\n#..#..#........#...#.#.........\n...#.#.#...##.#.#...#..#......#\n#.#.#.#........#...#..#.....#..\n.###..#..#..###..#..#..........\n.....#......#.#..#...#.......#.\n##.##.........#.......##.......\n#...##.......#..#.#.......#....\n#..#..#.....#...#......#.......\n.#..#..#.##....#.#..#...#...#..\n.#...#.....#..#.........#..#...\n...#.#.#.......#....#..##.....#\n.........#..##.#..#..#.#.......\n#.##.....##..###..#..#..#.##...\n........#......#...##...###..##\n.##....##..#..#..###......#....\n............##......#...#..##..\n...##.......#......#...##.##..#\n...#..#..#.#...####.#.......#..\n..#.##..#....#......#.#.....#..\n..#.##..............#..##.....#\n.....##....#......#....#......#\n......#..#......#.........#..#.\n...#.##.###...###..#.##........\n..........####.#.##.....#..#.##\n#...##...........#...........##\n#.#..#.#....#.#..#....##......#\n.......#...#.....#......#.#.##.\n....#.##..##..........#..#.....\n#.#.#...#......#...#.....#.##.#\n........#.......#..##.....##...\n.....####.#....#.#.............");
            Assert.That("156", Is.EqualTo(solver.ExecutePart1()));
            Assert.That("3521829480", Is.EqualTo(solver.ExecutePart2()));
        }

    }
}
