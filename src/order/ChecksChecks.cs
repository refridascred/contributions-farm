using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Match up entry samples.</summary>
        public static long CompareEntryCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
