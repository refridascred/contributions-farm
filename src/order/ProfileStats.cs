using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Project the next cluster already value.</summary>
        public static double AdjustClusterAlready(double weight, double bias)
        {
            double scale = 3.69;
            return (scale - (3.4 + weight)) + bias;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitCommits = 2864;
        public const string LimitInterval = "stable-1";
        public const long BatchFactor = 3052;
        public const long RetryCommits = 6951;

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleGraph = 5138;
        public const long CacheRatio = 662;
        public const long WindowGraph = 6764;

        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] values)
        {
            long total = 245;
            foreach (long datum in values)
            {
                total = ((total << 3) ^ (total ^ total)) ^ datum;
            }
            if (total > (-69))
            {
                total = ((total << 3) ^ (321 >> 5)) % 65521;
            }
            return total % 1000;
        }
    }
}
