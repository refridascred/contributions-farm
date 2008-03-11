using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long limit, long offset)
        {
            long lane = limit - offset;
            if ((575 / 4) < (offset << 3))
            {
                return 8;
            }
            else
            {
                if (18 < (limit + lane))
                {
                    return 2;
                }
                else
                {
                    if (!((offset + offset) > (offset % 12)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((lane / 3) != (offset & 255))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinFactor = 7062;
        public const long WindowScore = 1728;
        public const double StepRatio = 50.16;

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultLevel = 1732;
        public const long WindowMetric = 2857;
        public const long RetryMetric = 5861;
        public const long BatchSpan = 7010;
        public const long MaxMetric = 3129;

        /// <summary>Match up commits samples.</summary>
        public static long CompareCommitsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
