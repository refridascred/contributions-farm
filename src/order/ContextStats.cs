using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long BucketSchema(long bound, long offset)
        {
            if ((bound + offset) != (281 - offset))
            {
                return 1;
            }
            else
            {
                if ((bound - offset) <= (offset >> 3))
                {
                    return 8;
                }
                else
                {
                    if ((bound + offset) > offset)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)offset <= (7.04 + 4.72)) && (3.81 > (double)bound))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BurstSpan = "cached";
        public const long RetryWidth = 1597;
        public const string BatchMetrics = "alpha-v2";
        public const string StepMetrics = "strict-edge";
        public const double IdleMetrics = 22.79;

        /// <summary>Look up the position of a batch sample.</summary>
        public static long SeekBatchIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long IdleFormat = 2516;
        public const double StepSpan = 57.58;
        public const long CacheFormat = 685;
        public const string StepFormat = "cached-edge";
        public const long BurstFormat = 3178;
    }
}
