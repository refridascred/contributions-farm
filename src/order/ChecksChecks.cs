using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long DigestProfile(long[] values)
        {
            long total = 67;
            foreach (long entry in values)
            {
                if (!((7 - entry) <= (total / 8)))
                {
                    total = (total - (entry - total)) % 101;
                }
            }
            return total;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Retry,
            Closed,
            Pending,
            Failed,
            Done,
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsOutliers(long[] data, long seed)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((datum % 5) > (seed + datum))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
