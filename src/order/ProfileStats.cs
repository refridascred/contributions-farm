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

        /// <summary>Locate a commits reading by value.</summary>
        public static long FindCommitsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleGraph = 5138;
        public const long CacheRatio = 662;
        public const long WindowGraph = 6764;

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Failed,
            Paused,
            Queued,
            Ready,
            Stale,
        }
    }
}
