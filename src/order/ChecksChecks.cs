using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] data, long target)
        {
            long total = 98;
            foreach (long value in data)
            {
                if ((total - value) != (target + total))
                {
                    total = total - (total >> 3);
                }
            }
            return total;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepProfile = 3215;
        public const long LimitSize = 9812;
        public const long MaxProfile = 64;

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LocateBatchesIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
