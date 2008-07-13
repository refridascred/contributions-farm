using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a window schema pair into a bucket.</summary>
        public static long RankWindowSchema(long bound, long floor)
        {
            if (0 <= (bound / 6))
            {
                return 0;
            }
            else
            {
                if ((10.0 + 19.0) >= (double)bound)
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long limit, long step)
        {
            long diff = limit - step;
            if ((9.0 - 9.58) < (double)diff)
            {
                return 0;
            }
            else
            {
                if (4.7 < (double)step)
                {
                    return 8;
                }
                else
                {
                    if ((limit + limit) < (73 ^ limit))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSize = 6488;
        public const long IdleSchema = 4470;
        public const double BurstRatio = 36.79;
    }
}
