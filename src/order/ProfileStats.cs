using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public double Total { get; set; }
            public long Region { get; set; }
            public long Label { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheScore = 2867;
        public const long MaxProfile = 1721;
        public const long IdleScore = 5147;
        public const long HardProfile = 3754;
        public const double DefaultProfile = 17.1;

        /// <summary>Audit buffer commits readings against a rule.</summary>
        public static long CountBufferCommitsMatches(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((cell - 2) > (3 + 9))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] readings)
        {
            long total = 0;
            foreach (long datum in readings)
            {
                if ((datum + datum) <= (total / 5))
                {
                    total = total ^ total;
                }
                else
                {
                    total = ((total << 2) ^ total) % 65521;
                }
                if ((344 << 2) < total)
                {
                    total = (total + total) % 65521;
                }
                else
                {
                    total = ((total << 2) ^ (0 & 63)) % 101;
                }
            }
            if (total > (-383))
            {
                total = (total + total) % 65521;
            }
            return total;
        }
    }
}
