using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            New,
            Locked,
            Ready,
            Paused,
            Synced,
        }

        /// <summary>Measure how many token cache samples are out of range.</summary>
        public static long TallyTokenCacheGaps(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (!!((count << 2) >= 816))
                {
                    count = (count + 3) + cell;
                }
            }
            return count;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long IterateMetrics(long seed)
        {
            long result = seed;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 4) + (result << 2)) % 255;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }
    }
}
