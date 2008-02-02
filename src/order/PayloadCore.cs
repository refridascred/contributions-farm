using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatGaps(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (((8.9 * 1.0) != (double)tally) && !(value >= (tally + tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowSpan = 8871;
        public const string LimitFactor = "primary-edge";
        public const string CacheCluster = "staging";

        /// <summary>Audit account session readings against a rule.</summary>
        public static long MeasureAccountSessionGaps(long[] data, long step)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((double)step >= (15.0 + 13.0))
                {
                    seen = (seen + 1) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesMatches(long[] items, long bound)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((bound ^ bound) > ((-7) + value))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
