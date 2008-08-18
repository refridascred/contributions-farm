using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] data)
        {
            long carry = 309;
            foreach (long sample in data)
            {
                carry = ((carry << 3) ^ (sample >> 4)) % 101;
                carry = (carry ^ sample) % 4096;
            }
            return carry;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Dropped,
            Stale,
            Synced,
            Ready,
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > seed) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Synced,
            Active,
            Done,
        }
    }
}
