﻿using NUnit.Framework;
using WindowsillSoft.CodeChallenges.AdventOfCode._2018;

namespace WindowsillSoft.CodeChallenges.AdventOfCode.Tests.AoC2018
{
    public class Day18Test : TestBase<Day18>
    {
        [Test,
            TestCase(".#.#...|#.\n.....#|##|\n.|..|...#.\n..|#.....#\n#.#|||#|#|\n...#.||...\n.|....|...\n||...#|.#|\n|.||||..|.\n...#.|..|.", "1147")]
        public void Part1(string input, string result)
        {
            var solver = GetSolver(input);

            Assert.That(solver.ExecutePart1(), Is.EqualTo(result));
        }

        [Test]
        public void FullRun()
        {
            var solver = GetSolver("........#.##..#|#|.#.....|......#..#.|..##..||.#..\n#|##.|||.|..|||......|.##.#|#|....||#.#...#...#..#\n..##...#|#..|#.|..#||#...|#....|#...#|#.|.||...|..\n.....#|||.|.#...###|....|#..#.#.#.|..#||#|....|#.|\n....|.....#.||.#..#...#|....|||..#....##...|..|.#|\n||...|###..|..|||..|#.##|.####.#...|.||.|....|.##.\n..#.#.###..||......#|#|.|....#|.#|.|...#....#...#|\n.|..||||||...#.##..|.#||.#|##|..#.#..##..#...|#...\n.|.....||...#.#|.##|..|.##||..#.#..|..#.#.#..|.#|.\n||...|#........#.|..##|.|..#...#...#|#|..||.|....#\n#||.|.|..|.......##....|..#||#.#|.|||......|..||..\n.....#.|||.....|.#.#.......#.|..#.|.....|.|.#...#.\n...#.##.#.||#.#|.#.##..#.||#.#.#|#.||.||.|......#.\n|.|...#|.|####|.|..#.#|....|......|....|...||#||..\n.#...#.#......|...#.....|.....|.#|...##|||...#.|#.\n||##.#...#.|...##..##.||#...#|...|##.##...#||..#|.\n|.|#.||..|##.|.#.|..#..|.##.#.......#...|....||...\n.|.......#..##...|.|..|#.#....|#|..##|#|.##|.|.|#.\n.|....|.#|||#.#..#..|||.....||...#|.#..|..#.#...#.\n...#..###.#|.##||.#.|.||###..|..|#.|#..||......||.\n..##.......##|.....#...|#|..##|.#.|||.|#....|##...\n#...#|##|......##|...|#..#.|..##..#..#.|##.##|#..#\n|.#|.....|..#...|....|...#....#|..#.....||...|#|.|\n##...#.....#.....|#|.......|....####.#..##.|.##...\n.....|...|#|#..|#|.|..##.|..|....##..||.#...|..|.|\n.|..|....##.||||.##|.#...|..|#|.#.|####.|..|##.#..\n#.........|##.#|..##|...|........|..|....|..#...##\n.#.|...#...#...|.|...|..|.#.|....#..|.|..|..#|....\n.....#.....#|.#....|....##...##....###....#.|...|.\n||.....|.|.##|.##||.#|#.##|.#..|#####|...|...||#.#\n...#||....#.....##.|##|.##|#.##.#|.|.....#........\n..##.....||..#..#.|..##...#.|.|.|.|...|.#.|..|....\n|##..|..........##..#|...|......||.#....#....|..#.\n...#..|.#.|...|.##|.##..##..|.|....#||#|##..||||..\n#...##......|..|#...#.#.|#||..#...|.#...|..###.||.\n|#.......|#.|##|....|.....#..||.|#|#...#|....|..#|\n.|.....#|##.|.#...#..#||#.....|....#||.#|.##.##.#|\n|#..###..#..|#.....##...||.|.|.#.#|.||..||.||#|#..\n||||#....|#..|.|...|...||....|...#....#.##...#|...\n...||##||#......|#.#..#..|.....|...#..#|...#...|||\n.|#.|.|....|...#.....|#....|..#.#...#...||..##|..|\n||#.|##.|...|.##......##|#..#..#.#.#.....|#|##.##.\n|.#.....||.....#.#...|...|..|#|..|..#...|....|...|\n###..#.#......#|..#....#......|##.##....|||.|..#|.\n..#.|.#...#..|#####|.....##.|.|#......|..||.#|....\n.#||.|.##..#.|..##......|..|.|#..|.....#.....|#|..\n|##.#......#.#.#.#|||#|....#...#.|.........|||.#..\n|......||.|..#.|#||...||.#.#.##..#..#.#....#.#..#|\n#.|..##.....#..|...|#...#...|.......|.|..|#|......\n##...#....#..#..#....|...#|#.||.|...|.#..###|##|.|");
            Assert.That("620624", Is.EqualTo(solver.ExecutePart1()));

            //TODO: Fix the solver actually keeping state between parts :[
            solver = GetSolver("........#.##..#|#|.#.....|......#..#.|..##..||.#..\n#|##.|||.|..|||......|.##.#|#|....||#.#...#...#..#\n..##...#|#..|#.|..#||#...|#....|#...#|#.|.||...|..\n.....#|||.|.#...###|....|#..#.#.#.|..#||#|....|#.|\n....|.....#.||.#..#...#|....|||..#....##...|..|.#|\n||...|###..|..|||..|#.##|.####.#...|.||.|....|.##.\n..#.#.###..||......#|#|.|....#|.#|.|...#....#...#|\n.|..||||||...#.##..|.#||.#|##|..#.#..##..#...|#...\n.|.....||...#.#|.##|..|.##||..#.#..|..#.#.#..|.#|.\n||...|#........#.|..##|.|..#...#...#|#|..||.|....#\n#||.|.|..|.......##....|..#||#.#|.|||......|..||..\n.....#.|||.....|.#.#.......#.|..#.|.....|.|.#...#.\n...#.##.#.||#.#|.#.##..#.||#.#.#|#.||.||.|......#.\n|.|...#|.|####|.|..#.#|....|......|....|...||#||..\n.#...#.#......|...#.....|.....|.#|...##|||...#.|#.\n||##.#...#.|...##..##.||#...#|...|##.##...#||..#|.\n|.|#.||..|##.|.#.|..#..|.##.#.......#...|....||...\n.|.......#..##...|.|..|#.#....|#|..##|#|.##|.|.|#.\n.|....|.#|||#.#..#..|||.....||...#|.#..|..#.#...#.\n...#..###.#|.##||.#.|.||###..|..|#.|#..||......||.\n..##.......##|.....#...|#|..##|.#.|||.|#....|##...\n#...#|##|......##|...|#..#.|..##..#..#.|##.##|#..#\n|.#|.....|..#...|....|...#....#|..#.....||...|#|.|\n##...#.....#.....|#|.......|....####.#..##.|.##...\n.....|...|#|#..|#|.|..##.|..|....##..||.#...|..|.|\n.|..|....##.||||.##|.#...|..|#|.#.|####.|..|##.#..\n#.........|##.#|..##|...|........|..|....|..#...##\n.#.|...#...#...|.|...|..|.#.|....#..|.|..|..#|....\n.....#.....#|.#....|....##...##....###....#.|...|.\n||.....|.|.##|.##||.#|#.##|.#..|#####|...|...||#.#\n...#||....#.....##.|##|.##|#.##.#|.|.....#........\n..##.....||..#..#.|..##...#.|.|.|.|...|.#.|..|....\n|##..|..........##..#|...|......||.#....#....|..#.\n...#..|.#.|...|.##|.##..##..|.|....#||#|##..||||..\n#...##......|..|#...#.#.|#||..#...|.#...|..###.||.\n|#.......|#.|##|....|.....#..||.|#|#...#|....|..#|\n.|.....#|##.|.#...#..#||#.....|....#||.#|.##.##.#|\n|#..###..#..|#.....##...||.|.|.#.#|.||..||.||#|#..\n||||#....|#..|.|...|...||....|...#....#.##...#|...\n...||##||#......|#.#..#..|.....|...#..#|...#...|||\n.|#.|.|....|...#.....|#....|..#.#...#...||..##|..|\n||#.|##.|...|.##......##|#..#..#.#.#.....|#|##.##.\n|.#.....||.....#.#...|...|..|#|..|..#...|....|...|\n###..#.#......#|..#....#......|##.##....|||.|..#|.\n..#.|.#...#..|#####|.....##.|.|#......|..||.#|....\n.#||.|.##..#.|..##......|..|.|#..|.....#.....|#|..\n|##.#......#.#.#.#|||#|....#...#.|.........|||.#..\n|......||.|..#.|#||...||.#.#.##..#..#.#....#.#..#|\n#.|..##.....#..|...|#...#...|.......|.|..|#|......\n##...#....#..#..#....|...#|#.||.|...|.#..###|##|.|");
            Assert.That("169234", Is.EqualTo(solver.ExecutePart2()));
        }
    }
}

