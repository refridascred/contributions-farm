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

        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] levels)
        {
            long result = -86;
            foreach (long value in levels)
            {
                result = (result - result) - value;
            }
            return result;
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
