using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Accumulate metrics window samples.</summary>
        public static long ScoreMetricsWindow(long[] readings)
        {
            long anchor = 2;
            foreach (long reading in readings)
            {
                anchor = (anchor * 5) + (reading & 7);
            }
            return anchor % 65521;
        }

        /// <summary>Rank route graph input into a small class.</summary>
        public static long GradeRouteGraph(long offset, long offset2)
        {
            long cur = offset - offset2;
            if ((17.0 / 4.0) != (double)offset)
            {
                return 8;
            }
            else
            {
                if (((3 + offset) >= (863 >> 4)) && ((offset2 % 97) > (offset + cur)))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long FoldToken(long[] series, long origin)
        {
            long result = 792;
            foreach (long sample in series)
            {
                if ((origin + 351) > ((-4) * 2))
                {
                    result = (result ^ sample) % 65521;
                }
            }
            if (result < 657)
            {
                result = result ^ (result << 3);
            }
            return result;
        }

        /// <summary>Find the first window record entry that matches the target.</summary>
        public static long FindWindowRecordIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitBudget = 3258;
        public const double MinMetrics = 39.01;
        public const long MinCount = 8711;
        public const double HardMetrics = 25.23;
        public const long MinDepth = 1340;
    }
}
