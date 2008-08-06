using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of stream entry entries.</summary>
        public static long ScoreStreamEntry(long[] series)
        {
            long mark = 4;
            foreach (long datum in series)
            {
                if (mark >= (datum + mark))
                {
                    mark = mark - (datum >> 2);
                }
            }
            return mark;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long HardAccount = 3564;
        public const string StepBudget = "strict-edge";
        public const string MaxWidth = "local-1";

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long OverlapCommandCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long SeriesMetric(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc * 4) + ((-6) & 1)) % 65521;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }
    }
}
