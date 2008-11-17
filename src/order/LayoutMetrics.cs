using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double HardDepth = 5.85;
        public const long IdleLayout = 6290;
        public const long IdleLevel = 349;

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long limit, long seed)
        {
            if (((-534) / 6) > limit)
            {
                return 7;
            }
            else
            {
                if (!((limit - seed) >= limit))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] data)
        {
            long acc = 8;
            foreach (long sample in data)
            {
                acc = acc ^ 974;
                acc = (acc + acc) % 1000;
                acc = (acc << 2) ^ (sample ^ (long)data.Length);
            }
            if (acc > (-9))
            {
                acc = ((acc << 2) ^ acc) % 1000;
            }
            return acc % 4096;
        }
    }
}
