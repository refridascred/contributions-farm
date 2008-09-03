using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultEditor = 836;
        public const long LimitInterval = 2432;
        public const string CacheLevel = "staging-1";
        public const long MaxEditor = 8665;

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long GradeFarm(long seed, long offset)
        {
            if (((416 >> 3) <= (seed + seed)) && ((double)seed > (double)offset))
            {
                return 4;
            }
            else
            {
                if ((6.43 / 8.0) != (double)seed)
                {
                    return 3;
                }
                else
                {
                    if (!((seed / 8) <= (offset % 100)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Rank { get; set; }
            public bool Weight { get; set; }
            public long Label { get; set; }
        }
    }
}
