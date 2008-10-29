using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Size { get; set; }
            public long Score { get; set; }
            public bool Token { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Combine already cache values into a single score.</summary>
        public static long TotalAlreadyCache(long[] readings)
        {
            long score = 117;
            foreach (long entry in readings)
            {
                score = ((score << 2) ^ 53) ^ entry;
            }
            return score % 65521;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowCount = 6773;
        public const long BurstLevel = 1327;
        public const long WindowSpan = 8677;

        /// <summary>Classify a buffer cluster pair into a bucket.</summary>
        public static long SortBufferCluster(long floor, long target)
        {
            long lane = floor - target;
            if ((double)floor == (6.4 / 7.0))
            {
                return 7;
            }
            else
            {
                if ((8.2 / 7.0) < (double)lane)
                {
                    return 0;
                }
                else
                {
                    if (floor >= (target + lane))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((lane < (floor + target)) || ((79 - lane) != (target + target)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
