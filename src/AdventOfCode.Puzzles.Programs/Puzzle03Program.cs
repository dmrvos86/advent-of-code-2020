﻿using System;

namespace AdventOfCode.Puzzles.Runner
{
    internal class Puzzle03Program
    {
        private static void Main(string[] args)
        {
            var result1 = Puzzle03.CountTreesEncountered(PuzzleInput.ToPuzzle3Input(),  (3, 1));

            var steps = new (int down, int right)[] { (1, 1), (3, 1), (5, 1), (7, 1), (1, 2) };
            var result2 = Puzzle03.CountTreesEncounteredMultiplyByRows(PuzzleInput.ToPuzzle3Input(), steps);

            Console.WriteLine($"Trees encountered (task 1): {result1}");
            Console.WriteLine($"Trees encountered (task 2): {result2}");
        }

        private static readonly string PuzzleInput = @".....#.##......#..##..........#
##.#.##..#............##....#..
......###...#..............#.##
.....#..##.#..#......#.#.#..#..
..#.......###..#..........#.#..
..#..#.##.......##.....#....#..
.##....##....##.###.....###..#.
..##....#...##..#....#.#.#.....
.....##..###.##...............#
#.....#..#....#.##...####..#...
#......#.#....#..#.##....#..#.#
##.#...#.#............#......#.
.#####.......#..#.#....#......#
..#.#....#.#.##...#.##...##....
.....#.#...#..####.##..#.......
#....#...##.#.#.##.#..##.....#.
##.##...#....#...#......#..##..
....##...#..#.#...#.#.#.....##.
..#....##......##....#.#....#..
#..#....#....###..#.##....#.#.#
..#.#####..##....#....#.....##.
.#...##.......#...#....#.#...##
#.#.#.##.......#.....#.#.#....#
.#.#.....#.......#.......##....
.#......#....#....#.......##...
#......#.....#......#..#..#....
#.#...#...#....##....#.#...#..#
....#.....##...#...#..#.#......
..#......#..........#...#.#....
..#..#......####..##...###.....
.#.....#...##...#.##........###
#.#....#..#....#..#.....#.#..#.
...##.##.#.#.##...#.....#......
##....#.#.#...####.#.#.#.#.....
.##.........#..#..###..........
..##.###.#..#..#....##.....#...
##........#..###....#.#..#..#..
....#.#.......##..#.#.#.#......
....##.....#.........##.......#
..#........##.#.........###..##
....#..................##..#...
#...#.#..###..#.....#..#..#...#
..#..#.##..#..#.......#.......#
.....#..##..#....##...........#
..##...#........#...#.#.......#
.........#.#..#.#..#.##.#.###..
....#...#..#..#......##....#.#.
..#..#.#....#....#..#.####..##.
##....#.....#......##.###.#..#.
#..#..##..###......#.#.#.#...#.
.......#..##..##...#...#..#....
..#.###.#...#....#.##.#.....##.
.#.#.......##...##...##....#...
#...#.#.#...#.####..#..##......
###..#.##..#..........#...#....
##.#.........#..##......####...
..##.#..#....#.##..............
...#....#.......###............
...#.....##....#.#.#.#.......##
###.###...#...#...###.##...##..
#.#....#.##..#.....#.....##.#..
...#....#....#.........#....#.#
##.#....#........#..#..##.#....
.#.#..#.......#...##.......#...
.##...##........#....#.#..#....
....#..#.##.###.....#.#........
.#.#...#.#..#.....#.........#..
.......#.#.#..##....#.........#
.##...#....#..#...#........#..#
....#....#..#.#..#.#.#....##.##
..##....#.....##..#.#...#...#..
#.##.........#.....#.......#.##
...#...##.#.#..........#......#
###...#.....#..#.......#####..#
#.####...##.#.#..#...#.........
.##.....#.....##..#...##.##....
.........###...#......##....###
.#....##...###.#..#...##..#.#.#
.......#.......#.#...##.#......
.....#.#........#..##.....##...
....#.#.........##.#...##..#.#.
#..#..#.##..#.##.##.....##.###.
..##.........###...#....#....#.
.###...#..#.##...........#.....
#..##..........#..........#....
.....#.#....#..##..#...#.#....#
..#.....#.#....#...##.##.......
##.....##........#....#..##....
.#..#.#.........#..#..#........
.............##....#....#..#...
....##....#..#.#.##....###.##.#
.###..#.....#..#..##..#..##..#.
...#..###.......#.#....#..###..
#.#..#.....#...#......#........
#..#..............###.#......#.
..#....##.#....#.##.#.#...#....
.........##..#...#.#.......#...
........#...#.#....#.....##..#.
...#.##..#..#..###..#..#......#
.....####......#...#....#...#.#
...###.#.#......#....#.......#.
#...##.#....#....##....##.###..
.......##...##.....#.##.#..#..#
.....#.#............##...#.####
.##..#.#.#.#..#.#.#.....#.##...
.#..####...#.#....#.....#..#...
....##..#.#...#..#....#.#......
...#......###..#..###..#.....#.
.#.#.#..##....#...##..#.....#..
###....#....#...##.....#...#...
#.##....#......#...###.........
.#..#.#...#..#....#....#....#..
...............##...####..#..#.
#.#...........####..#...##.....
##.#....#........#......#...##.
......#...#...#....#....#.....#
#......#.............#....###..
.#...#...##.....#...##.##..#...
..#.#......#.#........#........
.......#..#.#...##..#.#.#......
..##...#.##........#....#.#...#
.....#..#..#........#.#......##
....#.#...##............##....#
.#.#....#.#.#...#...#.##.....#.
#.#.##...#....#.#.#..#.##..#.#.
.........####..#...#...#.......
#..#..####......#..##..#...#...
.........##..................#.
.....##.#..##.#.#...#......##..
...#....#....#.#.....#...#..#.#
#...##.#...##...........#..#...
#..........#.#..#..#.##..#..#.#
.#...#.##...#.#.#..#.......##..
.........#...........#..#..#...
.##...##....#.#......#........#
#.#...........#....#.......#...
##.#.#.......#...###......##..#
...###..#.##..##.#.#.......#...
.#...#..##.#...#........#.....#
...#.......#..#..........#.#...
..#.#.#.#.....#.#.......#..#..#
#.##.....#..##...#..###.#....#.
.......#...........#...#....###
.......#..#...#.............#..
#.....###.......#...#........#.
.#..#..#..#...........#........
....#.#...#.#.##.#.#....#.##..#
.......#..##...##...#...#......
...#.....##.###...#.#...##....#
#..#....#...##......#....##....
#.#.......#....#.###.##..#..#..
..##...........#...#....#......
.#........#.....#..#..#...#..##
.....#.#.#..#.......#....#.....
#..#.#......#......##....#.....
##.....................##......
.##........###..#.........#...#
........#.........#..#.........
.#.##....#.....#...#.........##
....##......#.........#........
...#.#..#...##.##.#.#..####....
..##...........##.#.#....#.....
.#.....#.#...#..#.......#....#.
....#...#......##...#...##.#..#
....#..##....#..#.........##.#.
..##...##.##....#....##.###...#
..#....##..##.#.#.#...#......#.
##...#.........#...........#...
.##....##.#.....#...#.......#..
..........##.###.##....###....#
..........#..##..#....#.#.##.##
........##.#...#.#.#.#...###.#.
.#......#.#.#...###.#.#.#......
.........#......#......#...#..#
......#.....#.##....##.#####..#
..#..##...###.#..........#.#.#.
.#..#....###.#...#..#....#...##
...................#..........#
....###.....#...##......#.....#
#.....#..##.....#.#..........#.
..#.......##.#....#..#.##.#...#
........##.#..###..#......##...
#...........##.#...###..#....#.
....#...........#.....#.#...#..
.##..#.#...#...#.##...#..#.....
#........#.#.#.#.#.#...........
#..#.....#..#..#.##....#....#.#
..#............##....#.#.##...#
.....###.#....#.#......#.###...
...#.....#.#.................#.
..#...##..#.#...#...#...#.....#
.##.#........#..#....##..#..##.
.#..........#...#.#..#..#.#....
#.......##.........#.##..#.####
.#..............#.......##.....
#......#.##..........#..#......
..##...#...#.#...#............#
.##.##..##..##........##.....#.
.....#..#.....##...............
.#..#...##...#...#.....#.......
#......#...#.......#..##.###.##
###..##......##......###....#..
....#..........#...#.##.#.....#
.........#....#..#..#.#..##....
.....#.....#...........#......#
.#.......#...#....##...#.##...#
..##.#..............#..#...#.#.
.#..####.#.........#....#....#.
..###.#...#..#......#.......###
.#.#..##...###...#...#.#...#.#.
...#..##..###.#..#.....#.##....
#...###.#...##.....####.....#..
.#.##...#..#.#..##.....#.......
...#.##.....##.....#....#......
.#...##.....#..###..#..........
..........#...#.....#....##.#..
.......#...#...#...#........#..
#....##..#...#..##.#.#.....#...
.#.#..............#..#....#....
.####.#.#.###......#...#.#....#
.#...#...##.#...............#.#
...#.......##...#...#....##....
#..........###.##..........##.#
.......#...#....#.#..#.#....#..
....#.##.#...###..#..##.##.....
..#.#.#......#.#.......###.....
#..................#.##....#...
#.....#..#.#.#..#...#.........#
..#..#...#.#.##........#.......
#..#.#..#..........###...#.#...
.......#.##....#........##.#...
.####.#.#...#.#...##.##.....###
........#.#...#.#..##...##.....
....##.##......#.##.........#..
.#..#...#.#...........#........
.......#..........#....#...#...
..###.#.###..#..#.....#..##....
.#..........#.......##...#.....
.#.....#...#........#...#.##..#
.#..#.......#..#.......#.#.#...
....#..##.#...##...#.#....#....
.....#.........#..#..#....#....
..#.#..##....#..#..##.#.#.....#
........#.#...###....#.#.#.....
.#.....#.......#..###.#........
.......#...#.#...#...##........
##.............#.#.....#.#..#..
.#....#.......#.#.......#..##..
#.....#........#..##..##.......
...........#.........###......#
....#.##...#.#...#...#....#..##
......#..##......#......#.##.#.
......##....####...###...#.....
#....#..........#.#.##.....#..#
....#.#...........#.#.#.#.#...#
....####.....##...#..##..#...#.
#....#.###..###.....#..###.....
..##.........#......#...##.#...
..#.....#.#...#.##.#...#..###.#
..#.##..##........#.......#.###
.....#..........#.....#....#...
.......##..##..###.......#####.
..###......#.#....###....##...#
#..##.....#..###...#.....##.##.
#..#..##.##.###.####.##.#......
.#.#......#.##......#..#......#
..###.....#.#......#.#.####....
#..............#..#.#...#.###..
...#..#.##..........##.#...#.##
.#.#.#.........#....#.#..#.....
..#.##..#...#..#...#......#....
.......#...#.##.#.#..#...##..#.
..........#.####...#........#.#
....#...#....##.#.........#.#..
##.#..#.......###....#..#..#.#.
..##.....#..#.#.#.####......#..
.#.....#..........#..#..#.#....
......#.#.......#.#...#..#..#..
...#...............#....#...#..
##.......#.........#.......#...
...#.......###...#.#...#.......
#...###....#....##....#....#...
...#....##..#.#.............##.
.....#.#.#..#......#...#.#..#..
.##....#..##..#####..##.....##.
....##.#.#..#.....#.#...#......
...#.....##.#.#..##..#.#.......
.......#..#..#..........#......
.......#...#..#.........#.##...
..#..#..#...##..#.#....#......#
..#....#...#.#......#........#.
.#...#..#...#.#..........#.....
#..#...####..#......##.##.#.#..
.#...#.#...#.#.....#..##.#.....
..#.##.#......#.........##...#.
###..............#.............
...#...###....#..#.............
.##....#......#..#.....#..#..#.
.#..........#.....##...#..#....
....##..#.#......###.##......#.
.#..##.#.##.#...##.#......###.#
#..###.#...###..#........#.#...
#..#.#.#..#...###.##.##..#..#..
#.#..#....#.........##......#..
....###.....###....#...........
....#..##.##....##..#.....#....
.#.....#....####...#..##.#..###
.........##..#......#.#...##...
.##.......#.....#.###.#..#.#..#
.....#.#...###.....#......####.
##.#...#......#.#.#..#.####...#
.#.##.....#..#..#.............#
.#..###..#..#......#..##......#
.......#.#........##.....#.#...
#....#...#..###..#.#.....#.##..
.##.....#.#....###..#.....##...
...##....#....#...#....#.#.#...
#####..#...........###....#...#
.#.......##.##.....#....#......
.#..#.#...#..#......#...#..#.#.
....#.....##...#####..#...#...#
###.##...#.#............#....#.
.....#...#........##.........#.";
    }
}