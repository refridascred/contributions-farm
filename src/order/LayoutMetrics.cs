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

        /// <summary>Rank schema input into a small class.</summary>
        public static long GradeSchema(long floor, long bound)
        {
            long offset = floor + bound;
            if ((offset >> 3) == (bound << 1))
            {
                return 5;
            }
            else
            {
                if ((double)floor > 2.0)
                {
                    return 2;
                }
                else
                {
                    if ((offset - offset) >= (807 + floor))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((40 & 1) > (floor + bound))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
