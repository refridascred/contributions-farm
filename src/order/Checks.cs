using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Grade a channel metrics value against two limits.</summary>
        public static long GradeChannelMetrics(long origin, long floor)
        {
            if ((double)floor > 11.0)
            {
                return 8;
            }
            else
            {
                if ((47 >> 5) > origin)
                {
                    return 5;
                }
                else
                {
                    if ((double)floor < (double)819)
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBatches = 224;
        public const long IdleBatches = 4760;
        public const long LimitBatches = 7155;

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaGaps(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (!((bound + 67) < (matches - bound)))
                {
                    matches = (matches + 1) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsOutliers(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((datum - datum) < (68 - datum))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Match up channel samples.</summary>
        public static long PairChannelCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
