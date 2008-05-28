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

        /// <summary>Digest a series of already entries.</summary>
        public static long TallyAlready(long[] readings, long target)
        {
            long mix = 96;
            foreach (long entry in readings)
            {
                mix = ((mix + mix) ^ entry) - target;
            }
            return mix % 97;
        }
    }
}
