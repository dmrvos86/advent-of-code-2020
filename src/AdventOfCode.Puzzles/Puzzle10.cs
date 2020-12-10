using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.Puzzles
{
    public static class Puzzle10
    {
        public static long Task1(IEnumerable<int> input)
        {
            var takenAdapters = new List<int>();
            var differences = new List<int>();

            for (int i = 0; i < input.Count(); i++)
            {
                var adapter = input.ElementAt(i);

                if (takenAdapters.Any())
                {
                    differences.Add(adapter - takenAdapters.Last());
                }
                else
                {
                    differences.Add(adapter);
                }

                takenAdapters.Add(adapter);
            }
            differences.Add(3);

            return differences.Where(x => x == 1).Count() * differences.Where(x => x == 3).Count();
        }

        public static long Task2(IEnumerable<int> input)
        {
            return CountDistinctConnections(input.Prepend(0).Append(input.Max() + 3).ToList());
        }

        public static IEnumerable<int> ToPuzzle10Input(this string input)
        => input
            .Split("\r\n")
            .Select(x => Convert.ToInt32(x))
            .OrderBy(x => x);

        private static long CountDistinctConnections(List<int> input)
        {
            // Find all three-diffs
            var diffs = new List<int>();
            for (var i = 1; i < input.Count; i++)
            {
                if ((input[i] - input[i - 1]) == 3)
                    diffs.Add(i);
            }

            long matches = 0;
            for (var i = 0; i < diffs.Count; i++)
            {
                var startIndex = i == 0 ? 0 : diffs[i - 1];
                var elementCount = i == 0 ? diffs[i] : diffs[i] - diffs[i - 1];

                var range = input.GetRange(startIndex, elementCount).ToList();
                var matchesSubset = CountSegmentPermutations(range);
                matches = matches > 0 ? (matches * matchesSubset) : matchesSubset;
            }

            var rangeLast = input.Skip(diffs.Last()).ToList();
            if (rangeLast.Any())
            {
                var matchesSubsetLast = CountSegmentPermutations(rangeLast);
                matches = matches > 0 ? (matches * matchesSubsetLast) : matchesSubsetLast;
            }

            return matches;
        }

        private static int CountSegmentPermutations(IEnumerable<int> input)
        {
            var dataToProcess = new List<IEnumerable<int>> { input };
            var permutations = new List<IEnumerable<int>>();

            while (dataToProcess.Any())
            {
                var data = dataToProcess[0];
                dataToProcess.RemoveAt(0);
                permutations.Add(data);

                if (data.Count() <= 2)
                    continue;

                for (int i = 1; i < data.Count() - 1; i++)
                {
                    var el1 = data.ElementAt(i - 1);
                    var el2 = data.ElementAt(i);
                    var el3 = data.ElementAt(i + 1);

                    if (el3 - el1 <= 3)
                        dataToProcess.Add(data.Take(i).Concat(data.Skip(i + 1)));
                }
            }

            return permutations.Select(x => string.Join(',', x)).Distinct().Count();
        }
    }
}