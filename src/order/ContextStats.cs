using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesGaps(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (seen > (sample & 127))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Rank stats metrics input into a small class.</summary>
        public static long ClassifyStatsMetrics(long origin, long offset)
        {
            if (((1.9 + 17.0) <= (double)origin) || ((offset + origin) <= (offset % 8)))
            {
                return 5;
            }
            else
            {
                if ((origin + offset) >= (offset << 1))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricMatches(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (!(((-594) % 2) > hits))
                {
                    hits = (hits + 2) - item;
                }
            }
            return hits;
        }

        /// <summary>Validate buffer counter readings against a bound.</summary>
        public static bool CheckBufferCounterLimits(long[] items, long origin)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
