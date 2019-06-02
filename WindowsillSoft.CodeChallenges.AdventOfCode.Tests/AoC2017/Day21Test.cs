﻿using Moq;
using NUnit.Framework;
using WindowsillSoft.CodeChallenges.AdventOfCode._2017;

namespace WindowsillSoft.CodeChallenges.AdventOfCode.Tests.AoC2017
{
    public class Day21Test : TestBase<Day21>
    {
        [Test,
            TestCase("2", "../.# => ##./#../...\n.#./..#/### => #..#/..../..../#..#", "3")]
        public void Part1(string iterationCount, string input, string output)
        {
            var IOProvider = Mock.Get(this._provider)
               .Setup(p => p.RequestInput("Iteration count?"))
               .Returns(iterationCount);

            var solver = GetSolver(input);
            Assert.That(solver.ExecutePart1(), Is.EqualTo(output));
        }

        [Test,
            TestCase("2", "../.# => ##./#../...\n.#./..#/### => #..#/..../..../#..#", "3")]
        public void Part2(string iterationCount, string input, string output)
        {
            var IOProvider = Mock.Get(this._provider)
               .Setup(p => p.RequestInput("Iteration count?"))
               .Returns(iterationCount);

            var solver = GetSolver(input);
            Assert.That(solver.ExecutePart2(), Is.EqualTo(output));
        }

