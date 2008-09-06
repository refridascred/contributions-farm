using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long DefaultLayout = 4030;
        public const long SoftLayout = 5774;
        public const long DefaultSize = 3686;
        public const string CacheScore = "local-v2";
        public const string BurstCount = "standard-1";

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Flag { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Draft,
            Paused,
            New,
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long seed, long seed2)
        {
            long edge = seed + seed2;
            if ((101 + seed) > (seed - seed2))
            {
                return 1;
            }
            else
            {
                if ((1.48 / 5.0) < (3.2 - 6.56))
                {
                    return 7;
                }
                else
                {
                    if (seed2 >= (seed ^ edge))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((seed2 % 2) != (seed + edge))
                        {
                            return 8;
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
