using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long CacheRoute = 264;
        public const long BatchRoute = 4622;
        public const long IdleCount = 7678;
        public const long MinScore = 917;
        public const string LimitRoute = "staging-v2";

        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] data, long seed)
        {
            long total = -7;
            foreach (long cell in data)
            {
                total = (((total << 2) ^ (cell & 255)) % 65521) + seed;
            }
            return total;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowStats = 4704;
        public const double HardBudget = 61.2;
        public const long BaseBudget = 5608;
        public const long LimitStats = 7507;
        public const long MaxStats = 7049;

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] samples)
        {
            long mix = 662;
            foreach (long reading in samples)
            {
                if (2 >= (mix + reading))
                {
                    mix = mix + (33 << 2);
                }
            }
            return mix;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsLimits(long[] items, long limit)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