        [Test]
        public void FullRun()
        {
            var IOProvider = Mock.Get(this._provider)
               .Setup(p => p.RequestInput("Iteration count?"))
               .Returns("5");

            var solver = GetSolver("../.. => ..#/.#./...\n#./.. => .../#../.##\n##/.. => .##/###/##.\n.#/#. => #.#/..#/#.#\n##/#. => .../.##/...\n##/## => ##./..#/..#\n.../.../... => ##../..../##../.###\n#../.../... => ...#/.#.#/.#../.#.#\n.#./.../... => #.#./...#/#.#./.##.\n##./.../... => ..#./#.##/#.../.###\n#.#/.../... => ##../##.#/..#./#.##\n###/.../... => ..../.#.#/.###/#..#\n.#./#../... => #..#/#.../.##./....\n##./#../... => #.##/..##/####/.###\n..#/#../... => ..#./#.##/####/####\n#.#/#../... => .##./#.##/#.#./##.#\n.##/#../... => #.##/####/.###/...#\n###/#../... => ..../#.#./##.#/..##\n.../.#./... => .###/.##./##../.##.\n#../.#./... => ..../#.##/...#/#.#.\n.#./.#./... => ...#/####/.##./#...\n##./.#./... => .###/#.##/###./....\n#.#/.#./... => #.##/###./..../..#.\n###/.#./... => .#../#.#./#.##/#.##\n.#./##./... => .###/##../..##/#..#\n##./##./... => ..#./#.#./.#.#/##.#\n..#/##./... => .#../####/...#/..##\n#.#/##./... => ..../##.#/.##./....\n.##/##./... => .#.#/.#.#/.##./####\n###/##./... => ##.#/..../..../....\n.../#.#/... => ..##/##../##.#/###.\n#../#.#/... => ####/#.##/#.../###.\n.#./#.#/... => ..../#..#/..##/.#..\n##./#.#/... => #.../..##/##../..#.\n#.#/#.#/... => ...#/#.#./#.#./#...\n###/#.#/... => ###./###./##.#/###.\n.../###/... => ..#./###./##.#/####\n#../###/... => ##.#/..#./##../..##\n.#./###/... => #.../#.##/##../....\n##./###/... => ..##/.#.#/#..#/#.##\n#.#/###/... => #.##/..#./.#../..##\n###/###/... => ..#./#..#/####/.##.\n..#/.../#.. => ##.#/#.##/...#/###.\n#.#/.../#.. => #..#/..#./##../###.\n.##/.../#.. => ..#./.#../###./#.#.\n###/.../#.. => ...#/...#/.#.#/.##.\n.##/#../#.. => ##../#.#./#..#/##..\n###/#../#.. => ##../.#.#/##../#..#\n..#/.#./#.. => ##.#/##.#/...#/.#..\n#.#/.#./#.. => .###/.#.#/###./....\n.##/.#./#.. => #..#/###./####/..#.\n###/.#./#.. => ..#./.###/.###/...#\n.##/##./#.. => #.##/..##/...#/.###\n###/##./#.. => ####/##.#/#.##/#..#\n#../..#/#.. => ..../.##./#.##/#...\n.#./..#/#.. => #..#/##../...#/#...\n##./..#/#.. => ..#./.###/..##/.#.#\n#.#/..#/#.. => .##./..##/..#./#..#\n.##/..#/#.. => ####/.#.#/#.../.#.#\n###/..#/#.. => ..../..##/#.##/###.\n#../#.#/#.. => #.##/.#.#/.#../.##.\n.#./#.#/#.. => ..##/###./.###/###.\n##./#.#/#.. => ##.#/##.#/#.#./##..\n..#/#.#/#.. => ###./###./.#.#/.#..\n#.#/#.#/#.. => ##../..#./##../....\n.##/#.#/#.. => .###/#.#./##.#/##..\n###/#.#/#.. => ##.#/#.#./.#.#/#...\n#../.##/#.. => .#.#/...#/.#.#/..#.\n.#./.##/#.. => ###./##../##.#/....\n##./.##/#.. => ..##/###./#.#./#.#.\n#.#/.##/#.. => ##.#/..##/#..#/####\n.##/.##/#.. => ..../####/..#./##..\n###/.##/#.. => .###/#..#/..../.#..\n#../###/#.. => #..#/.#../.#.#/#...\n.#./###/#.. => .#../..../.##./.###\n##./###/#.. => ##.#/.#../.#.#/#..#\n..#/###/#.. => #.##/##../..##/#...\n#.#/###/#.. => ####/..##/.#../##.#\n.##/###/#.. => .###/#..#/.###/#.##\n###/###/#.. => ..##/.##./##../#..#\n.#./#.#/.#. => ..##/.##./.##./.###\n##./#.#/.#. => ..##/...#/.##./####\n#.#/#.#/.#. => .###/.###/#.#./.#..\n###/#.#/.#. => ##.#/###./##.#/####\n.#./###/.#. => ...#/..#./.#.#/.#..\n##./###/.#. => ###./##.#/#.../#.#.\n#.#/###/.#. => .##./#.#./...#/..#.\n###/###/.#. => .#.#/.#../..##/####\n#.#/..#/##. => .##./...#/#..#/.###\n###/..#/##. => #.##/.#.#/...#/..##\n.##/#.#/##. => ###./.###/...#/....\n###/#.#/##. => .##./.##./#.#./#...\n#.#/.##/##. => #.#./.##./.#.#/.###\n###/.##/##. => ..../####/.#.#/#.##\n.##/###/##. => .##./.###/###./.#..\n###/###/##. => #.../###./.##./##.#\n#.#/.../#.# => #.#./..../#.##/###.\n###/.../#.# => .#../.#.#/#.../.###\n###/#../#.# => ###./#..#/####/##..\n#.#/.#./#.# => ###./##.#/..../.#..\n###/.#./#.# => ####/.#.#/.#../..##\n###/##./#.# => #.#./####/..##/#...\n#.#/#.#/#.# => #.#./#.#./#.../#.##\n###/#.#/#.# => #.##/.#../..#./.##.\n#.#/###/#.# => .###/..##/####/#..#\n###/###/#.# => #.../..#./..#./#.##\n###/#.#/### => .#.#/.###/#.##/..##\n###/###/### => #.#./...#/.#../.#.#");
            var result = solver.Execute();
            Assert.That(result.Part1Result, Is.EqualTo(""));
            Assert.That(result.Part2Result, Is.EqualTo(""));
        }
    }
}
