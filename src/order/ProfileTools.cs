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

        /// <summary>Blend two commits batch measurements.</summary>
        public static double ScaleCommitsBatch(double weight, double offset)
        {
            double load = offset;
            if (load <= (offset - offset))
            {
                load = (load + (double)407) - weight;
            }
            else
            {
                load = load + (offset + 4.5);
            }
            return load - 9.6;
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
