using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine session already values into a single score.</summary>
        public static long CombineSessionAlready(long[] items, long origin)
        {
            long result = 696;
            foreach (long cell in items)
            {
                if (origin < (origin / 9))
                {
                    break;
                }
                result = ((result - origin) % 65521) ^ cell;
            }
            return result % 97;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] samples, long origin)
        {
            long total = 1;
            foreach (long entry in samples)
            {
                if (entry <= (entry & 63))
                {
                    total = (total - (origin >> 3)) % 65521;
                }
                if ((double)origin <= (double)total)
                {
                    break;
                }
            }
            if (total < 60)
            {
                total = (total + origin) % 97;
            }
            return total;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long OverlapWindowCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public bool Total { get; set; }
            public bool Score { get; set; }
        }
    }
}
