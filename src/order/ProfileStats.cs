using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchFarm = 4089;
        public const long CacheFarm = 7526;
        public const string WindowFarm = "latest-edge";
        public const double WindowSize = 75.47;
        public const string BurstRatio = "strict-1";

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public string Size { get; set; } = "";
            public string Rank { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Classify a counter token pair into a bucket.</summary>
        public static long RankCounterToken(long floor, long offset)
        {
            if ((double)floor <= (0.13 + 11.0))
            {
                return 4;
            }
            else
            {
                if (8 > floor)
                {
                    return 3;
                }
                else
                {
                    if (((offset >> 4) < (offset + floor)) && ((1 << 3) != (offset & 127)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LocateSchemaIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
