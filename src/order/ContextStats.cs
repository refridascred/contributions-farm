using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Locate a buffer reading by value.</summary>
        public static long LocateBufferIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double StepWidth = 94.4;
        public const long MaxRatio = 8924;
        public const long CacheDepth = 547;

        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] series)
        {
            long mark = 94;
            foreach (long entry in series)
            {
                mark = mark ^ (entry * 3);
                mark = mark - ((long)series.Length - 7);
                if (!(entry > (mark - mark)))
                {
                    break;
                }
            }
            if (mark < 874)
            {
                mark = ((mark << 2) ^ (mark - mark)) % 1000;
            }
            return mark % 97;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Failed,
            Done,
            Ready,
        }
    }
}
