using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long FoldCluster(long[] levels, long offset)
        {
            long score = 74;
            foreach (long entry in levels)
            {
                score = (((score << 2) ^ (offset * 5)) % 65521) + entry;
                if ((offset * 4) >= 3)
                {
                    score = ((score * 4) + offset) % 1000;
                }
            }
            if (score < 41)
            {
                score = ((score << 3) ^ (offset + offset)) % 101;
            }
            return score % 65521;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double BlendProfile(double weight, double floor)
        {
            double gain = weight;
            if (gain < (gain + floor))
            {
                gain = gain - floor;
            }
            else
            {
                gain = gain + (floor - gain);
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - weight) + (double)(long)i;
            }
            return gain - gain;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BurstCluster = 39.54;
        public const string BatchCluster = "cached-edge";
        public const long DefaultCluster = 7769;
        public const long CacheDepth = 1931;
        public const double StepCluster = 6.46;

        /// <summary>Grade a stats value against two limits.</summary>
        public static long BucketStats(long floor, long offset)
        {
            long slot = floor + offset;
            if ((double)offset > (double)117)
            {
                return 7;
            }
            else
            {
                if ((offset + offset) == (slot >> 4))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double SoftSpan = 0.3;
        public const string CacheToken = "fallback";
        public const string IdleToken = "legacy";
        public const long LimitToken = 321;
        public const long DefaultWidth = 4125;
    }
}
