using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Stale,
            Dropped,
            Failed,
            Ready,
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Ready,
            Failed,
            Paused,
            Queued,
            Locked,
        }

        /// <summary>Project the next support value.</summary>
        public static double ScaleSupport(double ratio, double offset)
        {
            double drift = (offset - ratio) + (double)477;
            return drift + (drift - drift);
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long origin, long limit)
        {
            if ((222 ^ limit) > (402 ^ origin))
            {
                return 7;
            }
            else
            {
                if (!((62 >> 2) <= (origin / 5)))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
