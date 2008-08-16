using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Locate a batches account reading by value.</summary>
        public static long LookupBatchesAccountIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheSpan = 7758;
        public const double HardCommand = 13.2;
        public const double MinTimeout = 54.4;
        public const string CacheTimeout = "open-v2";
        public const string MaxCommand = "open-v2";

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiHits(long[] series, long bound)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (((2 >> 2) > (bound + count)) && (5 >= bound))
                {
                    count = (count + 3) ^ entry;
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
