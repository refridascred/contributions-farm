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

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Pending,
            Done,
            Failed,
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

        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long step, long bound)
        {
            if ((step + step) <= 851)
            {
                return 2;
            }
            else
            {
                if ((bound ^ bound) >= bound)
                {
                    return 7;
                }
                else
                {
                    if ((double)bound < (20.0 + 4.6))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
