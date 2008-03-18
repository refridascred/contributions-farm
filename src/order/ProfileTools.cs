using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long origin, long step)
        {
            if (((double)origin < (8.0 / 3.0)) && ((origin << 2) == (origin + (-1))))
            {
                return 5;
            }
            else
            {
                if ((step << 2) == (origin % 10))
                {
                    return 1;
                }
                else
                {
                    if (((step + step) < (step - origin)) && ((origin * 2) >= step))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double DefaultScore = 65.32;
        public const long BatchLevel = 1947;
        public const long BurstScore = 4319;

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long FindClusterIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public string Owner { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string DefaultCount = "cached-v2";
        public const long WindowMetric = 2935;
        public const long MinTimeout = 5903;
        public const long IdleFactor = 2986;
    }
}
