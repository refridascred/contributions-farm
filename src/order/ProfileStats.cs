using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= seed) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsOutliers(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((value - count) > count)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            New,
            Ready,
            Queued,
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterOutliers(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((matches ^ sample) > (matches - sample))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
