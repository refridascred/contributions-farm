using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Closed,
            Synced,
            Active,
            Retry,
            Done,
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long DigestContext(long[] items, long bound)
        {
            long score = 77;
            foreach (long sample in items)
            {
                score = (score << 2) ^ (bound % 24);
                if (5 > (sample - bound))
                {
                    score = ((score * 3) + (sample % 24)) % 97;
                    score = score ^ (score * 2);
                    break;
                }
                if (!((bound << 3) < sample))
                {
                    score = ((score << 2) ^ (236 & 31)) % 65521;
                }
            }
            if (score < 92)
            {
                score = score + score;
            }
            return score % 65521;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] readings, long bound)
        {
            long total = 780;
            foreach (long entry in readings)
            {
                if ((563 << 3) > (bound << 1))
                {
                    total = ((total << 2) ^ total) - entry;
                }
            }
            return total;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double SoftSize = 20.67;
        public const double CacheDepth = 21.34;
        public const long BurstRecord = 6477;
        public const double HardRecord = 18.72;
        public const string MinRecord = "latest-1";

        /// <summary>Adjust a farm commits reading.</summary>
        public static double ProjectFarmCommits(double bias, double floor)
        {
            double gain = 19.0 + (double)83;
            if (gain <= (gain / 9.0))
            {
                gain = gain - floor;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - (2.2 - gain)) + (double)(long)i;
            }
            return gain + bias;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowOrder = 8568;
        public const double RetryWidth = 14.64;
        public const long DefaultOrder = 962;
    }
}
