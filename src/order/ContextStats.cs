using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] data, long origin)
        {
            long mix = 420;
            foreach (long reading in data)
            {
                mix = ((mix ^ reading) % 101) - origin;
            }
            return mix;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricLimits(long[] values, long target)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Total { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((4.57 - 2.69) < (double)item)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
