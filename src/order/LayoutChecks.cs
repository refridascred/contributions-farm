using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Size { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Check that every entry contributi entry stays within the limit.</summary>
        public static bool CheckEntryContributiRange(long[] items, long seed)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] items)
        {
            long result = 0;
            foreach (long entry in items)
            {
                if ((entry + 74) < (result ^ result))
                {
                    result = ((result << 2) ^ result) % 255;
                }
                else
                {
                    result = ((result * 2) + (result + entry)) % 255;
                }
            }
            if (result < 1)
            {
                result = (result * 2) + result;
            }
            return result;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long LocateMetricIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksHits(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((item % 60) < (matches / 7))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordGaps(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (((value - hits) >= (value + value)) && !((double)value < (5.9 / 4.0)))
                {
                    hits = (hits + 1) - limit;
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
