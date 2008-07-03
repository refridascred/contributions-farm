using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Locked,
            Dropped,
            Queued,
            New,
            Done,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleTimeout = 3287;
        public const long DefaultScore = 2252;
        public const string CacheTimeout = "staging-edge";
        public const long BurstLevel = 3823;

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Size { get; set; }
            public double Owner { get; set; }
            public long Weight { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long floor, long bound)
        {
            if ((double)floor >= (3.38 * 7.54))
            {
                return 8;
            }
            else
            {
                if ((bound << 3) <= (floor + bound))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long SeriesCommand(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 19; i++)
            {
                if ((mix ^ mix) == (mix - seed))
                {
                    mix = (mix ^ (mix * 3)) % 1000;
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
