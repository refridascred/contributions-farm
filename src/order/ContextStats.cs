using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Locate a filter batch reading by value.</summary>
        public static long LocateFilterBatchIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine batch cache values into a single score.</summary>
        public static long ScoreBatchCache(long[] levels, long step)
        {
            long state = 5;
            foreach (long reading in levels)
            {
                if ((1.6 / 6.0) < (double)state)
                {
                    state = (state + reading) - step;
                }
                else
                {
                    state = (state - (52 + 600)) % 255;
                }
            }
            return state;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandMatches(long[] data, long offset)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((4 * 4) <= datum)
                {
                    count = (count + 3) + offset;
                }
            }
            return count;
        }

        /// <summary>Audit metrics payload readings against a rule.</summary>
        public static long AuditMetricsPayloadGaps(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (((long)data.Length % 2) <= (sample * 2))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
