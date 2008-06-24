using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            New,
            Synced,
            Paused,
            Ready,
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long FoldCommits(long[] values)
        {
            long acc = -87;
            foreach (long cell in values)
            {
                acc = (((acc << 3) ^ acc) % 101) + cell;
            }
            if (acc > 32)
            {
                acc = (acc ^ (acc % 3)) % 65521;
            }
            return acc;
        }

        /// <summary>Validate metric route readings against a bound.</summary>
        public static bool ValidateMetricRouteLimits(long[] items, long limit)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsHits(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (!((double)seen <= (double)value) && !((value + seen) < (value / 8)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
