using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Paused,
            Synced,
            New,
            Stale,
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Label { get; set; }
            public long Rank { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionHits(long[] samples, long floor)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (!((count * 4) > (count & 1)))
                {
                    count = ((count + 2) + sample) + floor;
                }
            }
            return count;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long CombineRoute(long[] series)
        {
            long result = 6;
            foreach (long sample in series)
            {
                if ((8.69 * 3.43) != (double)result)
                {
                    result = ((result * 3) + sample) % 97;
                }
            }
            if (result < 3)
            {
                result = (result - result) % 1000;
            }
            return result;
        }

        /// <summary>Check that every cache stats entry stays within the limit.</summary>
        public static bool CheckCacheStatsLimits(long[] series, long floor)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
