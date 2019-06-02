﻿using NUnit.Framework;
using WindowsillSoft.CodeChallenges.AdventOfCode._2018;

namespace WindowsillSoft.CodeChallenges.AdventOfCode.Tests.AoC2018
{
    public class Day13Test : TestBase<Day13>
    {
        [Test,
            TestCase("/->-\\        \n|   |  /----\\\n| /-+--+-\\  |\n| | |  | v  |\n\\-+-/  \\-+--/\n  \\------/   ", "7,3")]
        public void Part1(string input, string result)
        {
            var solver = GetSolver(input);

            Assert.That(solver.ExecutePart1(), Is.EqualTo(result));
        }

        [Test,
            TestCase("/>-<\\  \n|   |  \n| /<+-\\\n| | | v\n\\>+</ |\n  |   ^\n  \\<->/", "6,4")]
        public void Part2(string input, string result)
        {
            var solver = GetSolver(input);

            Assert.That(solver.ExecutePart2(), Is.EqualTo(result));
        }

        [Test]
        public void FullRun()
        {
            var solver = GetSolver("                         /--------------------------------------------------------------------------------\\                                           \n                 /-------+-----------------------------------\\  /-------------------\\                     |              /--------------------------\\ \n                 |       |                                   |  |                   |                   /-+--------------+--------------\\           | \n                 |       |                                   |  |                   |                   | |              |              |           | \n      /----------+-------+-----------------------------------+--+>------------------+\\                /-+-+--------------+-------\\      |           | \n   /--+----------+-------+-----------------------------------+\\ |                   ||                | | |              |       |      |           | \n   |  |          |       |        /--------------------------++-+---------------\\   ||                | | |              |       |      ^           | \n   |  |          |       |        |                          || |           /---+---++----------------+-+-+--------\\     |       |      |           | \n   |  |        /-+-------+--------+--------------------------++-+\\          |   |   ||                | | |        |     |       |      |           | \n   |  |        | |       |        |                          || ||          |   |   ||                | | |        |     |       |      |           | \n   |  |        | |       |        |                          || ||          |   |   ||                | | |        |     |   /---+------+---\\       | \n   |  |        | |       |        |                     /----++-++----------+---+---++-------\\        | | |        |     |   |   |      |   |       | \n  /+--+--------+-+-------+--------+---------------------+----++-++-----\\    | /-+---++-------+--------+-+-+-------\\|     |   |   |      |   |       | \n  ||  |        | |       |        |    /----------------+----++-++-----+----+-+-+---++-------+--------+-+-+---\\   ||     |   |   |      |   |       | \n  ||  |/-------+-+-------+--------+\\   |                | /--++-++-----+----+-+-+---++-------+-------\\| | |   |   ||     |   |   |/-----+---+---\\   | \n  ||  || /-----+-+-------+--------++---+----------------+-+--++-++-----+----+-+-+---++-------+\\      || | |   |   ||     |   |   ||     |   |   |   | \n  ||  || |     | |       |        ||   |        /-------+-+\\ || ||     |    | | |   ||       ||      || | |   |   ||     |   |   ||     |   |   |   | \n  ||  || |     | |    /--+--------++---+--------+-\\     | || || ||     |    | | |   ||       ||      || | |   |   ||     |   |   ||     |   |   |   | \n  ||  || | /---+-+----+--+--------++---+--------+-+-----+-++-++-++-----+----+-+-+---++-------++------++-+-+---+--\\||     |   |   ||     |   |   |   | \n  ||  || | |   | |    |  |       /++---+--------+-+-----+-++-++-++-----+----+-+-+---++--\\    ||      || | |   | /+++-----+---+---++\\    |   |   |   | \n  ||  || | |   | |    |  |       |||   |  /-----+-+-----+-++-++-++-----+----+-+-+---++--+----++------++-+-+---+-++++-----+---+-\\ |||    |   |   |   | \n  ||  || | |   | |/---+--+-----\\ |||   |  |     | |     | || || ||     |    | | |   ||  |    ||      || | |   |/++++-----+---+-+-+++--\\ |   |   |   | \n  ||  || | |   | ||   |  |     | |||   |  |     | |     | || || ||     |    \\-+-+---++>-+----++------++-+-+---+++++/     |   | | |||  | |   |   |   | \n  ||  || | |   | ||   |  |     | |||   |  |     | |/----+-++-++-++-----+------+-+---++--+----++------++-+-+---+++++------+\\  | | |||  | |   |   |   | \n  ||  || | |   | ||   |  |     | |||   \\--+-----+-++----+-++-++-++-----+------+-+---++--+----++------++-+-+---/||||      ||  | | |||  | |   |   |   | \n  ||  ||/+-+---+-++\\  |  |     | ||| /----+-----+-++-\\  | || || \\+-----+------+-+---/|  |    ||      || | |    ||||      ||  | | |||  | |   |   |   | \n  ||  |||| |   | |||  |  |     | ||| |    |     | || |  | || ||  | /---+------+-+----+--+----++------++-+-+----++++------++--+-+-+++--+-+--\\|   |   | \n  ||  |||| |   | |||  |  |     | ||| |    |     | || |  | || ||  | |   |      | |    |  |    ||      || | |    ||||      ||  | | |||  | |  ||   |   | \n  ||  |||| |   | |||  |  |     | ||| |    |     | || |  | || ||  | |   |      | |    |  |    ||      || | |    ||||      ||  | | |\\+--+-+--++---/   | \n  ||  |||| |   | |||  |  |     | ||| |    |     | || |/-+-++-++--+-+---+------+-+----+--+----++------++\\| |    ||||      \\+--+-+-+-+--+-+--++-------/ \n /++--++++-+---+-+++--+--+-----+-+++-+----+-----+-++-++-+-++-++--+-+---+----\\ | |    |  |    ||      |||| |    |\\++-------+--+-+-+-/  | |  ||         \n |||/-++++-+--\\| |||  |  |     | ||| |    |     | || || | || ||  | |   |    | |/+----+--+----++----\\ |||| |    | ||       |  | | |    | |  ||         \n |||| |||| |  || |||  |  |     | ||| |    |     | || || | || ||  | |   |    | |||    |  |    ||    | |||| |    | ||       |  | | | /--+-+--++---\\     \n |||| |||| |  || |||  |  |     | ||| |/---+-----+-++-++-+-++-++-\\| |   |    | |||    |  |    ||    | |||| |    | ||       |  | | | |  | |  ||   |     \n |||| |||| |  || |||  |  |     | ||| ||   |     | || || | || || || |   |    | |||    |  |    ||    | |||| |    | ||       |  \\-+-+-+--+-+--+/   |     \n |||| |||| |  || |||  |  |     | ||| ||   |     | || || | || || || |   |    | |||    |  |    ||    | |||| |    | ||       |    | | |  | |  |    |     \n |||| |||| |  || |||  |  |     | ||| ||   |     | || ||/+-++-++-++-+---+----+-+++----+--+----++----+-++++-+----+-++-------+----+-+-+--+-+\\ |    |     \n |||| |||| |  || |||  |  |     | ||| ||   |     | || |||| || || || |   | /--+-+++----+--+-\\  ||    | |||\\-+----+-++-------+----+-+-+--+-/| |    |     \n |||| |||| |  || |||  |  |     | ||| ||   |     | || |||| || || || |   | | /+-+++----+--+-+--++----+-+++--+----+-++-------+\\   | | |  |  | |    |     \n |||| |||\\-+--++-+++--+--+-----+-+++-++---+-----+-++-++++-++-++-++-+---+-+-++-+++----+--+-+--+/    | |||  |  /-+-++-------++---+-+-+--+--+-+-\\  |     \n |||| ||\\--+--++-++/  |  |     | ||| || /-+-----+-++-++++-++-++-++-+---+-+-++-+++----+--+-+--+-----+-+++--+--+\\| ||       ||   | | |  |  | | |  |     \n |||\\-++---+--/| ||   |  |     |/+++-++-+-+-----+-++-++++-++-++-++-+---+-+-++-+++----+--+\\|  |     | |||  |/-+++-++-------++---+-+-+--+--+-+-+--+--\\  \n |||  ||   |   | ||   |  |     ||||| || | |     | || |||| || || || |   | | || |||/---+--+++--+-----+-+++--++-+++-++-------++---+-+-+--+-\\| | |  |  |  \n |||  ||   |   |/++---+--+-----+++++-++-+-+-----+-++-++++-++-++-++-+---+-+-++-++++---+--+++--+-----+-+++--++-+++-++\\      ||   | | |  | || | |  |  |  \n |||  || /-+---++++---+--+-----+++++-++\\| |     | || |||| || || || |   | | || ||||   |  |||  |     | |||  || ||| |||      ||   | | |  | || | |  |  |  \n |||  || | |   ||||   |  |     ||||| |||| |     \\-++-++++-+/ || || |   | | || ||||   |  |||  |   /-+-+++--++-+++-+++------++---+-+-+--+-++-+-+--+\\ |  \n |||  || | |   |||\\---+--+-----/|||| |||| |       ||/++++-+--++-++-+---+-+-++-++++---+--+++--+---+-+-+++--++-+++-+++-\\    ||   | | |  | || | |  || |  \n ||| /++-+-+---+++----+--+------++++-++++-+-------+++++++-+--++-++-+---+-+-++-++++---+--+++--+---+-+-+++--++\\||| ||| |    ||   | | |  | || | |  || |  \n/+++-+++-+-+---+++----+--+------++++-++++-+-------+++++++-+--++-++-+---+-+-++-++++---+--+++--+---+-+-+++\\ |||||| ||| |    ||   | | |  | || | |  || |  \n|||| ||| | |   |||    |  |      ||||/++++-+-------+++++++-+--++-++-+---+-+-++-++++---+--+++--+---+\\| |||| |||||| ||| |    ||   | | |  | || | |  || |  \n|||| ||| | |   |||    |  |      ||\\++++++-+-------+++++++-+--++-++-+---+-+-++-++/|   |  |||  |   ||| |||| |||||| ||| |    ||   | | |  | || | |  || |  \n|||| ||| | |   |||    |  |    /-++-++++++-+-------+++++++-+--++-++-+---+-+-++-++-+---+--+++--+---+++\\|||| |||||| ||| |    ||   | | |  | || | |  || |  \n|||| ||| | |  /+++----+--+-\\  | || |||||| |       ||||||| |  || || | /-+-+-++-++-+---+-\\|||  |   |||||||| |||||| ||| |    ||   | | |  | || | |  || |  \n|||| ||| | |  ||||    |  | |  | || |||\\++-+-------+++++++-+--++-/| | | | \\-++-++-+---+-+++/  |   |||||||| |||||| ||| |    ||   | | |  | || | |  || |  \n||||/+++-+-+--++++----+--+-+--+-++-+++-++-+-------+++++++-+--++--+-+-+-+\\  || || |   | |||   |   |||||||| |||||| ||| |    ||   | | |  | || | |  || |  \n|||||||\\-+-+--++++----+--+-+--+-++-/|| || |      /+++++++-+--++--+-+-+-++--++-++-+---+-+++---+---++++++++-++++++-+++-+----++---+-+-+\\ | || | |  || |  \n|||||||  | |  |||\\----+--+-+--+-++--++-++-+------++++++++-+--/|  | | | ||  || |\\-+---+-+++---+---++/||||| |||||| ||| |    ||   | | || | || | |  || |  \n|||||||  | |  |||/----+--+-+--+-++--++-++-+\\     |||||||| |   |  | | | ||  || |  |   |/+++---+---++-+++++-++++++-+++-+----++\\  | | || | || | |  || |  \n|||||||  | |  ||||/---+--+-+\\ | ||  || || ||     |||||||| |   |  | | | ||  || |  |   |||||   |   ||/+++++-++++++-+++-+----+++--+-+-++-+-++-+-+-\\|| |  \n|||||||  | |  |||||   |  | || | ||  || || ||   /-++++++++-+--\\|  | | | ||  || |  |   |||||   |   |||||||| ||||||/+++-+----+++--+-+\\|| | || | | ||| |  \n\\++++++--+-+--+++++---+--+-++-+-++--++-++-++---+-++++++++-+--++--+-+-+-++--++-+--+---+++++---+---+++++++/ |||||||||| |    |||  | |||| | || | | ||| |  \n ||\\+++--+-+--+++++---+--+-++-+-++--++-++-++---+-++++++++-+--+/  | | \\-++--++-+--+---++/||   |   |||||||  |||||||||| |    |||  | |||| | || | | ||| |  \n || |||  |/+--+++++---+--+-++-+-++--++-++-++---+-++++++++-+--+-\\ | |   ||  || |  |   || ||   |   |||||||  |||||||||| |    |||  | |||| | || | | ||| |  \n/++-+++--+++--+++++---+--+-++-+-++--++-++-++---+-++++++++-+--+-+-+-+---++--++\\|  |   || ||   |   |||||||  |||||||||| |    |||  | |||| | ^| | | ||| |  \n||| |||  |||  ||\\++---+--+-++-+-++--++-++-++---+-++++++++-+--+-+-+-+---++--++++--+---++-++---+---+++++++--+++++++++/ |    |||  | |||| | || | | ||| |  \n||| |||  |||  || ||   |  | || | ||  || || ||   | |||||||| |  | | | |   ||  ||||  |   || ||   |   |||||||  |||||||||  |    |||  | |||| | || | | ||| |  \n|||/+++--+++--++-++---+--+-++\\| ||  || || ||   | |||||||| \\--+-+-+-+---++--++++--+---++-++---+---++++/||  |||||||||  |  /-+++--+-++++-+-++\\| | ||| |  \n|||||||  |||  || ||   \\--+-++++-++--++-++-++---+-+/||||||    | | | |   ||  ||||  |   || ||   |   ||\\+-++--+++++++++--+--+-+++--+-++++-+-++++-+-/|| |  \n|||^|||  |||  || ||      |/++++-++--++-++-++---+-+-++++++----+-+-+-+---++--++++--+---++-++---+---++-+-++--+++++++++--+--+-+++\\ | |||| | |||| |  || |  \n|||||||  |||  || ||      |||||| ||  || || ||   | | ||||||    | | | |   ||  ||||  |   |\\-++---+---++-+-++--+++++++++--+--+-++/| | ||\\+-+-++++-+--/| |  \n|||||||  |||  ||/++------++++++-++--++-++-++---+-+-++++++-\\  | | | |   ||  ||||  |   |  ||   |   || | ||  |||||||||  |  | || | | || | | |||| |   | |  \n|||||||  |||/-+++++------++++++\\|| /++-++-++---+-+\\|||||| |  | | | |   ||  ||||  |   |  ||   |   || | ||  |||||||||  |  | || | | || | | |||| |   | |  \n|||||||  |||| |||||      \\++++++++-+++-++-++---+-++++++++-+--+-+-+-+---++--++++--+---+--++---+---++-+-++--/||||||||  |  | || | | || | | |||| |   | |  \n|||||||  |||| v||||     /-++++++++-+++-++-++---+-++++++++-+--+-+-+-+---++--++++--+\\  |  ||   |   || | ||   ||||||||  | /+-++-+-+-++-+\\| |||| |   | |  \n|||||||  |||| |||||     | ||v||||| ||| ||/++->-+-++++++++-+--+-+-+-+---++--++++--++--+--++---+---++-+-++-\\ ||||||||  | || || | | || ||| |||| |   | |  \n|||||||  |||| ||||| /---+-++++++++-+++-+++++--\\| |||||||| |  | |/+-+---++--++++--++--+--++---+---++-+-++-+-++++++++--+-++-++-+-+-++-+++\\|||| |   | |  \n|||||||  |||| ||||| |   | |||||||| ||| |||||  || |||||||| |  | ||| |   || /++++--++--+--++---+---++\\| || | |||||^||  | || || | | || |||||||| |   | |  \n|||||||  |||| ||||| |   | |||||||| ||| |||||  || ||\\+++++-+--+-+++-+---++-+++++--++--+--++---+---++++-++-+-++++++++--+-++-/| | | || |||||||| |   | |  \n|||||||  |||| ||||| |   | |||||||| ||| |||||  || || \\++++-+--+-+++-+---++-+++++--++--+--++---+---++++-++-+-++++++++--/ ||  | | | || |||||||| |   | |  \n|||||||  |||| ||||| |   | |||||||| ||| |||||  || \\+--++++-+--+-+++-+---++-+++++--++--+--++---+---++++-++-+-++++++++----++--+-+-+-++-/||||||| |   | |  \n|||||||  |||| ||||| |   | |||||||| ||| |||||  ||  |  |||| |  | ||| |  /++-+++++--++--+--++---+---++++-++\\| ||||||||    ||  | | | ||  ||||||| |   | |  \n^||||||  |||| ||||| |   | |||||||| \\++-+++++--++--/  |||| |  | ||| |  ||| |||||  ||  |  ||   |   |||| |||| ||||||||    ||  | | | ||  ||||||| |   | |  \n|||||||  |||| ||\\++-+---+-++++++++--++-+++++--++-----++++-/  | ||| |  ||| |||||  ||  |  ||   |   |||| |||| ||||||||    ||  | | | ||  ||||||| |   | |  \n|||||||  |||| || || |   | ||||||||  || ||||| /++-----++++----+-+++-+\\ ||| |||||  ||  |  ||   |   |||| |||| ||||||||    ||  | | | ||  ||||||| |   | |  \n|||||||  |||| || || |   | ||||||||  || ||||| |||     ||||    | ||| || ||| |||||  ||  |  ||   |   |||| \\+++-++++++++----++--+-+-+-/|  ||||||| |   | |  \n|||||||  |||| || || |   \\-++++++++--++-+++++-+++-----++++----+-+++-++-+++-+++++--+/  |  ||   |   ||||  ||| ||||||||    ||  |/+-+--+--+++++++-+\\  | |  \n|||||||  |||| || || |     ||||||||  || ||||| |||     ||||    | ||| || ||| |||||  |   |  ||   |   ||||  ||| ||\\+++++----++--+++-+--+--+++++++-/|  | |  \n|||||||  |||| || || |     ||||||||  |\\-+++++-+++-----/|||    | ||| || ||| ||||| /+---+--++---+---++++--+++-++-+++++----++--+++-+\\ |  |||||||  |  | |  \n|||||||  |||| || || |     ||||||||  |  ||||| |||      |||    | |\\+-++-+++-+++++-++---+--++---+---++++--+++-++-+++++----++--+++-++-+--++/||||  |  | |  \n|||||||  |||| || || |     ||||||||  \\--+++++-+++------+++----+-+-+-++-+++-+++++-++---+-<++---+---+/||  ||| || |||||    ||  ||| || |  || ||||  |  | |  \n|||||||  |||| || ||/+-----++++++++-----+++++-+++------+++----+-+-+-++-+++-+++++-++---+--++\\  |   | ||  ||| || |||||    ||  ||| || |  || ||||  |  | |  \n|\\+++++--++++-++-++++-----++++++++-----+++++-+++------+++----+-+-+-++-+++-++/|| ||   |/-+++--+---+-++--+++-++-+++++----++--+++-++-+--++-++++--+\\ | |  \n\\-+++++--++++-++-++++-----++++++++-----+++++-+++------+++----+-+-+-++-+++-++-/\\-++---++-+++--+---+-++--+++-++-++++/    ||  ||| || |  || ||||  || | |  \n  |||||  |||| || ||||     ||||\\+++-----+++++-+++------+++----+-+-+-++-+++-++----++---++-+++--+---+-+/  ||| || ||||     |\\--+++-++-+--++-++/|  || | |  \n  |||||  |||| || ||||    /++++-+++-----+++++-+++------+++----+-+-+-++-+++-++----++---++-+++-\\|   | |   ||| || ||||     |   ||| || |  || || |  || | |  \n  |||||  |||| || ||||/---+++++-+++-----+++++-+++-----<+++----+-+-+-++-+++-++----++---++-+++-++---+-+---+++-++-++++---\\ |   ||| || |  || || |  || | |  \n  |||||  |||| || |||||   ||||| |||     ||||| |||      |||    | | | || ||| ||/---++---++-+++-++---+-+---+++-++-++++---+-+---+++-++-+--++-++-+-\\|| | |  \n  |||||  |||| || |||||   ||||| |||   /-+++++-+++------+++----+-+-+-++-+++-+++---++---++-+++-++---+-+---+++-++-++++---+-+---+++-++\\|  || || | ||| | |  \n  ||||\\--++++-++-+++++---+++++-+++---+-+++++-+++------+++----+-+-+-++-+++-+++---++---/| ||| || /-+-+---+++\\|| ||||   | |   ||| ||||  || || | ||| | |  \n  ||||   |||| |\\-+++++---+++++-+++---+-+++++-+++------+++----+-+-/ || ||| ^||   ||    | ||| || | | |   |||||| ||||   | |   ||| ||||  || || | ||| | |  \n  ||||   |||| |  |||||/--+++++-+++---+-+++++-+++------+++----+-+---++-+++-+++---++----+-+++-++-+\\| |   |||||| ||||   | |   ||| ||||  || || | ||| | |  \n  ||||   |||| |  ||||||  ||||| |||   | ||||| |||      |||    | |   || |||/+++---++---\\| ||| || ||\\-+---++++++-++++---+-+---+++-++++--++-++-+-+++-/ |  \n  ||||   |||| |  ||||||  ||||| |||   | ||||| |||      |||    | |   || |||||||   ||   || ||| || ||  |   |||||| ||||   | |   ||| ||||  || || | |||   |  \n  ||||   |||| |  ||||||  ||||| |||   | ||||| |||      |||    | |   || |||||||   || /-++-+++-++-++--+---++++++-++++\\  | \\---+++-++++--/| || | |||   |  \n  \\+++---++++-+--++++++--+++++-+++---+-+++++-+++------+++----+-+---++-+/|||||   || | || ||| || ||  |   |||||| |||||  |     ||| ||||   | || | |||   |  \n   \\++---++++-+--++++++--++++/ |||   | ||||| |||      \\++----+-+---++-+-+++++---++-+-++-+++-++-++--+---/||||| |||||  |     ||| ||||   | || | |||   |  \n    ||   |||| |  ||||||  ||||  ||\\---+-+++++-+++-------++----+-+---++-+-+++++---++-+-++-/|| || ||  |    ||||| |\\+++--+-----+++-++++---/ || | |||   |  \n    ||   |||| |  ||||||  |\\++--++----+-+++++-+++-------++----+-+---++-+-+++++---++-+-++--++-++-++--+----+++++-+-+++--+-----++/ ||||     || | |||   |  \n    ||   |||| |  |\\++++--+-+/  ||    | ||||| |||       ||    | |   || \\-+++++---++-+-++--++-++-++--+----/|||| | |||  |     ||  ||||     || | |||   |  \n    ||   |||| |  | ||||  | |   ||    |/+++++-+++----\\  ||    | |   ||   |||||   || | ||  || || ||  |     |||| | |||  |     ||  ||||     || | |||   |  \n    ||   |||| |  | ||||  | |   ||    |||\\+++-+++----+--++----+-+---++---+++++---++-+-++--++-++-++--+-----++++-/ |||  |     ||  ||||     || | |||   |  \n    ||   |||| |  | ||||  | |   ||    \\++-+++-+++----+--++----+-+---++---+++++---++-+-++--++-++-++--+-----++++---+++--+-----++--++/|     || | |||   |  \n    ||   |||| |  | ||||  | |   ||     || ||| ||\\----+--++----/ |   ||   |||||   || | ||  || || ||  |     ||||   |||  |     ||  || |     || | |||   |  \n    ||   |||| |  | ||||  | |   ||     || ||| ||     |  |\\------+---++---+++++---++-+-++--++-+/ ||  |     ||||   ||| /+-----++--++-+\\    || | |||   |  \n    ||   ||\\+-+--+-++++--+-+---++-----++-+++-++-----+--+-------+---++---+++++---++-+-++--++-+--++--+-----++++---+/| ||     ||  || ||    || | |||   |  \n    ||   || | |  | ||||  | |   ||     || ||| ||  /--+--+-------+---++---+++++---++-+-++--++-+--++--+-<---++++--\\\\-+-++-----++--++-/|    || | |||   |  \n /--++---++-+-+--+-++++--+-+---++----\\|| ||| ||  |  |  |       |   ||   |||||   || | ||  || |  ||  |     ||||  |  | ||     ||  ||  |    || | |||   |  \n |  ||   || | |  | ||||  | |   ||    ||| |\\+-++--+--+--+-------+---++---+++++---++-+-++--++-+--++--+-----++++--+--+-++-----++--/|  |    || | |||   |  \n |  ||   || | |  | ||||  | |   ||    ||| | | ||  |  |  |       |   ||   |\\+++---++-+-/\\--++-+--++--+-----++++--+--+-++-----++---+--+----++-+-++/   |  \n |  ||   \\+-+-+--+-++++--+-+---++----++/ | | ||  |  |  |       |   ||   | |||   || |     || |  ||  |     ||||  |  | ||     ||   |  |    || | ||    |  \n |  ||    | | |  | ||||  | |   ||    ||/-+-+-++-\\|  |  |       |   ||  /+-+++---++-+-----++-+--++--+-----++++--+--+-++\\    |\\---+--+----++-+-+/    |  \n |  ||    | | |  | ||||  | |   ||    ||| | | || ||  |  | /-----+---++-\\|| |||   || |     || |  ||  ^     ||||  |  | |||    |    |  |    || | |     |  \n |  ||    | \\-+--+-++++--+-+---/|    ||| | | || ||  |  | |     |   || ||| |||   |\\-+-----++-+--++--+-----++++--+--+-+++----+----+--+----/| | |     |  \n |  ||    |   |  | ||||  | |    |    ||| \\-+-++-++--+--+-+-----+---++-+++-+++---+--+-----++-+--++--+-----/|||  |  | |||    |    |  |     | | |     |  \n |  ||    |   |  \\-++++--+-+----+----+++---/ || ||  |  | |     |   || ||| |||   |  |     || |  ||  |      ||| /+--+-+++--\\ |    |  |     | | |     |  \n |  ||    |   |    ||||  | |    |    |||     \\+-++--+--+-+-----+---+/ ||| |||   |  |     || |  ||  |      ||| ||  | |||  | |    |  |     | | |     |  \n |  ||    |   \\----++++--+-/    |    |||      | ||  |  | |     |   \\--+++-+++---+--+-----++-+--++--+------+++-++--+-+++--+-+----+--+-----+-/ |     |  \n |  ||    |        ||||  |      \\----+++------+-++--+--+-+-----+------+++-+++---+--+-----/| |  \\+--+------/|| ||  | |||  | |    |  |     |   |     |  \n |  |\\----+--------++++--+-----------+++-<----+-++--+--+-+-----+------+++-+++---+--+------+-+---+--+-------+/ ||  | |||  | |    |  |     |   |     |  \n |  |     |        |\\++--+-----------+++------/ |\\--+--+-+-----+------+++-+++---+--+------+-+---+--+-------+--+/  | |||  | |    |  |     |   |     |  \n |  |     |        | ||  |           |||        |   |  | |     |      ||| |\\+---+--+--<---+-+---+--+-------+--+---+-+++--+-/    |  |     |   |     |  \n |  |     |        | ||  |           |||        |   |  | |     |      ||| | \\---+--+------+-+---+--+-------+--+---+-+++--+------+--+-----+---/     |  \n |  |     |        | ||  |           ||\\--------/   |  | \\-----+------/|| |     |  |      | |   |  |       |  |   | |||  |      |  |     |         |  \n |  |     |        | ||  |           ||             |  |       |       || |     |  \\------+-+---+--+-------+--+---/ \\++--+------+--/     |         |  \n |  |     |        | ||  \\-----------++-------------+--+-------+-------++-+-----+---------+-/   |  |       |  |      ||  |      |        |         |  \n |  |     |        | |\\--------------++-------------+--+-------+-------++-+-----+---------+-----/  |       |  |      ||  |      |        |         |  \n |  \\-----+--------+-+---------------++-------------+--+-------+-------+/ |     |         |        |       |  \\------++--/      |        |         |  \n |        |        | |               ||             |  |       |       \\--+-----+---------+--------+-------+---------+/         |        |         |  \n |        |        | |               ||             |  |       |          |     |         |        |       |         |          |        |         |  \n |        |        | |               ||             |  |       |          |     |       /-+--------+-------+---------+----------+--------+--\\      |  \n \\--------+--------+-+---------------/|             |  |       |          |     |       | |        |       |         |          |        |  |      |  \n          \\--------+-+----------------+-------------+--+-------/          |     |       | |        |       |         |          |        |  |      |  \n                   | |                |             |  \\------------------+-----+-------+-+--------+-------+---------+----------+--------/  |      |  \n                   | \\----------------+-------------+---------------------+-----+-------+-+--------+-------+---------/          |           |      |  \n                   \\------------------+-------------+---------------------+-----+-------+-/        |       |                    |           |      |  \n                                      |             |                     |     |       |          |       \\--------------------+-----------+------/  \n                                      |             |                     |     \\-------+----------+----------------------------/           |         \n                                      |             |                     \\-------------+----------/                                        |         \n                                      \\-------------/                                   |                                                   |         \n                                                                                        \\---------------------------------------------------/         ");
            Assert.That("38,57", Is.EqualTo(solver.ExecutePart1()));
            Assert.That("4,92", Is.EqualTo(solver.ExecutePart2()));
        }
    }
}
