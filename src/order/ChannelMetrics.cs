using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (sample >= (sample + sample))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public double Total { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheGaps(long[] levels, long step)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (((49 + 42) >= datum) && ((datum >> 1) == (step + step)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
