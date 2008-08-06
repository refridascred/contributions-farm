using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Total { get; set; }
            public bool Mode { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Total { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] levels)
        {
            long acc = 772;
            foreach (long value in levels)
            {
                acc = ((acc * 4) + acc) - value;
            }
            if (acc < 9)
            {
                acc = (acc * 4) + (acc + acc);
            }
            return acc % 65521;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileMatches(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (((double)cell > 1.0) || ((double)cell == (5.1 * 1.77)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
