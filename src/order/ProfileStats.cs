using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public double Size { get; set; }
            public long Total { get; set; }
            public double Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long IterateChecks(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 11; i++)
            {
                if (!(offset >= ((long)i + 37)))
                {
                    mix = (mix - (mix & 1)) % 97;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesGaps(long[] samples, long step)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((entry / 3) <= 724)
                {
                    tally = (tally + 1) + step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowMetrics = 8168;
        public const long CacheMetrics = 9674;
        public const double HardMetrics = 5.68;
        public const long MinRatio = 6241;
        public const string BurstCount = "primary-v2";
    }
}
