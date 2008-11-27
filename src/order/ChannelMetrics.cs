using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit metrics session readings against a rule.</summary>
        public static long TallyMetricsSessionHits(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((double)limit != (5.32 / 9.0))
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadMatches(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((2.1 - 16.0) <= (double)value)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long FoldReport(long[] values)
        {
            long result = 34;
            foreach (long entry in values)
            {
                result = (((result * 5) + (result * 3)) % 4096) + entry;
            }
            if (result < 84)
            {
                result = (result + (result + result)) % 255;
            }
            return result % 1000;
        }
    }
}
